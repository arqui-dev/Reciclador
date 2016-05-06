using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Classe que gerencia o carregamento de dados externos, seja de arquivo ou de uma fonte WWW.
/// </summary>
public class GerenciadorCarregamento : MonoBehaviour
{
	// Tipos de fontes do arquivo de empreendimentos, interno da pasta Resources ou externo.
	public enum TipoCarregamento {
		InternoResources, ExternoWWW
	}

	/// <summary>	/// Quantidade do tipo de recicladoras existentes, papel, vidro, metal e plastico: 4.	/// </summary>
	public const int quantidadeTiposRecicladoras = 4;

	/// <summary>	/// Separador de linhas para o parser.	/// </summary>
	static string [] separadorLinhas = {"\n","\n\r","\r\n","\r"};

	/// <summary>	/// Divisor de tag/descriçao do item.	/// </summary>
	static string [] divisor = {"::"};

	/// <summary>	/// Caminho para o arquivo texto de empreendimentos na pasta Resources.	/// </summary>
	static string caminhoEmpreendimentos = "empreendimentos";

	// Strings usadas para reconhecimento do parser
	static string parseEmpreendimento = "empreendimento";
	static string parseNome = "nome";
	static string parseDescricao = "descricao";
	static string parseNivelMaximo = "nivelmaximo";
	static string parseNivelEmpreendimento = "nivelempreendimento";
	static string parseValorVenda = "valorvenda";
	static string parseExperiencia = "experiencia";
	static string parseVelocidadeAparecerLixo = "velocidadeaparecerlixo";
	static string parseLimiteFila = "limitefila";
	static string parseLixoMinimo = "lixominimo";
	static string parseVelocidadeReciclagem = "velocidadereciclagem";
	static string parseDinheiroGerado = "dinheirogerado";
	static string parseSeparacaoAutomatica = "separacaoautomatica";
	static string parsePoderJogador = "poderjogador";
	static string parsePreco = "preco";
	static string parseNivelSustentabilidade = "nivelsustentabilidade";
	static string parseEmpreendimentosConstruidos = "empreendimentosconstruidos";
	static string parseFimEmpreendimento = "fimempreendimento";

	static public int porcentagemAtual = 0;
	static public int porcentagemMaxima = 1;
	static public int porcentagemMinima = 0;

	/// <summary>
	/// Carrega todos os empreendimentos de um arquivo de texto.
	/// </summary>
	/// <returns>Lista com os empreendimentos existentes.</returns>
	static public Empreendimento [] CarregarEmpreendimentos(
		TipoCarregamento tipo = TipoCarregamento.InternoResources)
	{
		string textoBruto;

		/*
		switch(tipo)
		{
		default:
			textoBruto = CarregarStringDeResources(
				caminhoEmpreendimentos);
			break;
		}
		//*/

		textoBruto = ArquivoStrings.empreendimentos;

		string [] linhas = RemoverLinhasComentarios(textoBruto);

		List<Empreendimento> empreendimentos = new List<Empreendimento>();

		porcentagemMaxima = linhas.Length;

		int i = 0;
		while(i < linhas.Length)
		{
			if (CarregamentoAssincrono.pronto == false)
			{
				porcentagemMinima = i;
			}
			porcentagemAtual = i;

			Debug.Log("Max: "+porcentagemMaxima + ", Min: "+porcentagemMinima+", Atual: "+porcentagemAtual);
			if (linhas[i].StartsWith(parseEmpreendimento))
			{
				string identificador = linhas[i].Split(
					divisor,System.StringSplitOptions.None)[1];

				List<string> novoEmpreendimento = new List<string>();

				int j = i + 1;
				while (!linhas[j].ToLower().StartsWith(
					(parseFimEmpreendimento)))
				{
					novoEmpreendimento.Add(linhas[j]);
					j++;
				}

				empreendimentos.Add(PegarEmpreendimento(
					identificador, novoEmpreendimento.ToArray()));

				//novoEmpreendimento.Clear();

				i = j;
			}
			i++;
		}

		/*
		foreach(Empreendimento e in empreendimentos)
		{
			Debug.Log (e.ToString() + "\n");
		}
		//*/


		return empreendimentos.ToArray();
	}

	/// <summary>
	/// Verifica as linhas passadas e retorna o empreendimento descrito nelas.
	/// </summary>
	/// <returns>Empreendimento.</returns>
	/// <param name="identificador">Identificador do empreendimento.</param>
	/// <param name="linhas">Lista das linhas que contem a descrição do empreendimento.</param>
	static Empreendimento PegarEmpreendimento(
		string identificador, string [] linhas)
	{
		string nome = "";
		string descricao = "";
		int nivelMaximo = 1;

		// Verifica as linhas para encontrar o nome, descrição e
		// o nível máximo do empreendimento.
		foreach(string linha in linhas)
		{
			string [] linhaAtual = linha.Split(
				divisor, System.StringSplitOptions.None);

			if (linhaAtual[0].StartsWith(parseNome))
			{
				nome = linhaAtual[1];
			}
			else if (linhaAtual[0].StartsWith(parseDescricao))
			{
				descricao = linhaAtual[1];
			}
			else if (linhaAtual[0].StartsWith(parseNivelMaximo))
			{
				int nmax = 0;
				if (int.TryParse(linhaAtual[1], out nmax))
				{
					nivelMaximo = nmax;
				}
			}
		}

		float [,] velocidades = new 
			float[nivelMaximo,quantidadeTiposRecicladoras];
		float [,] valoresVenda = new 
			float[nivelMaximo,quantidadeTiposRecicladoras];
		float [] experiencias = new float[nivelMaximo];
		float [] velocidadesLixos = new float[nivelMaximo];
		int [,] limitesRecicladoras = new
			int[nivelMaximo,quantidadeTiposRecicladoras];
		int [] lixosMinimos = new int[nivelMaximo];
		int [] dinheiros = new int[nivelMaximo];
		int [] separacoes = new int[nivelMaximo];
		int [] poderes = new int[nivelMaximo];
		int [] precos = new int[nivelMaximo];
		int [] sustentabilidades = new int[nivelMaximo];
		Dictionary<int,Dictionary<string, int>> construidos = 
			new Dictionary<int,Dictionary<string, int>>();



		for(int i = 0; i < nivelMaximo; i++)
		{
			construidos[i+1] = new Dictionary<string, int>();
		}

		int nivelAtual = 1;

		// Verifica a entrada para encontrar os aprimoramentos e
		// requisitos de cada nível do empreendimento.
		foreach(string linha in linhas)
		{
			string [] linhaAtual = linha.Split(
				divisor, System.StringSplitOptions.None);


			// Verifica cada linha e procura o comando que ela chama.
			if (linhaAtual[0].StartsWith(parseNivelEmpreendimento))
			{
				int nv = 0;
				if (int.TryParse(linhaAtual[1], out nv))
				{
					nivelAtual = nv;
				}
			}
			else if (linhaAtual[0].StartsWith(parseValorVenda))
			{
				linhaAtual[1] = linhaAtual[1].Replace(" ","");
				linhaAtual[1] = linhaAtual[1].Replace("\t","");
				
				string [] valores = linhaAtual[1].Split(',');

				for (int i = 0; i < quantidadeTiposRecicladoras; i++)
				{
					valoresVenda[nivelAtual-1,i] = 0;
					float valor = 0;
					if (valores.Length > i && float.TryParse(valores[i], out valor))
					{
						valoresVenda[nivelAtual-1,i] = valor / 100f;
					}
				}
			}
			else if (linhaAtual[0].StartsWith(parseExperiencia))
			{
				float f = 0;
				experiencias[nivelAtual-1] = 0;
				if (float.TryParse(linhaAtual[1], out f))
				{
					experiencias[nivelAtual-1] = f / 100f;
				}
			}
			else if (linhaAtual[0].StartsWith(parseVelocidadeAparecerLixo))
			{
				float f = 0;
				velocidadesLixos[nivelAtual-1] = 0;
				if (float.TryParse(linhaAtual[1], out f))
				{
					velocidadesLixos[nivelAtual-1] = f / 100f;
				}
			}
			else if (linhaAtual[0].StartsWith(parseLimiteFila))
			{
				linhaAtual[1] = linhaAtual[1].Replace(" ","");
				linhaAtual[1] = linhaAtual[1].Replace("\t","");
				
				string [] valores = linhaAtual[1].Split(',');
				
				for (int i = 0; i < quantidadeTiposRecicladoras; i++)
				{
					limitesRecicladoras[nivelAtual-1,i] = 0;
					int valor = 0;
					if (valores.Length > i && int.TryParse(valores[i], out valor))
					{
						limitesRecicladoras[nivelAtual-1,i] = valor;
					}
				}

			}
			else if (linhaAtual[0].StartsWith(parseLixoMinimo))
			{
				int i = 0;
				lixosMinimos[nivelAtual-1] = 0;
				if (int.TryParse(linhaAtual[1], out i))
				{
					lixosMinimos[nivelAtual-1] = i;
				}
			}
			else if (linhaAtual[0].StartsWith(parseVelocidadeReciclagem))
			{
				linhaAtual[1] = linhaAtual[1].Replace(" ","");
				linhaAtual[1] = linhaAtual[1].Replace("\t","");
				
				string [] valores = linhaAtual[1].Split(',');
				
				for (int i = 0; i < quantidadeTiposRecicladoras; i++)
				{
					velocidades[nivelAtual-1,i] = 0;
					float valor = 0;
					if (valores.Length > i && float.TryParse(valores[i], out valor))
					{
						velocidades[nivelAtual-1,i] = valor / 100f;
					}
				}
			}
			else if (linhaAtual[0].StartsWith(parseDinheiroGerado))
			{
				int i = 0;
				dinheiros[nivelAtual-1] = 0;
				if (int.TryParse(linhaAtual[1], out i))
				{
					dinheiros[nivelAtual-1] = i;
				}
			}
			else if (linhaAtual[0].StartsWith(parseSeparacaoAutomatica))
			{
				int i = 0;
				separacoes[nivelAtual-1] = 0;
				if (int.TryParse(linhaAtual[1], out i))
				{
					separacoes[nivelAtual-1] = i;
				}
			}
			else if (linhaAtual[0].StartsWith(parsePoderJogador))
			{
				int i = 0;
				poderes[nivelAtual-1] = 0;
				if (int.TryParse(linhaAtual[1], out i))
				{
					poderes[nivelAtual-1] = i;
				}
			}
			else if (linhaAtual[0].StartsWith(parsePreco))
			{
				int i = 0;
				precos[nivelAtual-1] = 0;
				if (int.TryParse(linhaAtual[1], out i))
				{
					precos[nivelAtual-1] = i;
				}
			}
			else if (linhaAtual[0].StartsWith(parseNivelSustentabilidade))
			{
				int i = 0;
				sustentabilidades[nivelAtual-1] = 0;
				if (int.TryParse(linhaAtual[1], out i))
				{
					sustentabilidades[nivelAtual-1] = i;
				}
			}
			else if (linhaAtual[0].StartsWith(parseEmpreendimentosConstruidos))
			{
				linhaAtual[1] = linhaAtual[1].Replace(" ","");
				linhaAtual[1] = linhaAtual[1].Replace("\t","");

				string [] construcoes = linhaAtual[1].Split(';');

				if (!construidos.ContainsKey(nivelAtual))
				{
					construidos.Add(nivelAtual, new Dictionary<string, int>());
				}

				if ((construcoes != null && construcoes.Length > 0))
				{
					foreach(string c in construcoes)
					{
						if (string.IsNullOrEmpty(c))
						{
							continue;
						}

						string [] constr = c.Split(':');

						construidos[nivelAtual].Add(constr[0], 1);
						int i = 0;
						if (int.TryParse(constr[1], out i))
						{
							construidos[nivelAtual][constr[0]] = i;
						}
					}
				}

				//Debug.Log ("Nivel "+nivelAtual+": "+construidos[nivelAtual].Count);
			}
		}

		// Cria uma string de saída, para debug.
		/*
		string saida = "";
		saida += identificador + ":\nnome: " + nome + "\ndescricao: ";
		saida += descricao + "\nnivel maximo: " + nivelMaximo + "\n";
		for (int i = 0; i < nivelMaximo; i++)
		{
			saida += "nivel " + (i+1) + "\n";
			saida += "velocidades:";
			for (int j = 0; j < quantidadeTiposRecicladoras; j++)
			{
				saida += " "+ velocidades[i,j]+";";
			}
			saida += "\n";
			saida += "valores venda:";
			for (int j = 0; j < quantidadeTiposRecicladoras; j++)
			{
				saida += " "+ valoresVenda[i,j]+";";
			}
			saida += "\n";
			saida += "limite filas:";
			for (int j = 0; j < quantidadeTiposRecicladoras; j++)
			{
				saida += " "+ limitesRecicladoras[i,j]+";";
			}
			saida += "\n";
			saida += "experiencia: "+experiencias[i] + "\n";
			saida += "velocidade lixo: "+velocidadesLixos[i] + "\n";
			saida += "lixo minimo: "+lixosMinimos[i] + "\n";
			saida += "dinheiro: " + dinheiros[i] + "\n";
			saida += "automatico: " + separacoes[i] + "\n";
			saida += "poder: " + poderes[i] + "\n";
			saida += "preco: " + precos[i] + "\n";
			saida += "sustentabilidade: " + sustentabilidades[i] + "\n";
			saida += "contruidos: ";
			foreach(string s in construidos[i+1].Keys)
			{
				saida += s + ": " + construidos[i+1][s] + "; ";
			}
			saida += "\n";
		}
		Debug.Log (saida);
		//*/

		// Pega o resltado do parser e converte para um objeto Empreendimento.
		Empreendimento empreendimento = new Empreendimento();
		empreendimento.identificador = identificador;
		empreendimento.nome = nome;

		empreendimento._limiteRecicladoras = new Vector4[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._limiteRecicladoras[i].x = limitesRecicladoras[i, 0];
				empreendimento._limiteRecicladoras[i].y = limitesRecicladoras[i, 1];
				empreendimento._limiteRecicladoras[i].z = limitesRecicladoras[i, 2];
				empreendimento._limiteRecicladoras[i].w = limitesRecicladoras[i, 3];
			}
		empreendimento._velocidadeReciclagem = new Vector4[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._velocidadeReciclagem[i].x = velocidades[i, 0];
				empreendimento._velocidadeReciclagem[i].y = velocidades[i, 1];
				empreendimento._velocidadeReciclagem[i].z = velocidades[i, 2];
				empreendimento._velocidadeReciclagem[i].w = velocidades[i, 3];
			}
		empreendimento._valorDeVenda = new Vector4[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._valorDeVenda[i].x = valoresVenda[i, 0];
				empreendimento._valorDeVenda[i].y = valoresVenda[i, 1];
				empreendimento._valorDeVenda[i].z = valoresVenda[i, 2];
				empreendimento._valorDeVenda[i].w = valoresVenda[i, 3];
			}

		empreendimento._descricao = new string[nivelMaximo + 1];
			for (int i = 0; i < (nivelMaximo + 1); i++)
			{
				empreendimento._descricao[i] = descricao;
			}
		empreendimento._aumentoXP = new float[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._aumentoXP[i] = experiencias[i];
			}
		empreendimento._velocidadeAparecerLixo = new float[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._velocidadeAparecerLixo[i] = velocidadesLixos[i];
			}
		empreendimento._nivelMinimoLixo = new int[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._nivelMinimoLixo[i] = lixosMinimos[i];
			}
		empreendimento._dinheiroPorTempo = new long[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._dinheiroPorTempo[i] = (long) dinheiros[i];
			}
		empreendimento._separacaoAutomatica = new int[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._separacaoAutomatica[i] = separacoes[i];
			}
		empreendimento._taxaSeparacaoLixo = new int[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._taxaSeparacaoLixo[i] = poderes[i];
			}

		empreendimento._custos = new long[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._custos[i] = (long) precos[i];
			}
		empreendimento._nivelRequisito = new int[nivelMaximo];
			for (int i = 0; i < nivelMaximo; i++)
			{
				empreendimento._nivelRequisito[i] = sustentabilidades[i];
			}
		empreendimento._empreendimentosRequisitos = construidos;


		return empreendimento;
	}

	/// <summary>
	/// Carrega um arquivo txt doa pasta resources e retorna a string contida nele.
	/// </summary>
	/// <returns>A string contida no arquivo.</returns>
	/// <param name="filepath">Caminho do arquivo dentro da pasta Resources, sem a extensao.</param>
	static string CarregarStringDeResources(string filepath)
	{
		TextAsset textAsset = Resources.Load<TextAsset>(filepath);
		if (string.IsNullOrEmpty(textAsset.text))
			return null;
		return textAsset.text;
	}

	/// <summary>
	/// Remove as linhas em branco, as linhas comentadas, e os espaços ate os ::.
	/// </summary>
	/// <returns>Uma lista com os comandos limpos.</returns>
	/// <param name="empreendimento">String com o empreendimento ja carregado de um arquivo.</param>
	static string [] RemoverLinhasComentarios(string empreendimento)
	{
		if (string.IsNullOrEmpty(empreendimento))
			return null;

		string [] linhas = empreendimento.Split(
			separadorLinhas,System.StringSplitOptions.None);

		List<string> saida = new List<string>();

		foreach (string s in linhas)
		{
			if (s.Contains(divisor[0]))
			{
				string [] atual = s.Split(
					divisor,System.StringSplitOptions.None);

				atual[0] = atual[0].Replace(" ","");
				atual[0] = atual[0].Replace("\t","");

				saida.Add(atual[0] + divisor[0] + atual[1]);
			}
		}

		return saida.ToArray();
	}
	
}


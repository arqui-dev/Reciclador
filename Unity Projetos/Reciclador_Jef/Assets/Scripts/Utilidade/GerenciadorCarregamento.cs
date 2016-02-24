using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Classe que gerencia o carregamento de dados externos, seja de arquivo ou de uma fonte WWW.
/// </summary>
public class GerenciadorCarregamento : MonoBehaviour
{
	static int maximoNivelMaximo = 6;

	static string [] separadorLinhas = {"\n","\n\r","\r\n","\r"};
	static string comentario = "##";
	static string [] divisor = {"::"};
	static string caminhoEmpreendimentos = "empreendimentos";

	static string parseEmpreendimento = "empreendimento";
	static string parseNome = "nome";
	static string parseDescricao = "descricao";
	static string parseNivelMaximo = "nivelmaximo";
	static string parseNivel = "nivel";
	static string parseAtributos = "atributos";
	static string parseVelocidadeReciclagem = "velocidadereciclagem";
	static string parseDinheiroGerado = "dinheirogerado";
	static string parseSeparacaoAutomatica = "separacaoautomatica";
	static string parsePoderJogador = "poderjogador";
	static string parseRequisitos = "requisitos";
	static string parsePreco = "preco";
	static string parseNivelSustentabilidade = "nivelsustentabilidade";
	static string parseEmpreendimentosConstruidos = "empreendimentosconstruidos";
	static string parseFimEmpreendimento = "fimempreendimento";

	/// <summary>
	/// Carrega todos os empreendimentos de um arquivo de texto, da pasta Resources.
	/// </summary>
	/// <returns>Lista com os empreendimentos existentes.</returns>
	static public Empreendimento [] CarregarEmpreendimentos()
	{
		string textoBruto = CarregarStringDeResources(
			caminhoEmpreendimentos);

		string [] linhas = RemoverLinhasComentarios(textoBruto);

		List<Empreendimento> empreendimentos = new List<Empreendimento>();

		int i = 0;
		while(i < linhas.Length)
		{
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

				i = j;
			}
			i++;
		}


		return null;
	}

	static Empreendimento PegarEmpreendimento(
		string identificador, string [] linhas)
	{
		Empreendimento empreendimento = new Empreendimento();
		string nome = "";
		string descricao = "";
		int nivelMaximo = 1;

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

		float [] velocidades = new float[nivelMaximo];
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

		foreach(string linha in linhas)
		{
			string [] linhaAtual = linha.Split(
				divisor, System.StringSplitOptions.None);

						
			if (linhaAtual[0].StartsWith(parseNivel))
			{
				int nv = 0;
				if (int.TryParse(linhaAtual[1], out nv))
				{
					nivelAtual = nv;
				}
			}
			else if (linhaAtual[0].StartsWith(parseVelocidadeReciclagem))
			{
				float f = 0;
				velocidades[nivelAtual-1] = 0;
				if (float.TryParse(linhaAtual[1], out f))
				{
					velocidades[nivelAtual-1] = f / 100f;
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

				string [] contrucoes = linhaAtual[1].Split(';');
				foreach(string c in contrucoes)
				{
					string [] constr = c.Split(':');

					construidos[nivelAtual][constr[0]] = 1;
					int i = 0;
					if (int.TryParse(constr[1], out i))
					{
						construidos[nivelAtual][constr[0]] = i;
					}
				}
			}
		}

		string saida = "";

		saida += identificador + ":\nnome: " + nome + "\ndescricao: ";
		saida += descricao + "\nnivel maximo: " + nivelMaximo + "\n";
		for (int i = 0; i < nivelMaximo; i++)
		{
			saida += "nivel " + (i+1) + "\n";
			saida += "velocidade: " + velocidades[i] + "\n";
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
		}

		Debug.Log (saida);

		return null;
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

	void Awake()
	{
		CarregarEmpreendimentos();
	}
}


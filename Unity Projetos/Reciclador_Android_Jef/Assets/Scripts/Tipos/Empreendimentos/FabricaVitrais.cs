using UnityEngine;
using System.Collections;

public class FabricaVitrais : IValoresEmpreendimentos
{
	
	string 	nome			= "Fábrica de Vitrais";
	string 	identificador	= "FabricaVitrais";
	public string Nome()
	{
		return nome;
	}

	public string Identificador()
	{
		return identificador;
	}

	public int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = nivel / 7;
		return retorno;
	}

	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel - 0;
		if (v <= 0) return 0;
		long retorno = v * 5;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		// 5% de XP por nível
		float retorno = nivel * 0.09f;
		return retorno;
	}

	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		int div = 2;
		retorno[1] = (nivel + 1) / div + 1;
		return retorno;
	}

	int redutorNivelValorVenda = 3;
	public float []	ValorDeVenda(int nivel)
	{
		int nv = nivel - redutorNivelValorVenda;
		float [] retorno = {0f,0f,0f,0f};
		if (nv <= 0) return retorno;

		float porcentagem = 1f;
		retorno[1] = ((nv * (nv + 1)) / 2) * porcentagem;

		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		retorno[1] = nivel * 0.05f;
		return retorno;
	}
	//

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}

	public string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		//retorno += "Custo: "+Custos(nivel)+"\n\n";
		if (TaxaSeparacaoLixo(nivel+1) > 0)
		{
			retorno += "Dano extra:\t\t"+TaxaSeparacaoLixo(nivel)+" -> "+ TaxaSeparacaoLixo(nivel+1)+"\n";
		}
		retorno += "$ por tempo:\t"+DinheiroPorTempo(nivel)+" -> "+ DinheiroPorTempo(nivel+1)+"\n";
		retorno += "XP extra:\t\t\t"+(AumentoXP(nivel)*100f).ToString("0")+"% -> "+(AumentoXP(nivel+1)*100f).ToString("0")+"%\n";
		retorno += "$ reciclagem Vidro:\t"+(ValorDeVenda(nivel)[1]*100f).ToString("0")+"% -> "+(ValorDeVenda(nivel+1)[1]*100f).ToString("0")+"%\n";
		retorno += "Limite Recic Vidro:\t"+(LimiteRecicladoras(nivel)[1])+" -> "+(LimiteRecicladoras(nivel+1)[1])+"\n";
		retorno += "Vel Reciclagem Vdr:\t"+(VelocidadeReciclagem(nivel)[1]*100f).ToString("0")+"% -> "+(VelocidadeReciclagem(nivel+1)[1]*100f).ToString("0")+"%\n";

		return retorno;
	}

	public string DescricaoTexto(int nivel)
	{
		string retorno = "O vidro pode passar por esse processo infinitas vezes sem perda de qualidade ou pureza do produto. Isso tudo nos mostra a importância da conscientização de todos, para que realizem em suas residências a coleta seletiva do vidro para a sua reciclagem. ";
		return retorno;
	}

	// REQUISITOS
	public long		Custos(int nivel)
	{
		int nv = nivel + 1;
		long retorno = nv * nv * 50; // nível ao quadrado * 10
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		int retorno = nivel * 4 + 10;
		return retorno;
	}
}


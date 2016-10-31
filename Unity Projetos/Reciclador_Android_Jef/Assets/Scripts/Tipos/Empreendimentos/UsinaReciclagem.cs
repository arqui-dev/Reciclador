using UnityEngine;
using System.Collections;

public class UsinaReciclagem : IValoresEmpreendimentos
{
	

	string 	nome			= "Usina de Reciclagem";
	string 	identificador	= "UsinaReciclagem";
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
		int retorno = nivel * 2;
		return retorno;
	}

	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno =  v * v * 100;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		// 5% de XP por nível
		float retorno = nivel * 5.4f;
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
		int div = 5;
		retorno[0] = (nivel + 1) / div + 1;
		retorno[1] = (nivel + 1) / div + 1;
		retorno[2] = (nivel + 1) / div + 1;
		retorno[3] = (nivel + 1) / div + 1;
		return retorno;
	}

	public float []	ValorDeVenda(int nivel)
	{
		int nv = nivel;
		float [] retorno = {0f,0f,0f,0f};
		if (nv <= 0) return retorno;

		float porcentagem = 5f;
		retorno[0] = nv * nv * porcentagem;
		retorno[1] = nv * nv * porcentagem;
		retorno[2] = nv * nv * porcentagem;
		retorno[3] = nv * nv * porcentagem;

		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		float porcentagem = 0.04f;
		retorno[0] = nivel * porcentagem;
		retorno[1] = nivel * porcentagem;
		retorno[2] = nivel * porcentagem;
		retorno[3] = nivel * porcentagem;
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
		retorno += "$ reciclagem:\t"+(ValorDeVenda(nivel)[0]*100f).ToString("0")+"% -> "+(ValorDeVenda(nivel+1)[0]*100f).ToString("0")+"%\n";
		retorno += "Limite Recic:\t"+(LimiteRecicladoras(nivel)[0])+" -> "+(LimiteRecicladoras(nivel+1)[0])+"\n";
		retorno += "Vel Reciclag:\t"+(VelocidadeReciclagem(nivel)[0]*100f).ToString("0")+"% -> "+(VelocidadeReciclagem(nivel+1)[0]*100f).ToString("0")+"%\n";

		return retorno;
	}

	public string DescricaoTexto(int nivel)
	{
		string retorno = "A reciclagem é uma atividade industrial que diminui o consumo de recursos naturais e impede que estes resíduos acumulem em aterros sanitários e gera renda no processo.";
		return retorno;
	}

	// REQUISITOS
	public long		Custos(int nivel)
	{
		int nv = nivel + 1;
		long retorno = nv * nv * nv * 2000;
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		int retorno = nivel * 5 + 25;
		return retorno;
	}
}


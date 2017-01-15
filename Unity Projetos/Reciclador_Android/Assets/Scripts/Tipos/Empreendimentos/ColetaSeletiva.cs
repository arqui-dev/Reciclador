using UnityEngine;
using System.Collections;

public class ColetaSeletiva : IValoresEmpreendimentos
{
	// Alterar o nome do construtor para ser igual ao nome da classe
	/*
	public ColetaSeletiva()
	{
		FuncoesEmpreendimentos.AdicionarValoresEmpreendimento(
			nome,
			identificador,

			TaxaSeparacaoLixo,
			DinheiroPorTempo,
			AumentoXP,
			NivelMinimoLixo,

			LimiteRecicladoras,
			ValorDeVenda,
			VelocidadeReciclagem,
			VelocidadeAparecerLixo,

			SeparacaoAutomatica,
			Descricao,
			Custos,
			NivelRequisito
		);
	}
	*/
	public int ID()
	{
		return -1;
	}

	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

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


	//**************************************************************
	string 	nome			= "Coleta Seletiva";
	string 	identificador	= "ColetaSeletiva";

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
		int retorno = nivel / 4;
		if (nivel >= 3) retorno++;
		return retorno;
	}

	// a cada 10 segundos
	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno = v * 5;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		float retorno = nivel * 0.2f;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		return retorno;
	}
		
	public float []	ValorDeVenda(int nivel)
	{
		int nv = nivel;
		float [] retorno = {0f,0f,0f,0f};
		if (nv <= 0) return retorno;

		float porcentagem = 0.1f;
		retorno[0] = nv * porcentagem;
		retorno[1] = nv * porcentagem;
		retorno[2] = nv * porcentagem;
		retorno[3] = nv * porcentagem;

		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}
	//

	// REQUISITOS
	public long		Custos(int nivel)
	{
		int nv = nivel + 1;
		long retorno = nv * nv * 10; // nível ao quadrado * 10
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		int retorno = nivel * 2;
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
		retorno += "$ reciclagem:\t"+(ValorDeVenda(nivel)[0]*100f).ToString("0")+"% -> "+(ValorDeVenda(nivel+1)[0]*100f).ToString("0")+"%";

		return retorno;
	}

	public string DescricaoTexto(int nivel)
	{
		string retorno = "Coleta seletiva é a coleta diferenciada de resíduos que foram previamente separados segundo a sua constituição ou composição. Ou seja, resíduos com características similares são selecionados pelo gerador (que pode ser o cidadão, uma empresa ou outra instituição) e disponibilizados para a coleta separadamente. ";
		return retorno;
	}

}


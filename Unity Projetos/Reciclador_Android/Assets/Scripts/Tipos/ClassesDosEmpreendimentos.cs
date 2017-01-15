using UnityEngine;
using System.Collections;

// Copiar essa classe para cada empreendimento novo, e adicionar ela no Método "Carregar" da classe FuncoesEmpreendimentos
public class EmpreendimentoExemplo
{
	// Alterar o nome do construtor para ser igual ao nome da classe
	/*
	public EmpreendimentoExemplo()
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
	}*/

	string 	nome			= "Empreendimento de Exemplo";
	string 	identificador	= "empreendimentoexemplo";

	int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = nivel * 2 + 3;
		return retorno;
	}

	long		DinheiroPorTempo(int nivel)
	{
		long retorno = nivel * 3 - 3;
		return retorno;
	}

	float	AumentoXP(int nivel)
	{
		float retorno = nivel * nivel * 0.02f;
		return retorno;
	}

	int 		NivelMinimoLixo(int nivel)
	{
		int retorno = nivel / 5;
		return retorno;
	}

	//
	int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		retorno[0] = nivel;			// aumenta o limite da recicladora de papel em 1 por nível
		retorno[1] = nivel * 2;		// aumenta o limite da recicladora de vidro em 2 por nível
		retorno[2] = 0;				// não altera o limite da recicladora de metal
		retorno[3] = 1;				// aumenta em 1, independente do nível, o limite da recicladora de plástico
		return retorno;
	}

	float []	ValorDeVenda(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		retorno[3] = nivel * 0.01f;
		return retorno;
	}

	float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		retorno[3] = nivel * 0.005f;
		return retorno;
	}
	//

	float	VelocidadeAparecerLixo(int nivel)
	{
		float retorno = nivel * 0.1f;
		return retorno;
	}


	int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}

	string 	Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "Aumenta o o poder do jogador em "+TaxaSeparacaoLixo(nivel)+
			"; aumenta o ganho de xp em "+(AumentoXP(nivel) * 100).ToString("0.0")+"%" + // o AumentoXP(nivel) * 100 é para converter o valore em porcentagem, pois está entre 0-1. O .ToString("0.0") é para formatar a saída, para ela mostrar apenas uma casa decimal
			"\n"+"Esse empreendimento faz café, só que não, é apenas um exemplo!";
		return retorno;
	}

	// REQUISITOS
	long		Custos(int nivel)
	{
		long retorno = nivel * nivel * 2 + 1; // nível ao cubo * 10
		return retorno;
	}

	int		NivelRequisito(int nivel)
	{
		int retorno = nivel / 3;
		return retorno;
	}
}

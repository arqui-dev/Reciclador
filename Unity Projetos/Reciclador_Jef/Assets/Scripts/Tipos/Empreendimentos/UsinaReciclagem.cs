using UnityEngine;
using System.Collections;

public class UsinaReciclagem
{
	// Alterar o nome do construtor para ser igual ao nome da classe
	public /**/ UsinaReciclagem /**/()
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

	string 	nome			= "Usina de Reciclagem";
	string 	identificador	= "UsinaReciclagem";

	int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = nivel / 2;
		return retorno;
	}

	int redutorNivelDinheiroTempo = 5;
	long		DinheiroPorTempo(int nivel)
	{
		int v = nivel - redutorNivelDinheiroTempo;
		if (v <= 0) return 0;
		long retorno = (v / 2) + 1;
		return retorno;
	}

	float	AumentoXP(int nivel)
	{
		// 5% de XP por nível
		float retorno = nivel * 0.05f;
		return retorno;
	}

	// Não altera nada
	int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	//
	int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		int div = 4;
		retorno[0] = (nivel + 1) / div;
		retorno[1] = (nivel + 1) / div;
		retorno[2] = (nivel + 1) / div;
		retorno[3] = (nivel + 1) / div;
		return retorno;
	}

	int redutorNivelValorVenda = 3;
	float []	ValorDeVenda(int nivel)
	{
		int nv = nivel - redutorNivelValorVenda;
		float [] retorno = {0f,0f,0f,0f};
		if (nv <= 0) return retorno;

		float porcentagem = 0.05f;
		retorno[0] = nv * porcentagem;
		retorno[1] = nv * porcentagem;
		retorno[2] = nv * porcentagem;
		retorno[3] = nv * porcentagem;

		return retorno;
	}

	float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}
	//

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}

	string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		return retorno;
	}

	// REQUISITOS
	long		Custos(int nivel)
	{
		int nv = nivel + 1;
		long retorno = nv * nv * nv * 1000;
		return retorno;
	}

	int		NivelRequisito(int nivel)
	{
		int retorno = nivel * 5 + 25;
		return retorno;
	}
}


using UnityEngine;
using System.Collections;

public class OficinaBrinquedosReciclaveis
{
	// Alterar o nome do construtor para ser igual ao nome da classe
	public /**/ OficinaBrinquedosReciclaveis /**/()
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

	string 	nome			= "Oficina de Brinquedos Recicláveis";
	string 	identificador	= "OficinaBrinquedosReciclaveis";

	int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = nivel / 4;
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
		if (nivel <= 0) return retorno;
		int div = 10;
		retorno[0] = nivel / div + 1;
		retorno[1] = nivel / div + 1;
		retorno[2] = nivel / div + 1;
		retorno[3] = nivel / div + 1;
		return retorno;
	}

	int redutorNivelValorVenda = 3;
	float []	ValorDeVenda(int nivel)
	{
		int nv = nivel - redutorNivelValorVenda;
		float [] retorno = {0f,0f,0f,0f};
		if (nv <= 0) return retorno;

		float porcentagem = 0.5f;
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
		long retorno = nv * nv * 100; // nível ao quadrado * 10
		return retorno;
	}

	int		NivelRequisito(int nivel)
	{
		int retorno = nivel * 4 + 3;
		return retorno;
	}
}


using UnityEngine;
using System.Collections;

public interface IValoresEmpreendimentos
{
	string		Nome();
	string 		Identificador();
	int			ID();

	int			TaxaSeparacaoLixo(int nivel);
	long		DinheiroPorTempo(int nivel);
	float		AumentoXP(int nivel);
	int 		NivelMinimoLixo(int nivel);


	int []		LimiteRecicladoras(int nivel);
	float []	ValorDeVenda(int nivel);
	float []	VelocidadeReciclagem(int nivel);
	float		VelocidadeAparecerLixo(int nivel);


	int 		SeparacaoAutomatica(int nivel);
	string 		Descricao(int nivel);

	// REQUISITOS
	long		Custos(int nivel);

	int			NivelRequisito(int nivel);
}


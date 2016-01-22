using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjEmpreendimentos : MonoBehaviour
{
	static public ObjEmpreendimentos instancia = null;

	static public int		taxaSeparacaoLixo		= 0;
	static public float 	aumentoXP				= 0;
	static public long 		dinheiroPorTempo		= 0;
	static public int 		nivelMinimoLixo			= 1;
	static public float []	valorDeVenda 			= { 0, 0, 0, 0 };
	static public int []	limiteRecicladoras		= { 0, 0, 0, 0 };
	static public float []	velocidadeReciclagem	= { 0, 0, 0, 0 };
	static public float 	velocidadeCriarLixo		= 0;

	Transform	posicaoMostrarGrana;
	public GameObject	objPontos;

	public float	tempoReceberDinheiro = 5;

	List<Empreendimento> 
		listaEmpreendimentos = new List<Empreendimento>();

	float 	proximoTempoReceberPontos = 0;

	void Awake()
	{
		instancia = this;

		if (posicaoMostrarGrana == null)
		{
			posicaoMostrarGrana = 
				GameObject.Find("pnlMoeda").transform;
		}

		CalcularTudo();
		proximoTempoReceberPontos = 
			Time.time + tempoReceberDinheiro;
	}

	void Update()
	{
		if (dinheiroPorTempo > 0 && 
		    Time.time > proximoTempoReceberPontos)
		{
			ReceberPontos();
			proximoTempoReceberPontos = 
				Time.time + tempoReceberDinheiro;
		}
	}

	void ReceberPontos()
	{
		Jogador.Pontuar(dinheiroPorTempo);

		Instantiate<GameObject>(objPontos).
			GetComponent<ObjTextoFlutuante>().Criar(
				"$"+dinheiroPorTempo, 
				posicaoMostrarGrana.position);
	}

	static public void AdicionarEmpreendimento(Empreendimento e)
	{
		if (!instancia.listaEmpreendimentos.Contains(e))
		{
			instancia.listaEmpreendimentos.Add(e);
		}
		
		Atualizar();
	}

	static public void Atualizar()
	{
		instancia.CalcularTudo();
	}

	void CalcularTudo()
	{
		taxaSeparacaoLixo		= 0;
		aumentoXP				= 0;
		dinheiroPorTempo		= 0;
		nivelMinimoLixo			= 1;
		valorDeVenda 			= new float[4];
		limiteRecicladoras		= new int[4];
		velocidadeReciclagem	= new float[4];
		velocidadeCriarLixo		= 0;

		for (int i = 0; i < 4; i++)
		{
			valorDeVenda[i] 		= 0;
			limiteRecicladoras[i]	= 0;
			velocidadeReciclagem[i]	= 0;
		}
		
		if (listaEmpreendimentos.Count == 0) return;

		foreach(Empreendimento e in listaEmpreendimentos)
		{
			taxaSeparacaoLixo		+= e.taxaSeparacaoLixo;
			aumentoXP				+= e.aumentoXP;
			dinheiroPorTempo		+= e.dinheiroPorTempo;
			nivelMinimoLixo			+= e.nivelMinimoLixo;
			velocidadeCriarLixo		+= e.velocidadeAparecerLixo;
			for (int i = 0; i < 4; i++)
			{
				valorDeVenda[i] 		+= e.valorDeVenda[i];
				limiteRecicladoras[i]	+= e.limiteRecicladoras[i];
				velocidadeReciclagem[i]	+= e.velocidadeReciclagem[i];
			}
		}
	}

	static public float TempoCriarLixo(float tempo)
	{
		if (velocidadeCriarLixo > 0.9f)
		{
			velocidadeCriarLixo = 0.9f;
		}
		return tempo * (1 - velocidadeCriarLixo);
	}

	static public int QuantidadeXPAlterada(int xp)
	{
		float fxp = (float) xp;
		fxp = fxp * (1f + aumentoXP);

		return Mathf.CeilToInt(fxp);
	}

	static public long ValorVendaAjeitado(long valor, int tipo)
	{
		return (long) (valor * (1 + valorDeVenda[tipo]));
	}

	static public float TempoReciclar(float tempo, int tipo)
	{
		return tempo * (1 - velocidadeReciclagem[tipo]);
	}

	static public int LimiteLixeira(int limite, int tipo)
	{
		return limite + limiteRecicladoras[tipo];
	}
}


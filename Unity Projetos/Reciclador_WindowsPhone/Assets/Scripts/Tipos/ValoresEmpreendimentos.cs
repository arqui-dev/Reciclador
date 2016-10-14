using UnityEngine;
using System.Collections;

public class ValoresEmpreendimentos
{
	public delegate int 		DelegateTaxaSeparacaoLixo(int nivel);
	public delegate long 		DelegateDinheiroPorTempo(int nivel);
	public delegate float 		DelegateAumentoXP(int nivel);
	public delegate int 		DelegateNivelMinimoLixo(int nivel);

	public delegate int []		DelegateLimiteRecicladoras(int nivel);
	public delegate float [] 	DelegateValorDeVenda(int nivel);
	public delegate float []	DelegateVelocidadeReciclagem(int nivel);
	public delegate float 		DelegateVelocidadeAparecerLixo(int nivel);

	public delegate int 		DelegateSeparacaoAutomatica(int nivel);
	public delegate string		DelegateDescricao(int nivel);

	public delegate long 		DelegateCustos(int nivel);
	public delegate int 		DelegateNivelRequisito(int nivel);

	DelegateTaxaSeparacaoLixo		delegateTaxaSeparacaoLixo = null;
	DelegateDinheiroPorTempo		delegateDinheiroPorTempo = null;
	DelegateAumentoXP				delegateAumentoXP = null;
	DelegateNivelMinimoLixo			delegateNivelMinimoLixo = null;

	DelegateLimiteRecicladoras		delegateLimiteRecicladoras = null;
	DelegateValorDeVenda			delegateValorDeVenda = null;
	DelegateVelocidadeReciclagem	delegateVelocidadeReciclagem = null;
	DelegateVelocidadeAparecerLixo	delegateVelocidadeAparecerLixo = null;

	DelegateSeparacaoAutomatica		delegateSeparacaoAutomatica = null;
	DelegateDescricao				delegateDescricao = null;

	DelegateCustos					delegateCustos = null;
	DelegateNivelRequisito			delegateNivelRequisito = null;

	public ValoresEmpreendimentos(
		string nome,
		string identificador,
		DelegateTaxaSeparacaoLixo taxaSeparacaoLixo,
		DelegateDinheiroPorTempo dinheiroPorTempo,
		DelegateAumentoXP aumentoXP,
		DelegateNivelMinimoLixo nivelMinimoLixo,
		DelegateLimiteRecicladoras limiteRecicladoras,
		DelegateValorDeVenda valorDeVenda,
		DelegateVelocidadeReciclagem velocidadeReciclagem,
		DelegateVelocidadeAparecerLixo velocidadeAparecerLixo,
		DelegateSeparacaoAutomatica separacaoAutomatica,
		DelegateDescricao descricao,
		DelegateCustos custos,
		DelegateNivelRequisito nivelRequisito )
	{
		this.nome = nome;
		this.identificador = identificador;

		delegateTaxaSeparacaoLixo = taxaSeparacaoLixo;
		delegateDinheiroPorTempo = dinheiroPorTempo;
		delegateAumentoXP = aumentoXP;
		delegateNivelMinimoLixo = nivelMinimoLixo;

		delegateLimiteRecicladoras = limiteRecicladoras;
		delegateValorDeVenda = valorDeVenda;
		delegateVelocidadeReciclagem = velocidadeReciclagem;
		delegateVelocidadeAparecerLixo = velocidadeAparecerLixo;

		delegateSeparacaoAutomatica = separacaoAutomatica;
		delegateDescricao = descricao;

		delegateCustos = custos;
		delegateNivelRequisito = nivelRequisito;
	}

	public string 	nome;
	public string 	identificador;

	public int		TaxaSeparacaoLixo(int nivel)
	{
		if (delegateTaxaSeparacaoLixo == null) return 0;
		return delegateTaxaSeparacaoLixo.Invoke(nivel);
	}
	public long		DinheiroPorTempo(int nivel)
	{
		if (delegateDinheiroPorTempo == null) return 0;
		return delegateDinheiroPorTempo.Invoke(nivel);
	}
	public float	AumentoXP(int nivel)
	{
		if (delegateAumentoXP == null) return 0;
		return delegateAumentoXP.Invoke(nivel);
	}
	public int 		NivelMinimoLixo(int nivel)
	{
		if (delegateNivelMinimoLixo == null) return 0;
		return delegateNivelMinimoLixo.Invoke(nivel);
	}


	public int []	LimiteRecicladoras(int nivel)
	{
		int [] retorno = {0,0,0,0};
		if (delegateLimiteRecicladoras == null) return retorno;
		retorno = delegateLimiteRecicladoras.Invoke(nivel);
		return retorno;
	}
	public float []	ValorDeVenda(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		if (delegateValorDeVenda == null) return retorno;
		retorno = delegateValorDeVenda.Invoke(nivel);
		return retorno;
	}
	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		if (delegateVelocidadeReciclagem == null) return retorno;
		retorno = delegateVelocidadeReciclagem.Invoke(nivel);
		return retorno;
	}
	public float	VelocidadeAparecerLixo(int nivel)
	{
		if (delegateVelocidadeAparecerLixo == null) return 0;
		return delegateVelocidadeAparecerLixo.Invoke(nivel);
	}


	public int 		SeparacaoAutomatica(int nivel)
	{
		if (delegateSeparacaoAutomatica == null) return 0;
		return delegateSeparacaoAutomatica.Invoke(nivel);
	}
	public string 	Descricao(int nivel)
	{
		if (delegateDescricao == null) return "Descrição";
		return delegateDescricao.Invoke(nivel);
	}

	// REQUISITOS
	public long		Custos(int nivel)
	{
		if (delegateCustos == null) return 1;
		return delegateCustos.Invoke(nivel);
	}

	public int		NivelRequisito(int nivel)
	{
		if (delegateNivelRequisito == null) return 0;
		return delegateNivelRequisito.Invoke(nivel);
	}
}


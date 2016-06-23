using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FuncoesEmpreendimentos : MonoBehaviour
{
	static List<ValoresEmpreendimentos> listaValoresEmpreendimento = null;

	public static Empreendimento [] CriarEmpreendimentos()
	{
		// ******************************************************** //
		// Os empreendimentos deverão ser criados na classe ClassesDosEmpreendimentos
		// Para adicionar todos os empreendimentos é só copiar a linha abaixo, e alterar o nome da classe "EmpreendimentoExemplo", para a classe criada.
		new /**/ EmpreendimentoExemplo /**/();


		// ******************************************************** //
		// Essa parte não precisa ser alterada
		List<Empreendimento> listaEmpreendimentos = new List<Empreendimento>();

		foreach(ValoresEmpreendimentos valor in listaValoresEmpreendimento)
		{
			Empreendimento empreendimento = new Empreendimento();
			empreendimento.valores			= valor;
			empreendimento.nome				= valor.nome;
			empreendimento.identificador	= valor.identificador;

			listaEmpreendimentos.Add(empreendimento);
		}

		return listaEmpreendimentos.ToArray();
	}

	public static void AdicionarValoresEmpreendimento(
		string nome,
		string identificador,

		ValoresEmpreendimentos.DelegateTaxaSeparacaoLixo taxaSeparacaoLixo,
		ValoresEmpreendimentos.DelegateDinheiroPorTempo dinheiroPorTempo,
		ValoresEmpreendimentos.DelegateAumentoXP aumentoXP,
		ValoresEmpreendimentos.DelegateNivelMinimoLixo nivelMinimoLixo,

		ValoresEmpreendimentos.DelegateLimiteRecicladoras limiteRecicladoras,
		ValoresEmpreendimentos.DelegateValorDeVenda valorDeVenda,
		ValoresEmpreendimentos.DelegateVelocidadeReciclagem velocidadeReciclagem,
		ValoresEmpreendimentos.DelegateVelocidadeAparecerLixo velocidadeAparecerLixo,

		ValoresEmpreendimentos.DelegateSeparacaoAutomatica separacaoAutomatica,
		ValoresEmpreendimentos.DelegateDescricao descricao,
		ValoresEmpreendimentos.DelegateCustos custos,
		ValoresEmpreendimentos.DelegateNivelRequisito nivelRequisito )
	{
		ValoresEmpreendimentos valoresEmpreendimento = new ValoresEmpreendimentos(
			nome,
			identificador,

			taxaSeparacaoLixo,
			dinheiroPorTempo,
			aumentoXP,
			nivelMinimoLixo,

			limiteRecicladoras,
			valorDeVenda,
			velocidadeReciclagem,
			velocidadeAparecerLixo,

			separacaoAutomatica,
			descricao,
			custos,
			nivelRequisito
		);

		if (listaValoresEmpreendimento == null)
		{
			listaValoresEmpreendimento = new List<ValoresEmpreendimentos>();
		}

		listaValoresEmpreendimento.Add(valoresEmpreendimento);
	}
}



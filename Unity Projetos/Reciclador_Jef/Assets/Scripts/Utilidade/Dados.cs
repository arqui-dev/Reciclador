using UnityEngine;
using System.Collections;

public class Dados
{

	static public bool musicaLigado = true;
	static public bool somLigado = true;

	static public string stringSalvar = "Reciclador";

	static public string MensagemCenarioCheio(int qtdMax)
	{
		return "Limite de lixo no cenário ("+qtdMax+") alcançado";
	}


	static public string MensagemEmpreendimento(
		Empreendimento e, long custo)
	{
		string saida = "Melhorou "+e.nome+" para o nível "+
			e.nivel+", por $"+custo;

		if (e.nivel == 1)
		{
			saida = "Habilitou empreendimento "+e.nome+" por $"+custo;
		}

		return saida;
	}

	static public string textoDescricao_custo = "Custo";
	static public string textoDescricao_requisitos = "Requisitos";
	static public string textoDescricao_sustentabilidade = "Sustentabilidade";
	static public string textoDescricao_empreendimentosNecessarios = "Empreendimentos Necessários";
	static public string textoDescricao_descricao = "Descrição";

	static public string [] idsEmpreendimentoEasterEggs =
	{
		"easteregg_lampada", "easteregg_madeira", "easteregg_isopor", "easteregg_fralda",
		"easteregg_lata_tinta", "easteregg_borracha", "easteregg_seringa", "easteregg_pneu"
	};

	static public int bonusResetXP = 5;
	static public int bonusResetDinheiro = 5;
	static public int bonusResetDano = 2;

	static public int nivelMaximo = 100;

	static public int nivelMinimoEasterEggs = 9;
	static public float chanceEasterEgg = 0.1f;

	static public int [] niveisEasterEggs = {
		9, 12, 23, 36, 49, 65, 84, 99
	};

	static public bool [] easterJaAberto = {
		false, false, false, false,
		false, false, false, false
	};

	// TODO: fazer salvar os easter eggs
}


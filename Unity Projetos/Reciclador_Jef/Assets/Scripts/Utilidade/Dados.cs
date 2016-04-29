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
		"easteregg_lampada", "easteregg_lata_tinta", "easteregg_madeira", "easteregg_fralda", 
		"easteregg_borracha", "easteregg_seringa", "easteregg_pneu", "easteregg_isopor"
	};


	static public int bonusResetXP = 5;
	static public int bonusResetDinheiro = 5;
	static public int bonusResetDano = 2;

	static public int nivelMaximo = 100;

	static public int nivelMinimoEasterEggs = 2;
	static public float chanceEasterEgg = 0.05f;

	static public int [] niveisEasterEggs = {
		1, 2, 3, 4, 5, 6, 7, 8
	};
}


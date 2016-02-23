using UnityEngine;
using System.Collections;

public class Dados
{
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
}


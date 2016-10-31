using UnityEngine;
using System.Collections;

public class ViveiroGarrafasPet : IValoresEmpreendimentos
{
	
	string 	nome			= "Viveiro de Garrafas Pet";
	string 	identificador	= "ViveiroGarrafasPet";
	public string Nome()
	{
		return nome;
	}

	public string Identificador()
	{
		return identificador;
	}

	public int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = nivel / 7;
		return retorno;
	}

	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel - 0;
		if (v <= 0) return 0;
		long retorno = v * 5;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		// 5% de XP por nível
		float retorno = nivel * 0.09f;
		return retorno;
	}

	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		int div = 2;
		retorno[3] = (nivel + 1) / div + 1;
		return retorno;
	}

	int redutorNivelValorVenda = 3;
	public float []	ValorDeVenda(int nivel)
	{
		int nv = nivel - redutorNivelValorVenda;
		float [] retorno = {0f,0f,0f,0f};
		if (nv <= 0) return retorno;

		float porcentagem = 1f;
		retorno[3] = ((nv * (nv + 1)) / 2) * porcentagem;

		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		retorno[3] = nivel * 0.05f;
		return retorno;
	}
	//

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}

	public string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		//retorno += "Custo: "+Custos(nivel)+"\n\n";
		if (TaxaSeparacaoLixo(nivel+1) > 0)
		{
			retorno += "Dano extra:\t\t"+TaxaSeparacaoLixo(nivel)+" -> "+ TaxaSeparacaoLixo(nivel+1)+"\n";
		}
		retorno += "$ por tempo:\t"+DinheiroPorTempo(nivel)+" -> "+ DinheiroPorTempo(nivel+1)+"\n";
		retorno += "XP extra:\t\t\t"+(AumentoXP(nivel)*100f).ToString("0")+"% -> "+(AumentoXP(nivel+1)*100f).ToString("0")+"%\n";
		retorno += "$ reciclagem Plast:\t"+(ValorDeVenda(nivel)[3]*100f).ToString("0")+"% -> "+(ValorDeVenda(nivel+1)[3]*100f).ToString("0")+"%\n";
		retorno += "Limite Recic Plast:\t"+(LimiteRecicladoras(nivel)[3])+" -> "+(LimiteRecicladoras(nivel+1)[3])+"\n";
		retorno += "Vel Reciclagem Pls:\t"+(VelocidadeReciclagem(nivel)[3]*100f).ToString("0")+"% -> "+(VelocidadeReciclagem(nivel+1)[3]*100f).ToString("0")+"%\n";

		return retorno;
	}

	public string DescricaoTexto(int nivel)
	{
		string retorno = "As garrafas pet, antes de serem enviadas para reciclagem, podem ser utilizadas em diversas atividades. Uma prática muito comum é a utilização das garrafas pets para produção de mudas. As garrafas são lavadas e cortadas, deixando apenas a parte inferior para o uso (potes). A parte superior é enviada para reciclagem. São inseridos terra e adubo nos potes e em seguida as sementes, que em alguns meses estarão prontas para plantio.";
		return retorno;
	}

	// REQUISITOS
	public long		Custos(int nivel)
	{
		int nv = nivel + 1;
		long retorno = nv * nv * 50; // nível ao quadrado * 10
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		int retorno = nivel * 4 + 12;
		return retorno;
	}
}


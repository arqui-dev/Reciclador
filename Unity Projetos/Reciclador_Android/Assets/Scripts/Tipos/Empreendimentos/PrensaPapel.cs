using UnityEngine;
using System.Collections;

public class PrensaPapel : IValoresEmpreendimentos
{
	public int ID()
	{
		return -1;
	}

	string 	nome			= "Prensa de Papel";
	string 	identificador	= "PrensaPapel";
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
		int v = nivel;
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
		retorno[0] = (nivel + 1) / div + 1;
		return retorno;
	}


	public float []	ValorDeVenda(int nivel)
	{
		int nv = nivel;
		float [] retorno = {0f,0f,0f,0f};
		if (nv <= 0) return retorno;

		float porcentagem = 1f;
		retorno[0] = ((nv * (nv + 1)) / 2) * porcentagem;

		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		retorno[0] = nivel * 0.05f;
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
		retorno += "$ reciclagem Papel:\t"+(ValorDeVenda(nivel)[0]*100f).ToString("0")+"% -> "+(ValorDeVenda(nivel+1)[0]*100f).ToString("0")+"%\n";
		retorno += "Limite Recic Papel:\t"+(LimiteRecicladoras(nivel)[0])+" -> "+(LimiteRecicladoras(nivel+1)[0])+"\n";
		retorno += "Vel Reciclagem Ppl:\t"+(VelocidadeReciclagem(nivel)[0]*100f).ToString("0")+"% -> "+(VelocidadeReciclagem(nivel+1)[0]*100f).ToString("0")+"%\n";

		return retorno;
	}

	public string DescricaoTexto(int nivel)
	{
		string retorno = "O papel é enfardado em prensas e depois encaminhado aos aparistas, que classificam as aparas e revendem para as fábricas de papel como matéria-prima.";
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
		int retorno = nivel * 4 + 9;
		return retorno;
	}
}


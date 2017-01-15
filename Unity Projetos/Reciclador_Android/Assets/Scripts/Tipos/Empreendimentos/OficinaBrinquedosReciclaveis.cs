using UnityEngine;
using System.Collections;

public class OficinaBrinquedosReciclaveis : IValoresEmpreendimentos
{
	
	public int ID()
	{
		return -1;
	}
	string 	nome			= "Oficina de Brinquedos Recicláveis";
	string 	identificador	= "OficinaBrinquedosReciclaveis";
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
		int retorno = nivel / 3;
		return retorno;
	}
		
	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno = ((v * (v + 1)) / 2) * 15;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		// 5% de XP por nível
		float retorno = nivel * 0.5f;
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
		if (nivel <= 0) return retorno;
		int div = 10;
		retorno[0] = nivel / div + 1;
		retorno[1] = nivel / div + 1;
		retorno[2] = nivel / div + 1;
		retorno[3] = nivel / div + 1;
		return retorno;
	}

	public float []	ValorDeVenda(int nivel)
	{
		int nv = nivel;
		float [] retorno = {0f,0f,0f,0f};
		if (nv <= 0) return retorno;

		float porcentagem = 0.5f;
		nv = ((nv * (nv + 1)) / 2);
		retorno[0] = nv * porcentagem;
		retorno[1] = nv * porcentagem;
		retorno[2] = nv * porcentagem;
		retorno[3] = nv * porcentagem;

		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
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
		retorno += "$ reciclagem:\t"+(ValorDeVenda(nivel)[0]*100f).ToString("0")+"% -> "+(ValorDeVenda(nivel+1)[0]*100f).ToString("0")+"%\n";
		retorno += "Limite Recic:\t"+(LimiteRecicladoras(nivel)[0])+" -> "+(LimiteRecicladoras(nivel+1)[0]);

		return retorno;
	}

	public string DescricaoTexto(int nivel)
	{
		string retorno = "Além de ensinar como organizar atividades que ajudem na preservação da natureza, usando materiais recicláveis as oficinas colaboram para a formação de crianças conscientes e no desenvolvimento do potencial artístico.";
		return retorno;
	}

	// REQUISITOS
	public long		Custos(int nivel)
	{
		int nv = nivel + 1;
		long retorno = nv * nv * 100; // nível ao quadrado * 10
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		int retorno = nivel * 4 + 3;
		return retorno;
	}
}


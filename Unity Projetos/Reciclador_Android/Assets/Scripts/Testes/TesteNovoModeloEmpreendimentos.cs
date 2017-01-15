using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TesteNovoModeloEmpreendimentos : MonoBehaviour
{
	static public Empreendimento [] lista = null;
	public Text txtNome;
	public Text txtID;
	public Text txtNv;
	public Text txtCusto;
	public Text txtReq;
	public Text txtPoder;
	public Text txtDinTempo;
	public Text txtXP;
	public Text txtNivellixo;
	public Text txtDanoTempo;
	public Text txtVelLixo;
	public Text txtLimRec;
	public Text txtValorVenda;
	public Text txtVelRec;
	public Text txtDescri;

	public Slider slEmpr;
	public Slider slNv;

	// Use this for initialization
	void Start ()
	{
		lista			= FuncoesEmpreendimentos.CriarEmpreendimentos();
		slEmpr.minValue = 0;
		slEmpr.maxValue = lista.Length - 1;
		slEmpr.value	= 0;

		AtualizarEmpreendimento();
	}

	public void TrocarEmpreendimento()
	{
		AtualizarEmpreendimento();
	}

	public void TrocarNivel()
	{
		AtualizarEmpreendimento();
	}

	void AtualizarEmpreendimento()
	{
		int ind  = (int) slEmpr.value;

		if (lista.Length <= slEmpr.value) return;

		lista[ind].AlterarNivel((int) slNv.value);

		txtNome.text 		= "Nome: "+lista[ind].nome;
		txtID.text 			= "ID: "+lista[ind].identificador;
		txtNv.text 			= "Nível: "+lista[ind].nivel;
		txtCusto.text 		= "Custo: "+lista[ind].custo;
		txtReq.text 		= "Requisito: "+lista[ind].nivelRequisito;
		txtPoder.text 		= "Poder Jogador: "+lista[ind].taxaSeparacaoLixo;
		txtDinTempo.text 	= "Dinheiro por Tempo: "+lista[ind].dinheiroPorTempo;
		txtXP.text 			= "Aumento XP: "+lista[ind].aumentoXP.ToString("0.00");
		txtNivellixo.text 	= "Nivel extra Lixo: "+lista[ind].nivelMinimoLixo;
		txtDanoTempo.text 	= "Dano por tempo: "+lista[ind].separacaoAutomatica;
		txtVelLixo.text		= "Velocidade aparecer Lixo: "+lista[ind].velocidadeAparecerLixo.ToString("0.00");
		txtLimRec.text 		= 
			"Papel["+lista[ind].limiteRecicladoras[0]+"], "+
			"Vidro["+lista[ind].limiteRecicladoras[1]+"], "+
			"Metal["+lista[ind].limiteRecicladoras[2]+"], "+
			"Plástico["+lista[ind].limiteRecicladoras[3]+"]";
		txtValorVenda.text 	= 
			"Papel["+lista[ind].valorDeVenda[0].ToString("0.00")+"], "+
			"Vidro["+lista[ind].valorDeVenda[1].ToString("0.00")+"], "+
			"Metal["+lista[ind].valorDeVenda[2].ToString("0.00")+"], "+
			"Plástico["+lista[ind].valorDeVenda[3].ToString("0.00")+"]";
		txtVelRec.text 		= 
			"Papel["+lista[ind].velocidadeReciclagem[0].ToString("0.00")+"], "+
			"Vidro["+lista[ind].velocidadeReciclagem[1].ToString("0.00")+"], "+
			"Metal["+lista[ind].velocidadeReciclagem[2].ToString("0.00")+"], "+
			"Plástico["+lista[ind].velocidadeReciclagem[3].ToString("0.00")+"]";
		txtDescri.text 		= "Descrição: '"+lista[ind].descricao+"'";
	}
}


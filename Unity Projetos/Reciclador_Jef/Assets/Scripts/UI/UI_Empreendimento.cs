using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI_Empreendimento : MonoBehaviour
{
	static Text 	txtDescricao	= null;
	static Button	btComprar		= null;
	static Text 	txtComprar		= null;
	
	static UI_Empreendimento	selecionado		= null;
	static Transform	posicaoLocalDinheiro	= null;


	public GameObject objGastar;

	Empreendimento	empreendimento;
	public int indiceEmpreendimento = 0;

	Text	textoLocal;

	void Start()
	{
		if (txtDescricao == null)
		{
			txtDescricao = GameObject.
				Find("_txtDescricaoEmpreendimentos").
					GetComponent<Text>();
		}
		if (btComprar == null)
		{
			btComprar = GameObject.
				Find("_btComprarEmpreendimento").
					GetComponent<Button>();
			txtComprar = btComprar.
				GetComponentInChildren<Text>();
		}
		if (posicaoLocalDinheiro == null)
		{
			posicaoLocalDinheiro = 
				GameObject.Find("pnlMoeda").transform;
		}

		empreendimento = GerenciadorEmpreendimentos
			.PegarEmpreendimento(indiceEmpreendimento);

		empreendimento.Reiniciar();

		textoLocal = GetComponentInChildren<Text>();
		AjeitarTexto();
		AjeitarBotaoComprar();
	}

	void Update()
	{
		VerificarBotaoHabilitado();
	}

	void AjeitarTexto()
	{
		if (empreendimento.nivelRequisito < 0)
		{
			textoLocal.text = empreendimento.nome+
				"\nLv "+empreendimento.nivel+"  MAX";
		}
		else
		{
			textoLocal.text = empreendimento.nome + 
				"   Lv "+empreendimento.nivel+
				"\n    Lvl min Jog "+empreendimento.nivelRequisito +
				"   Custo: "+empreendimento.custo;
		}
	}

	public void Selecionar()
	{
		selecionado = this;

		txtDescricao.text = empreendimento.descricao;
		AjeitarBotaoComprar();
	}

	public void Comprar()
	{
		//Debug.Log ("Clicou!");
		selecionado.SelecionadoComprar();
	}

	void SelecionadoComprar()
	{
		long	custo		= empreendimento.custo;
		bool	comprou		= Jogador.Gastar(custo);

		if (comprou)
		{
			Instantiate<GameObject>(objGastar).
				GetComponent<ObjTextoFlutuante>().Criar(
					"-$"+custo, 
					posicaoLocalDinheiro.position);

			empreendimento.SubirDeNivel();
			ObjEmpreendimentos.AdicionarEmpreendimento(
				empreendimento);

			Debug.Log (Dados.MensagemEmpreendimento(
				empreendimento, custo));
			
			UI_Mensanges.AdicionarMensagem(
				Dados.MensagemEmpreendimento(
				empreendimento, custo));
		}

		AjeitarBotaoComprar();
	}

	void VerificarBotaoHabilitado()
	{
		if (selecionado == this)
		{
			if (empreendimento.custo <= Jogador.pontos &&
			    empreendimento.custo > 0 &&
			    empreendimento.nivelRequisito > 0 &&
			    empreendimento.nivelRequisito <= Jogador.nivel)
			{
				btComprar.interactable = true;
			}
			else
			{
				btComprar.interactable = false;
			}
		}

		if (selecionado == null)
		{
			Desselecionar();
		}
	}

	void AjeitarBotaoComprar()
	{
		if (empreendimento.nivel == 0)
		{
			VerificarBotaoHabilitado();
			txtComprar.text = "Habilitar";
		}
		else if (empreendimento.nivel < empreendimento.nivelMaximo)
		{
			VerificarBotaoHabilitado();
			txtComprar.text = "Melhorar";
		}
		else
		{
			btComprar.interactable = false;
			txtComprar.text = "";
		}

		AjeitarTexto();
	}

	static public void Desselecionar()
	{
		selecionado		= null;
		if (btComprar != null) 
			btComprar.interactable = false;
		if (txtComprar != null) 
			txtComprar.text = "";
		if (txtDescricao != null)
			txtDescricao.text = "";
	}
}


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

	public Empreendimento empreendimento;

	static Scrollbar scrollBar = null;

	Text	textoLocal;
	int		ajeitarScrollBar = 0;

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
		if (scrollBar == null)
		{
			scrollBar = GameObject.Find("BarraDescricao").GetComponent<Scrollbar>();
		}

		textoLocal = GetComponentInChildren<Text>();
		AjeitarTexto();
		AjeitarBotaoComprar();
	}

	void Update()
	{
		VerificarBotaoHabilitado();

		if (ajeitarScrollBar > 0)
		{
			scrollBar.value = 1;
			ajeitarScrollBar--;
		}
	}

	void AjeitarTexto()
	{
		/*
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
		*/
		if (empreendimento.nivelRequisito < 0)
		{
			textoLocal.text = empreendimento.nome+
				"\nLv "+empreendimento.nivel+"  MAX";
		}
		else
		{
			textoLocal.text = empreendimento.nome + 
				"\nLv "+empreendimento.nivel;
		}
	}

	public void Selecionar()
	{
		selecionado = this;

		AjeitarDescricao();
		AjeitarBotaoComprar();

		Som.Tocar(Som.Tipo.Navegar);
	}

	void AjeitarDescricao()
	{
		string descricao = "";

		if (empreendimento.nivelMaximo > empreendimento.nivel)
		{
			descricao += Dados.textoDescricao_custo + ": " + empreendimento.custo + "\n";

			//descricao += Dados.textoDescricao_requisitos + ":\n";
			descricao += Dados.textoDescricao_sustentabilidade + ": " +
				empreendimento.nivelRequisito + "\n";

			if (empreendimento._empreendimentosRequisitos[empreendimento.nivel+1].Count > 0)
			{
				descricao += Dados.textoDescricao_empreendimentosNecessarios + ":\n";
				foreach(string empreendimentoNecessario in empreendimento.
				        _empreendimentosRequisitos[empreendimento.nivel + 1].Keys)
				{
					descricao += "  " + GerenciadorEmpreendimentos.dicionarioEmpreendimentos
						[empreendimentoNecessario].nome + ": " + 
							empreendimento._empreendimentosRequisitos[empreendimento.nivel + 1]
							[empreendimentoNecessario] + "\n";
				}
				//descricao += "\n";
			}
			descricao += "\n";
		}
		descricao += Dados.textoDescricao_descricao + ":\n" + empreendimento.descricao;

		txtDescricao.text = descricao;

		ajeitarScrollBar = 10;
	}

	public void Comprar()
	{
		//Debug.Log ("Clicou!");
		selecionado.SelecionadoComprar();
		Som.Tocar(Som.Tipo.Comprar);
	}

	public static void ComprarEstatico()
	{
		selecionado.SelecionadoComprar();
		Som.Tocar(Som.Tipo.Comprar);
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
		AjeitarDescricao();
	}

	void VerificarBotaoHabilitado()
	{
		if (selecionado == this)
		{
			if (empreendimento.PodeComprar())
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


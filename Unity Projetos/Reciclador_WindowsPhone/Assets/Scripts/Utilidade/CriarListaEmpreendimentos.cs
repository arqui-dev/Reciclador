using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Cria os botões dos empreendimentos no popup de empreendimentos.
/// </summary>
public class CriarListaEmpreendimentos : MonoBehaviour
{
	static CriarListaEmpreendimentos instancia = null;

	/// <summary>	/// Prefab com o botão base de empreendimento.	/// </summary>
	public GameObject botaoEmpreendimento;

	/// <summary>
	/// O local onde serão colocados os botões de empreendimentos.	/// </summary>
	public RectTransform localDosBotoesDeEmpreendimento;

	/// <summary>	/// O espaço vertical, em pixels da resolução base (1080p), entre os botões.	/// </summary>
	public float espacoEntreBotoes = 10;

	/// <summary>	/// O tamanho vertical do botão, em pixels da resolução base.	/// </summary>
	public float tamanhoBotao = 90;

	//public Text textoDEBUG;

	/// <summary>	/// Controla o carregamento, para mostrar apenas quando os empreendimentos forem carregados corretamente.	/// </summary>
	bool pronto = false;

	void Start()
	{
		//textoDEBUG.text = "TESTE";
		if (instancia == null)
		{
			instancia = this;
		}
	}

	/// <summary>
	/// Verifica se os empreendimentos já foram carregados e criados.
	/// </summary>
	void Update()
	{
		if (!pronto && GerenciadorEmpreendimentos.carregado)
		{
			//textoDEBUG.text = "Tentou carregar";
			Carregar();
			pronto = true;
			//textoDEBUG.text = "Carregou";
		}
		//textoDEBUG.text = "pronto "+pronto+"; carregado "+GerenciadorEmpreendimentos.carregado;
	}

	void OnDisable()
	{
		pronto = false;
		//textoDEBUG.text = "Desabilitou";
	}

	//*
	void OnEnable()
	{
		if (GerenciadorEmpreendimentos.carregado == false)
		{
			GerenciadorEmpreendimentos.Recarregar();
			//textoDEBUG.text = "Carregou base";
		}
		Carregar();
		//textoDEBUG.text = "Carregou";
		pronto = true;
	}
	//*/

	public static void CarregarEstatico()
	{
		if (instancia)
		{
			instancia.Carregar();
			//instancia.textoDEBUG.text = "Carregou";
		}
	}

	/// <summary>
	/// Cria os botões dos empreendimentos no local adequado.
	/// </summary>
	void Carregar()
	{
		float y = -espacoEntreBotoes;

		for (int i = 0; i < transform.childCount; i++)
		{
			Destroy(transform.GetChild(i).gameObject);
		}

		int foramColocados = 0;
		int foramCancelados = 0;

		/*foreach (Empreendimento e in 
			GerenciadorEmpreendimentos.listaEmpreendimentosEstatica)*/
		foreach (Empreendimento e in 
		         GerenciadorEmpreendimentos.
		         dicionarioEmpreendimentos.Values)
		{
			//Debug.Log("Criar lista de empreendimentos; Empreendimento: "+e.nome+"; Nivel mínimo: "+e.NivelMinimo()+"; Nível atual: "+e.nivel);
			if (e.NivelMinimo(0) > Jogador.nivel)
			{
				foramCancelados++;
				//Debug.Log("Nível do "+e.nome+": "+e.nivel+"; Nivel do jogador: "+Jogador.nivel+"; Nivel mínimo: "+e.NivelMinimo(0));
				continue;
			}
			foramColocados++;
	
			GameObject novoBotao = 
				Instantiate<GameObject>(botaoEmpreendimento);
	
			RectTransform rectTransformNovoBotao = 
				novoBotao.GetComponent<RectTransform>();
	
			UI_Empreendimento UI_EmpreendimentoNovoBotao = 
				novoBotao.GetComponent<UI_Empreendimento>();
	
			rectTransformNovoBotao.position = new Vector2(0, y);
			rectTransformNovoBotao.SetParent(
				localDosBotoesDeEmpreendimento, false);
	
			UI_EmpreendimentoNovoBotao.empreendimento = e;
	
			y-= tamanhoBotao + espacoEntreBotoes;
		}
	
		//textoDEBUG.text += "\nFCO: "+foramColocados + "; FCA: " + foramCancelados;

		localDosBotoesDeEmpreendimento.sizeDelta = 
			new Vector2(localDosBotoesDeEmpreendimento.sizeDelta.x, -y);
	}
}


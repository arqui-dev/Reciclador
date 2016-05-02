using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ObjAreaReciclavel : MonoBehaviour
{
	public GameObject 	objPontuacao;

	public Image		imgBarraCarregamento;
	public Text			txtLimiteListaReciclagem;

	public Reciclavel.Tipo tipo = Reciclavel.Tipo.Papel;

	public float	duracaoReciclagem		= 5;
	public int		tamanhoListaReciclagem	= 5;

	public long		pontuacaoBasica			= 5;

	public int 		xpAoMandarReciclar		= 2;

	public static int numMateriaisReciclados = 0;

	[HideInInspector]
	public Vector2 area;
	
	RectTransform areaLixeira;

	List<ObjReciclavel> listaReciclando = new List<ObjReciclavel>();

	float proximoTempoReciclagem = 0;
	float ultimaDuracao = 0;



	public void Salvar()
	{
		PlayerPrefs.SetInt(gameObject.name, listaReciclando.Count);
	}

	public void Carregar()
	{
		if (PlayerPrefs.HasKey(gameObject.name))
		{
			int qtd = PlayerPrefs.GetInt(gameObject.name);
			for (int i = 0; i < qtd; i++)
			{
				listaReciclando.Add(new ObjReciclavel());
			}

			proximoTempoReciclagem = Time.time + DuracaoReciclagemAtual();
		}
	}

	void Awake()
	{
		if (areaLixeira == null)
		{
			areaLixeira = transform.FindChild("_Area").
				GetComponent<RectTransform>();
		}

		area = areaLixeira.sizeDelta;
		ultimaDuracao = duracaoReciclagem;

		switch(tipo){
		case Reciclavel.Tipo.Papel: 	Jogador.recicladoraPapel = this; break;
		case Reciclavel.Tipo.Vidro: 	Jogador.recicladoraVidro = this; break;
		case Reciclavel.Tipo.Metal: 	Jogador.recicladoraMetal = this; break;
		case Reciclavel.Tipo.Plastico: 	Jogador.recicladoraPlastico = this; break;
		}
	}

	void Update()
	{
		VerificarReciclando();
	}

	void VerificarReciclando()
	{
		imgBarraCarregamento.fillAmount = 0;
		if (listaReciclando.Count > 0)
		{
			if (Time.time > proximoTempoReciclagem)
			{
				Pronto();
				if (listaReciclando.Count > 0)
				{
					proximoTempoReciclagem = 
						Time.time + DuracaoReciclagemAtual();
				}
			}
			else
			{
				imgBarraCarregamento.fillAmount = 
					(proximoTempoReciclagem - Time.time) / 
						ultimaDuracao;
			}
		}
		txtLimiteListaReciclagem.text = "" +
			listaReciclando.Count + "/" + TamanhoLista();
	}

	float DuracaoReciclagemAtual()
	{
		ultimaDuracao = ObjEmpreendimentos.
			TempoReciclar(duracaoReciclagem, (int) tipo);

		return ultimaDuracao;
	}

	void Pronto()
	{
		long pontos = 
			ObjEmpreendimentos.
				ValorVendaAjeitado(pontuacaoBasica, (int) tipo);

		Jogador.Pontuar(pontos);

		Som.Tocar(Som.Tipo.CompletarReciclagem);

		Instantiate<GameObject>(objPontuacao).
			GetComponent<ObjTextoFlutuante>().Criar(
				"$"+pontos, transform.position);

		listaReciclando.RemoveAt(0);
	}

	int TamanhoLista()
	{
		return ObjEmpreendimentos.LimiteLixeira(
			tamanhoListaReciclagem, (int)tipo);
	}

	public bool Reciclar(ObjReciclavel reciclavel)
	{
		if (listaReciclando.Count >= TamanhoLista())
		{
			return false;
		}

		reciclavel.Reciclar(transform, ultimaDuracao);
		listaReciclando.Add(reciclavel);

		ObjGerenciadorLixo.CriarXP(
			xpAoMandarReciclar, reciclavel.transform);

		if (listaReciclando.Count == 1)
		{
			proximoTempoReciclagem = Time.time + DuracaoReciclagemAtual();
		}

		numMateriaisReciclados++;
		return true;
	}

	// TODO: JEF
	public void Limpar()
	{
		foreach(ObjReciclavel reci in listaReciclando)
		{
			Destroy(reci.gameObject);
		}
		listaReciclando.Clear();
	}
}


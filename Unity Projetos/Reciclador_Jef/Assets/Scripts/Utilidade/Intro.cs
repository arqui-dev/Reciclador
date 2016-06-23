using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Intro : MonoBehaviour
{
	public GameObject [] logos;
	public GameObject txtTocar;

	public Text textoPorcentagem;

	public float tempoMostrarCadaLogo = 3;

	float proximoTempo = 0;
	int itemAtual = 0;

	bool podeRodar = false;

	bool podeCarregar = false;

	void Awake()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!podeCarregar)
		{
			if(!podeRodar)
			{
				if (Input.GetMouseButton(0))
				{
					txtTocar.SetActive(false);
					podeRodar = true;
					logos[0].SetActive(true);
					proximoTempo = Time.time + tempoMostrarCadaLogo;
				}
			}

			if (podeRodar && Time.time > proximoTempo && itemAtual < logos.Length)
			{
				proximoTempo = Time.time + tempoMostrarCadaLogo;

				logos[itemAtual].SetActive(false);
				itemAtual++;

				if (itemAtual < logos.Length)
					logos[itemAtual].SetActive(true);

				if (itemAtual == logos.Length - 1)
				{
					logos[logos.Length - 1].SetActive(true);
					proximoTempo = 0;
					Application.LoadLevel("Menu");
					//podeCarregar = true;
					//proximoTempo = Time.time + tempoPassos;
					//tempoEsperar = Time.time + tempoPassos * (maxPassosPorcentagem + 1);
				}
			}
		}
		/*
		else
		{
			string texto = "";
			for (int i = 0; i < passo; i++)
			{
				texto += ".";
			}
			if (Time.time > proximoTempo)
			{
				passo++;
				proximoTempo = Time.time + tempoPassos;
				if (passo > maxPassosPorcentagem)
					passo = 0;
			}

			textoPorcentagem.text = texto;

			if (CarregamentoAssincrono.pronto) // && Time.time > tempoEsperar)
			{
				Application.LoadLevel("Menu");
			}
		}
		//*/

		Jogador.VerificarBotaoBack();
	}

	int passo = 0;
	public int maxPassosPorcentagem = 3;
	public float tempoPassos = 0.5f;
	float tempoEsperar = 0;
}


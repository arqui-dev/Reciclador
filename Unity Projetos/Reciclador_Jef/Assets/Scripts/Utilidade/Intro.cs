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
	float proximoTempoClicar = 0;
	public float tempoClicar = 1.2f;

	void Awake()
	{
		
	}

	// TODO: criar um efeito de fade
	// Update is called once per frame
	void Update ()
	{
		if (!podeCarregar)
		{
			if(!podeRodar)
			{
				if (Input.GetMouseButton(0))
				{
					//txtTocar.SetActive(false);
					podeRodar = true;
					//logos[0].SetActive(true);
					foreach(Animator animator in logos[0].GetComponentsInChildren<Animator>())
					{
						animator.SetBool("fade", true);
					}
					proximoTempo = Time.time + tempoMostrarCadaLogo;
					proximoTempoClicar = Time.time + tempoClicar;
				}
			}

			if (podeRodar && itemAtual < logos.Length)
			{
				if ((Time.time > proximoTempo) || (Time.time > proximoTempoClicar && Input.GetMouseButton(0)))
				{
					proximoTempo = Time.time + tempoMostrarCadaLogo;
					proximoTempoClicar = Time.time + tempoClicar;

					//logos[itemAtual].SetActive(false);
					//logos[itemAtual].GetComponent<Animator>().SetBool("fade",true);
					foreach(Animator animator in logos[itemAtual].GetComponentsInChildren<Animator>())
					{
						animator.SetBool("fade", true);
					}
					itemAtual++;

					/*
					if (itemAtual < logos.Length)
					{
						//logos[itemAtual].SetActive(true);
						logos[itemAtual].GetComponent<Animator>().SetBool("fade",true);
						foreach(Animator animator in logos[itemAtual].GetComponentsInChildren<Animator>())
						{
							animator.SetBool("fade", false);
						}
					}//*/

					if (itemAtual == logos.Length)
					{
						//logos[logos.Length - 1].SetActive(true);
						proximoTempo = 0;
						Application.LoadLevel("Menu");
					}
				}
			}
		}


		Jogador.VerificarBotaoBack();
	}

	int passo = 0;
	public int maxPassosPorcentagem = 3;
	public float tempoPassos = 0.5f;
	float tempoEsperar = 0;
}


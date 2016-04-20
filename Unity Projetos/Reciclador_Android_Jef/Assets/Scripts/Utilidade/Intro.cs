using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour
{
	public GameObject [] logos;

	public float tempoMostrarCadaLogo = 3;

	float proximoTempo = 0;
	int itemAtual = 0;

	void Awake()
	{
		logos[0].SetActive(true);

		proximoTempo = Time.time + tempoMostrarCadaLogo;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.time > proximoTempo)
		{
			proximoTempo = Time.time + tempoMostrarCadaLogo;

			logos[itemAtual].SetActive(false);
			itemAtual++;

			if (itemAtual >= logos.Length)
			{
				logos[logos.Length - 1].SetActive(true);
				proximoTempo = 0;
				Application.LoadLevel("Menu");
			}

			if (itemAtual < logos.Length)
				logos[itemAtual].SetActive(true);
		}
	}
}


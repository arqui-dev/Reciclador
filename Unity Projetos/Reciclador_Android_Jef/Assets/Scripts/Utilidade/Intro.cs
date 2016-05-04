using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour
{
	public GameObject [] logos;
	public GameObject txtTocar;

	public float tempoMostrarCadaLogo = 3;

	float proximoTempo = 0;
	int itemAtual = 0;

	bool podeRodar = false;

	void Awake()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
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
			}


		}
	}
}


using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUD_Pontos : MonoBehaviour
{
	Text texto;

	void Awake()
	{
		texto = GetComponent<Text>();
		texto.text = PegarTextoPontos();
	}

	void Update ()
	{
		texto.text = PegarTextoPontos();
	}

	static string PegarTextoPontos()
	{
		return "$"+Jogador.pontos;
	}
}


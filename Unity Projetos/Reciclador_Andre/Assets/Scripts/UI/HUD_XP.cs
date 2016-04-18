using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUD_XP : MonoBehaviour
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
		return "Lv "+Jogador.nivel;
	}
}


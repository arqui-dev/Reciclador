using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUD_XP : MonoBehaviour
{
	public string _txtSustentabilidade = "";
	Text texto;
	static string txtSustentabilidade = "";
	
	void Awake()
	{
		texto = GetComponent<Text>();
		texto.text = PegarTextoPontos();
		txtSustentabilidade = _txtSustentabilidade;
	}
	
	void Update ()
	{
		texto.text = PegarTextoPontos();
	}
	
	static string PegarTextoPontos()
	{
		return txtSustentabilidade + Jogador.nivel;
	}
}


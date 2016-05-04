using UnityEngine;
using System.Collections;

public class UI_Menu : MonoBehaviour
{
	public GameObject menuConfig;


	public void Jogar()
	{
		Som.Tocar(Som.Tipo.Navegar);
		if (Jogador.tutorialCompleto == true)
		{
			Application.LoadLevel("Jogo");
		}
		else
		{
			Application.LoadLevel("Tutorial");
		}
	}

	public void Config()
	{
		menuConfig.SetActive(true);
		Som.Tocar(Som.Tipo.Navegar);
	}
}


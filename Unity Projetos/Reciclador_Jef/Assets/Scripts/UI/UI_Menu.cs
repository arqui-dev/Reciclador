using UnityEngine;
using System.Collections;

public class UI_Menu : MonoBehaviour
{
	public GameObject menuConfig;


	public void Jogar()
	{
		Som.Tocar(Som.Tipo.Navegar);
		Application.LoadLevel("Jogo");
	}

	public void Config()
	{
		menuConfig.SetActive(true);
		Som.Tocar(Som.Tipo.Navegar);
	}
}


using UnityEngine;
using System.Collections;

public class PopupAchievements : MonoBehaviour
{
	void Awake()
	{
		//Fechar();
	}

	public void Fechar()
	{
		gameObject.SetActive(false);
		//UI_Achievements.Desselecionar();
	}

	public void Abrir()
	{
		if (gameObject.activeSelf)
		{
			gameObject.SetActive(false);
		}
		else
		{
			gameObject.SetActive(true);
		}
	}
}


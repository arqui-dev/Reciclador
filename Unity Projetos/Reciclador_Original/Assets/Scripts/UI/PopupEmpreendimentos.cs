using UnityEngine;
using System.Collections;

public class PopupEmpreendimentos : MonoBehaviour
{
	void Awake()
	{
		//Fechar();
	}

	public void Fechar()
	{
		gameObject.SetActive(false);
		UI_Empreendimento.Desselecionar();
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


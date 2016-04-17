using UnityEngine;
using System.Collections;

public class PopupConquistas : MonoBehaviour
{
	public PopupEmpreendimentos painelEmpreendimentos;
	public PopupConfiguracoes painelConfiguracoes;

	public void Fechar()
	{
		gameObject.SetActive(false);
	}
	
	public void Abrir()
	{
		painelConfiguracoes.Fechar();
		painelEmpreendimentos.Fechar();

		if (gameObject.activeSelf)
		{
			Fechar();
		}
		else
		{
			gameObject.SetActive(true);
		}


	}
}


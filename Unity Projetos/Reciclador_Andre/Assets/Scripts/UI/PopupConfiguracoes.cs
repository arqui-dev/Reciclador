using UnityEngine;
using System.Collections;

public class PopupConfiguracoes : MonoBehaviour
{
	public PopupEmpreendimentos painelEmpreendimentos;
	public PopupConquistas painelConquistas;
	
	public void Fechar()
	{
		gameObject.SetActive(false);
	}
	
	public void Abrir()
	{
		if (painelConquistas)
			painelConquistas.Fechar();

		if (painelEmpreendimentos)
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


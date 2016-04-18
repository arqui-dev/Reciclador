using UnityEngine;
using System.Collections;

public class PopupEmpreendimentos : MonoBehaviour
{
	public PopupConquistas painelConquistas;
	public PopupConfiguracoes painelConfiguracoes;
	
	public void Fechar()
	{
		gameObject.SetActive(false);
		UI_Empreendimento.Desselecionar();
	}
	
	public void Abrir()
	{
		painelConfiguracoes.Fechar();
		painelConquistas.Fechar();

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


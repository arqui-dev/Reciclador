using UnityEngine;
using System.Collections;

public class PopupConquistas : MonoBehaviour
{
	static public PopupConquistas instancia = null;

	public PopupEmpreendimentos painelEmpreendimentos;
	public PopupConfiguracoes painelConfiguracoes;

	public void Fechar(bool fechadoPorAbrirOutra = false)
	{
		if (fechadoPorAbrirOutra == false)
			Som.Tocar(Som.Tipo.Cancelar);

		gameObject.SetActive(false);
	}
	
	public void Abrir()
	{
		painelConfiguracoes.Fechar(true);
		painelEmpreendimentos.Fechar(true);

		if (gameObject.activeSelf)
		{
			Fechar();
		}
		else
		{
			gameObject.SetActive(true);
			Som.Tocar(Som.Tipo.Navegar);
		}
	}

	void Awake()
	{
		instancia = this;
		//gameObject.SetActive(false);
	}
}


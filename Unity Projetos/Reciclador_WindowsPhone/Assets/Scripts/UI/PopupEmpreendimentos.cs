using UnityEngine;
using System.Collections;

public class PopupEmpreendimentos : MonoBehaviour
{
	public static PopupEmpreendimentos instancia = null;

	public PopupConquistas painelConquistas;
	public PopupConfiguracoes painelConfiguracoes;

	void Awake()
	{
		instancia = this;
		gameObject.SetActive(false);
	}
	
	public void Fechar(bool fechadoPorAbrirOutra = false)
	{
		if (fechadoPorAbrirOutra == false)
			Som.Tocar(Som.Tipo.Cancelar);

		gameObject.SetActive(false);
		UI_Empreendimento.Desselecionar();
	}
	
	public void Abrir()
	{
		painelConfiguracoes.Fechar(true);
		painelConquistas.Fechar(true);

		if (gameObject.activeSelf)
		{
			Fechar();
		}
		else
		{
			gameObject.SetActive(true);
			Som.Tocar(Som.Tipo.Navegar);
			//CriarListaEmpreendimentos.CarregarEstatico();
		}
	}

	/// <summary> 
	/// Compra o empreendimento selecionado, se este atender aos pre-requisitos.
	/// </summary>
	public void Comprar()
	{
		UI_Empreendimento.ComprarEstatico();
	}
}


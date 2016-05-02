using UnityEngine;
using System.Collections;

public class PopupConfiguracoes : MonoBehaviour
{
	public PopupEmpreendimentos painelEmpreendimentos;
	public PopupConquistas painelConquistas;
	
	public void Fechar(bool fechadoPorAbrirOutra = false)
	{
		if (fechadoPorAbrirOutra == false)
			Som.Tocar(Som.Tipo.Cancelar);

		gameObject.SetActive(false);
	}
	
	public void Abrir()
	{
		if (painelConquistas)
			painelConquistas.Fechar(true);

		if (painelEmpreendimentos)
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


	public void AbrirTutorial()
	{
		Jogador.RodarTutorial();
	}
}


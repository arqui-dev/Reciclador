using UnityEngine;
using System.Collections;

public class PopupConfiguracoes : MonoBehaviour
{
	static public PopupConfiguracoes instancia = null;

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


	public void FecharJogo()
	{
		Jogador.Salvar();
		if (Application.loadedLevelName == "Jogo")
		{
			//Jogador.LimparCenario();

			Destroy(GameObject.Find("_ControleSom"));
			Destroy(GameObject.Find("_ControleMusica"));

			ObjGerenciadorLixo.instancia = null;
			Jogador.recicladoraPapel = null;
			Jogador.recicladoraMetal = null;
			Jogador.recicladoraPlastico = null;
			Jogador.recicladoraVidro = null;

			Jogador.carregouRecicladoras = false;
			Jogador.pegouCanvasReset = false;

			Destroy(Jogador.instancia.gameObject);
			Jogador.instancia = null;

			Application.LoadLevel("Menu");
		}
		else
		{
			Application.Quit();	
		}
	}


	void Awake()
	{
		instancia = this;
		gameObject.SetActive(false);
	}
}


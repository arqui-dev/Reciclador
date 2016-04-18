using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BotaoSomMusica : MonoBehaviour
{
	Color [] cores = {Color.gray, Color.white};

	public bool musica = true;

	void Awake()
	{
		Verificar();
	}

	public void Clicar()
	{
		if (musica)
		{
			Musica.PausarContinuar();
		}
		else
		{
			Som.HabilitarDesabilitar();
		}

		Verificar();
	}

	void Verificar()
	{
		int cor = 0;
		if (musica)
		{
			cor = 0;
			if (Dados.musicaLigado)
			{
				cor = 1;
			}
		}
		else
		{
			cor = 0;
			if (Dados.somLigado)
			{
				cor = 1;
			}
		}

		Debug.Log ("Som "+Dados.somLigado + ", Musica "+Dados.musicaLigado);
		
		GetComponent<Image>().color = cores[cor];
	}
}


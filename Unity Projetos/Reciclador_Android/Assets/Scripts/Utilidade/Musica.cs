using UnityEngine;
using System.Collections;

public class Musica : MonoBehaviour
{
	static AudioSource som;

	private Musica _instancia = null;
	void Awake()
	{
		if (_instancia != null && _instancia != this)
		{
			DestroyImmediate(gameObject);
		}
		DontDestroyOnLoad(gameObject);
		_instancia = this;
		som = GetComponent<AudioSource>();

		if (som)
			som.Play();

		Verificar();
	}

	static public void PausarContinuar()
	{
		Dados.musicaLigado = !Dados.musicaLigado;
		Verificar();
	}

	static public void Verificar()
	{
		if (som)
		{
			if (Dados.musicaLigado)
			{
				som.UnPause();
			}
			else
			{
				som.Pause();
			}
		}
	}
}


using UnityEngine;
using System.Collections;

public class Som : MonoBehaviour
{
	private Som _instancia = null;

	public enum Tipo {
		Navegar, Cancelar, Comprar, AcertarLixeira,
		ErrarLixeira, CompletarReciclagem, AcertarMonstro, AparecerMonstro, 
		JuntarMonstro, SumirReciclavel, Mensagem
	}

	public AudioClip [] _sons;

	static AudioSource som;
	static AudioClip [] sons;

	void Awake()
	{
		if (_instancia != null && _instancia != this)
		{
			DestroyImmediate(gameObject);
		}
		_instancia = this;
		DontDestroyOnLoad(gameObject);

		sons = _sons;

		som = GetComponent<AudioSource>();
		Verificar();
	}

	public static void HabilitarDesabilitar()
	{
		Dados.somLigado = !Dados.somLigado;
		Verificar();

		Tocar(Tipo.Navegar);
	}

	public static void Verificar()
	{
		if (som)
			som.mute = !Dados.somLigado;
	}

	public static void Tocar(int clip)
	{
		if (clip >= 0 && clip < sons.Length && som && Dados.somLigado)
		{
			som.PlayOneShot(sons[clip]);
		}
	}

	public static void Tocar(Tipo tipo)
	{
		Tocar ((int) tipo);
	}
}


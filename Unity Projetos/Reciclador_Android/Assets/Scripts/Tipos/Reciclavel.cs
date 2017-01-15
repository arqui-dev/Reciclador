using UnityEngine;
using System.Collections;

public class Reciclavel
{
	public enum Tipo {
		Papel, Vidro, Metal, Plastico, Aleatorio, EasterEgg
	}

	const float chancePapel		= 0.25f;
	const float chanceVidro		= 0.25f;
	const float chanceMetal 	= 0.25f;
	const float chancePlastico	= 0.25f;

	public Tipo tipo
	{
		get { return _tipo; }
	}
	public int dureza
	{
		get { return _dureza; }
	}

	Tipo	_tipo;
	int		_dureza = 1;

	public int EasterEgg()
	{
		if (tipo != Tipo.EasterEgg)
			return -1;

		return _dureza;
	}

	public Reciclavel(Tipo tipo = Tipo.Aleatorio, int dureza = -1)
	{
		if (tipo == Tipo.Aleatorio)
		{
			_tipo = PegarTipoAleatorio();
		}
		else
		{
			_tipo = tipo;
		}
		Inicializar();

		if (dureza > 0)
		{
			_dureza = dureza;
		}
	}

	void Inicializar()
	{
		switch(_tipo){
		case Tipo.Papel:	_dureza = 1; break;
		case Tipo.Vidro:	_dureza = 2; break;
		case Tipo.Metal: 	_dureza = 3; break;
		case Tipo.Plastico: _dureza = 4; break;
		}
	}

	static public Tipo PegarTipoAleatorio()
	{
		float r = Random.value;

		if (r < chancePapel)
		{
			return Tipo.Papel;
		}

		if (r < chancePapel + chanceVidro)
		{
			return Tipo.Vidro;
		}

		if (r < chancePapel + chanceVidro + chanceMetal)
		{
			return Tipo.Metal;
		}

		return Tipo.Plastico;
	}
}
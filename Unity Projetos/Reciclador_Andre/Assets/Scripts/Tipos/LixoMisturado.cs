using UnityEngine;
using System.Collections;

public class LixoMisturado
{
	// atributos estaticos
	static int 	multiplicadorVidaBase	= 10;
	static int 	danoMinimo				= 1;

	// estaticos publicos
	static public float	tempoRegen	= 3;
	static public int	nivelMaximo	= 10;

	// atributos publicos
	public bool 	estaNivelMaximo
	{
		get { return _nivel >= nivelMaximo; }
	}
	public int 		nivel
	{
		get { return _nivel; }
	}
	public int 		vida
	{
		get { return _vidaAtual; }
	}
	public bool 	podeRegenerar
	{
		get { return _regen > 0 && _vidaAtual < _vidaMaxima; }
	}

	// atributos privados
	int 	_nivel			= 1;
	int		_vidaMaxima		= 0;
	int	 	_vidaAtual		= 0;
	int		_regen			= 0;
	int		_armadura		= 0;

	// Construtores
	public LixoMisturado(int nivel = 1)
	{
		if (nivel > nivelMaximo)
		{
			nivel = nivelMaximo;
		}
		//this._nivel = Random.Range(1, nivel + 1);
		this._nivel = ObjGerenciadorLixo.ultimoNivelCriadoLixo;
		Iniciar();
	}

	// Metodos privados
	void Iniciar()
	{
		_vidaMaxima	= CalcularVidaMaxima();
		_vidaAtual	= _vidaMaxima;
	}

	int CalcularVidaMaxima()
	{
		//int n = (int) Mathf.Pow(2, _nivel - 1);
		int n = _nivel;
		return n * multiplicadorVidaBase;
	}

	// Metodos publicos
	public bool ReceberDano(int dano, int redutorArmadura = 0)
	{
		int armaduraTotal = _armadura - redutorArmadura;
		if (armaduraTotal < 0)
		{
			armaduraTotal = 0;
		}

		dano -= armaduraTotal;
		if (dano < danoMinimo)
		{
			dano = danoMinimo;
		}

		_vidaAtual -= dano;
		if (_vidaAtual <= 0)
		{
			_vidaAtual = 0;
			return true;
		}

		return false;
	}

	public bool Regenerar()
	{
		if (_regen > 0 && _vidaAtual < _vidaMaxima)
		{
			_vidaAtual += _regen;
			Curar (_regen);
			return true;
		}
		return false;
	}

	public void Curar(int vidaExtra)
	{
		_vidaAtual += vidaExtra;
		if (_vidaAtual > _vidaMaxima)
		{
			_vidaAtual = _vidaMaxima;
		}
	}

	public bool PodeFundir(LixoMisturado outro)
	{
		return !(this.estaNivelMaximo || outro.estaNivelMaximo);
	}

	public void Fundir(LixoMisturado outro)
	{
		int nivel = this.nivel + outro.nivel;
		if (nivel > nivelMaximo)
		{
			nivel = nivelMaximo;
		}

		_nivel = nivel;
		Iniciar ();
	}
}


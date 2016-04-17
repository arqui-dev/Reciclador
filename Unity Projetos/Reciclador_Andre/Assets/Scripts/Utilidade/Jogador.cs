using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour
{
	static public Jogador instancia = null;

	public GameObject _canvasReset;

	public int 	multiplicadorXPNivel	= 50;
	public int 	multiplicadorXPGeral	= 100;

	public int dinheiroInicialTestes	= 10000;
	public int nivelInicialTestes		= 90;


	static long	_pontos				= 0;
	static int	_dano				= 1;
	static int 	_quebrarArmadura	= 0;
	static int 	_xpAtual			= 0;
	static int	_xpTotal			= 0;
	static int 	_xpProximoNivel		= 1;
	static int	_nivel				= 1;
	static int 	_resets				= 0;

	static bool inicializado		= false;

	static GameObject canvasReset	= null;

	static public int	dano
	{
		get 
		{ 
			return _dano + ObjEmpreendimentos.taxaSeparacaoLixo
				+ Dados.bonusResetDano * _resets;
		}
	}
	static public int	quebrarArmadura
	{
		get { return _quebrarArmadura; }
	}
	static public long	pontos
	{
		get { return _pontos; }
	}
	static public int 	nivel
	{
		get { return _nivel; }
	}
	static public int 	xpTotal
	{
		get { return _xpTotal; }
	}
	static public int 	xpAtual
	{
		get { return _xpAtual; }
	}
	static public int 	xpProximoNivel
	{
		get { return _xpProximoNivel; }
	}
	static public int resets
	{
		get { return _resets; }
	}

	static public bool Gastar(long custo)
	{
		if (custo <= _pontos)
		{
			_pontos -= custo;
			return true;
		}
		return false;
	}

	static public void Pontuar(long pontos)
	{
		_pontos += (pontos + Dados.bonusResetDinheiro * _resets);
	}

	static public int XPAjeitada(int xp)
	{
		return xp * instancia.multiplicadorXPGeral;
	}

	static public bool GanharXP(int xp)
	{
		bool subiuDeNivel = false;

		int xpExtra = Dados.bonusResetXP * _resets;

		_xpAtual += (xp + xpExtra);

		if (_xpAtual < 0)
		{
			_xpAtual = 0;
		}

		while (_xpAtual >= _xpProximoNivel)
		{
			_xpAtual -= _xpProximoNivel;
			_nivel++;

			AtualizarXPProximoNivel();
			subiuDeNivel = true;
		}

		AtualizarXPTotal();

		if (_nivel > Dados.nivelMaximo)
		{
			_nivel = Dados.nivelMaximo;
		}

		VerificarReset();

		return subiuDeNivel;
	}

	static void VerificarReset()
	{
		if (canvasReset != null)
		{
			if (_nivel < Dados.nivelMaximo)
			{
				canvasReset.SetActive(false);
			}
			else
			{
				canvasReset.SetActive(true);
			}
		}
	}

	static void AtualizarXPProximoNivel()
	{
		_xpProximoNivel = CalcularXPProximoNivel(_nivel);
	}

	static int CalcularXPProximoNivel(int pnivel)
	{
		return pnivel * XPAjeitada(instancia.multiplicadorXPNivel);
	}

	static void AtualizarXPTotal()
	{
		int valorBase		= (_nivel * (_nivel - 1)) / 2;
		int multiplicador	= XPAjeitada(instancia.multiplicadorXPNivel);

		_xpTotal = valorBase * multiplicador + _xpAtual;
	}

	static public void Inicializar()
	{
		AtualizarXPProximoNivel();
		AtualizarXPTotal();

		VerificarReset();

		inicializado = true;
	}

	static public void Resetar()
	{
		_resets++;
		_pontos				= 0;
		_dano				= 1;
		_quebrarArmadura	= 0;
		_xpAtual			= 0;
		_xpTotal			= 0;
		_xpProximoNivel		= 1;
		_nivel				= 1;
		Inicializar();
	}

	void Awake()
	{
#if UNITY_EDITOR
		_pontos = dinheiroInicialTestes;
		_nivel = nivelInicialTestes;
#endif

		if (instancia == null)
		{
			instancia	= this;
			canvasReset = _canvasReset;
		}
		if (inicializado == false)
		{
			Inicializar();
		}
	}
}


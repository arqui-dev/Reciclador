using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Jogador : MonoBehaviour
{
	static public Jogador instancia = null;

	public GameObject _canvasReset;

	public int 	multiplicadorXPNivel	= 50;
	public int 	multiplicadorXPGeral	= 100;

	public int dinheiroInicialTestes	= 10000;
	public int nivelInicialTestes		= 90;

	public float tempoSalvar			= 5;
	float proximoSave = 0;


	static long	_pontos				= 0;
	static int	_dano				= 1;
	static int 	_quebrarArmadura	= 0;
	static int 	_xpAtual			= 0;
	static int	_xpTotal			= 0;
	static int 	_xpProximoNivel		= 1;
	static int	_nivel				= 1;
	static int 	_resets				= 0;

	static bool inicializado		= false;

	static ulong tempoDeJogo		= 0;

	static GameObject canvasReset	= null;

	static public void Salvar()
	{
		string divisor = "|";
		string saida = "Reciclador";

		tempoDeJogo += (ulong) Time.time;

		saida += divisor + _pontos;
		saida += divisor + _dano;
		saida += divisor + _quebrarArmadura;
		saida += divisor + _xpAtual;
		saida += divisor + _xpTotal;
		saida += divisor + _xpProximoNivel;
		saida += divisor + _nivel;
		saida += divisor + _resets;
		saida += divisor + tempoDeJogo;

		PlayerPrefs.SetString(Dados.stringSalvar, saida);

		GerenciadorEmpreendimentos.Salvar();

		Debug.Log ("Jogador Salvo");
	}

	static void Carregar()
	{
		if (PlayerPrefs.HasKey(Dados.stringSalvar) == false)
			return;

		string entrada = PlayerPrefs.GetString(Dados.stringSalvar);
		string [] divisor = {"|"};
		string [] lista = entrada.Split(divisor, System.StringSplitOptions.None);

		_pontos 			= long.Parse(lista[1]);
		_dano 				= int.Parse(lista[2]);
		_quebrarArmadura 	= int.Parse(lista[3]);
		_xpAtual 			= int.Parse(lista[4]);
		_xpTotal 			= int.Parse(lista[5]);
		_xpProximoNivel	 	= int.Parse(lista[6]);
		_nivel 				= int.Parse(lista[7]);
		_resets 			= int.Parse(lista[8]);
		tempoDeJogo 		= ulong.Parse(lista[9]);

		Debug.Log ("Jogador Carregado\n"+entrada);
	}

	static public int 	EasterEggMaximo()
	{
		if (_nivel < Dados.nivelMinimoEasterEggs || 
		    ObjGerenciadorLixo.QuantidadeEasterEggs() < 1)
		{
			return -1;
		}

		int intervalo = Dados.nivelMaximo - Dados.nivelMinimoEasterEggs;

		intervalo = intervalo / ObjGerenciadorLixo.QuantidadeEasterEggs();

		int proximoEgg = Dados.nivelMinimoEasterEggs + intervalo;

		int saida = 1;
		for (int i = Dados.nivelMinimoEasterEggs + 1; i <= _nivel; i++)
		{
			if (i >= proximoEgg)
			{
				proximoEgg += intervalo;
				saida++;
			}
		}

		return saida;
	}

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
		if (instancia == null) return xp * 100;
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
		int mu = 50;
		if (instancia != null)
			mu = instancia.multiplicadorXPNivel;
		int valorBase		= (_nivel * (_nivel - 1)) / 2;
		int multiplicador	= XPAjeitada(mu);

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
/*
#if UNITY_EDITOR
		_pontos = dinheiroInicialTestes;
		_nivel = nivelInicialTestes;
#endif
//*/
		Debug.Log("Teste amor");
		if (instancia == null)
		{
			instancia	= this;
			canvasReset = _canvasReset;
		}
		if (inicializado == false)
		{
			Inicializar();
			Carregar();
		}
		proximoSave = Time.time + tempoSalvar;

		/*
		_pontos = dinheiroInicialTestes;
		_nivel = nivelInicialTestes;
		//*/

		/*
		PlayerPrefs.DeleteAll();
		//*/
	}

	static public ObjAreaReciclavel recicladoraPapel = null;
	static public ObjAreaReciclavel recicladoraVidro = null;
	static public ObjAreaReciclavel recicladoraMetal = null;
	static public ObjAreaReciclavel recicladoraPlastico = null;

	static bool carregouRecicladoras = false;

	void Update()
	{
		if (Application.loadedLevelName == "Jogo")
		{
			UI_Achievements.VerificarUnlockEstatico();

			if (Time.time > proximoSave)
			{
				proximoSave = Time.time + tempoSalvar;
				Salvar();
				ObjGerenciadorLixo.instancia.Salvar();
				recicladoraPapel.Salvar();
				recicladoraVidro.Salvar();
				recicladoraMetal.Salvar();
				recicladoraPlastico.Salvar();
				UI_Achievements.SalvarEstatico();
			}

			if (carregouRecicladoras == false)
			{
				recicladoraPapel.Carregar();
				recicladoraVidro.Carregar();
				recicladoraMetal.Carregar();
				recicladoraPlastico.Carregar();
				carregouRecicladoras = true;
			}
		}
	}
}


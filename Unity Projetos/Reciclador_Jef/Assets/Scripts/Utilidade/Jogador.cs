using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Jogador : MonoBehaviour
{
	static public Jogador instancia = null;

	//public GameObject _canvasReset;

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

		// JEF AQUI
		for (int i = 0; i < Dados.easterJaAberto.Length; i++)
		{
			saida += divisor + Dados.easterJaAberto[i];
		}

		PlayerPrefs.SetString(Dados.stringSalvar, saida);

		int tuto = 0;
		if (tutorialCompleto) tuto = 1;
		PlayerPrefs.SetInt(tutorialNome, tuto);

		GerenciadorEmpreendimentos.Salvar();

		Debug.Log ("Jogador Salvo");
	}

	static string tutorialNome = "Tutorial";

	static void Carregar()
	{
		if (PlayerPrefs.HasKey(tutorialNome))
		{
			tutorialCompleto = PlayerPrefs.GetInt(tutorialNome) == 1;
		}

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

		// JEF AQUI
		if (lista.Length >= 10 + Dados.easterJaAberto.Length)
		{
			for (int i = 0; i < Dados.easterJaAberto.Length; i++)
			{
				Dados.easterJaAberto[i] = bool.Parse(lista[i + 10]);
			}
		}

		Debug.Log ("Jogador Carregado\n"+entrada);
	}

	static public int 	EasterEggMaximo()
	{
		if (_nivel < Dados.nivelMinimoEasterEggs || 
		    ObjGerenciadorLixo.QuantidadeEasterEggs() < 1)
		{
			return -1;
		}

		for (int i = 1; i < Dados.niveisEasterEggs.Length; i++)
		{
			if (_nivel < Dados.niveisEasterEggs[i])
			{
				return Dados.niveisEasterEggs[i-1];
			}
		}

		return Dados.niveisEasterEggs[Dados.niveisEasterEggs.Length - 1];
	}

	// JEF AQUI
	static void VerificarEasterEgg()
	{
		for (int i = 0; i < Dados.niveisEasterEggs.Length; i++)
		{
			if (Dados.easterJaAberto[i] == false &&
				_nivel >= Dados.niveisEasterEggs[i])
			{
				Dados.easterJaAberto[i] = true;
				ObjGerenciadorLixo.CriarReciclavelEasterEgg(i + 1, false);
			}
		}
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


			// JEF AQUI
			VerificarEasterEgg();

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
		if (instancia)
			return pnivel * XPAjeitada(instancia.multiplicadorXPNivel);
		return pnivel * XPAjeitada(50);
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
			//canvasReset = _canvasReset;
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
	public static bool pegouCanvasReset = false;

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

			if (pegouCanvasReset == false)
			{
				canvasReset = GameObject.Find("CanvasReset").gameObject;
				canvasReset.SetActive(false);
				pegouCanvasReset = true;
			}

			VerificarReset();
		}
	}

	// Jef
	static public void CheatNivel1()
	{
		_nivel = 1;
		_xpAtual = 0;
		_xpTotal = 0;
		Inicializar();
	}

	static public void CheatNivelSomar(int quantidade)
	{
		_nivel += quantidade;
		_xpAtual = 0;
		AtualizarXPTotal();
	}

	static public void CheatDinheiroZero()
	{
		_pontos = 0;
	}

	static public void CheatDinheiroSomar(int quantidade)
	{
		Pontuar(quantidade);
	}

	static public void CheatReciclarZerar()
	{
		ObjAreaReciclavel.numMateriaisReciclados = 0;
	}

	static public void CheatReciclarMateriais(int quantidade)
	{
		ObjAreaReciclavel.numMateriaisReciclados += quantidade;
	}

	static public void Reset()
	{
		PlayerPrefs.DeleteAll();

		ObjGerenciadorLixo.LimparCenario();

		recicladoraPapel.Limpar();
		recicladoraVidro.Limpar();
		recicladoraMetal.Limpar();
		recicladoraPlastico.Limpar();

		GerenciadorEmpreendimentos.Reiniciar();

		Destroy(GameObject.Find("_ControleSom"));
		Destroy(GameObject.Find("_ControleMusica"));
		Destroy(ObjEmpreendimentos.instancia.gameObject);
		Destroy(instancia.gameObject);

		carregouRecicladoras = false;
		pegouCanvasReset = false;

		canvasReset = null;
		recicladoraPapel = null;
		recicladoraVidro = null;
		recicladoraMetal = null;
		recicladoraPlastico = null;

		_pontos				= 0;
		_dano				= 1;
		_quebrarArmadura	= 0;
		_xpAtual			= 0;
		_xpTotal			= 0;
		_xpProximoNivel		= 1;
		_nivel				= 1;

		inicializado = false;

		instancia = null;
		Application.LoadLevel("Menu");
	}

	public static bool tutorialRodando = true;
	public static bool tutorialCompleto = false;

	static public void RodarTutorial()
	{
		tutorialRodando = true;

		LimparCenario();

		ObjGerenciadorLixo.instancia = null;

		Application.LoadLevel("Tutorial");
	}

	static public void LimparCenario()
	{
		ObjGerenciadorLixo.LimparCenario();

		recicladoraPapel.Limpar();
		recicladoraVidro.Limpar();
		recicladoraMetal.Limpar();
		recicladoraPlastico.Limpar();
	}
}


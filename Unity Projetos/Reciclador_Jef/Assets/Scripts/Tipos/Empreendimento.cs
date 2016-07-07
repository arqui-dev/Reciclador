using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Empreendimento// : MonoBehaviour
{
	public string 	nome						= "";
	public string 	identificador 				= "";

	public int		[]	_taxaSeparacaoLixo		= {0};
	public long		[]	_dinheiroPorTempo		= {0};
	public float	[]	_aumentoXP				= {0};
	public int 		[]	_nivelMinimoLixo		= {0};
	public Vector4	[]	_limiteRecicladoras		= {Vector4.zero};
	public Vector4	[]	_valorDeVenda 			= {Vector4.zero};
	public Vector4	[]	_velocidadeReciclagem	= {Vector4.zero};

	public float	[]	_velocidadeAparecerLixo	= {0};

	// TODO: Ajeitar a separaçao automatica!
	public int 		[]	_separacaoAutomatica	= {0};

	public long		[]	_custos					= {	1 };
	public int		[]	_nivelRequisito			= { 1 };

	// outros empreendimentos de requisito
	public Dictionary<int,Dictionary<string, int>> _empreendimentosRequisitos = 
		new Dictionary<int,Dictionary<string, int>>();

	// Precisa de 1 nivel a mais, para mostrar a descriçao
	// sem comprar e de cada nivel
	public string []	_descricao				= {""};

	int [] 		_valorBaseI = {0,0,0,0};
	float [] 	_valorBaseF = {0,0,0,0};

	int 	_nivel = 0;

	public ValoresEmpreendimentos valores;

	public void AlterarNivel(int novoNivel)
	{
		#if UNITY_EDITOR

		_nivel = novoNivel;

		#endif
	}

	public void Imprimir(int nivel = -1)
	{
		if (nivel > 0)
		{
			AlterarNivel(nivel);
		}

		string saida = "Empreendimento "+nome+". Identificador: "+identificador+". Nivel "+nivel+"\n";
		saida += "    "+"Custo para o próximo nível: "+custo + "\n";
		saida += "    "+"Sustentabilidade necessária para o próximo nível: "+nivelRequisito+"\n";
		saida += "    "+"Poder do jogador: "+taxaSeparacaoLixo+"\n";
		saida += "    "+"Dinheiro por tempo: "+dinheiroPorTempo+"\n";
		saida += "    "+"Aumento de XP: "+aumentoXP+"\n";
		saida += "    "+"Nível extra do lixo: "+nivelMinimoLixo+"\n";
		saida += "    "+"Dano automático por tempo: "+separacaoAutomatica+"\n";
		saida += "    "+"Descrição: '"+descricao+"'\n\n";
		saida += "    "+"Limite das recicladoras:"+"\n";
		saida += "        "+"Papel: "+limiteRecicladoras[0]+"; Vidro: "+limiteRecicladoras[1]+"; Metal: "+limiteRecicladoras[2]+"; Plástico: "+limiteRecicladoras[3]+"\n";
		saida += "    "+"Valor de venda:"+"\n";
		saida += "        "+"Papel: "+valorDeVenda[0].ToString("0.0")+"; Vidro: "+valorDeVenda[1].ToString("0.0")+"; Metal: "+valorDeVenda[2].ToString("0.0")+"; Plástico: "+valorDeVenda[3].ToString("0.0")+"\n";
		saida += "    "+"Velocidade de Reciclagem:"+"\n";
		saida += "        "+"Papel: "+velocidadeReciclagem[0].ToString("0.0")+"; Vidro: "+velocidadeReciclagem[1].ToString("0.0")+"; Metal: "+velocidadeReciclagem[2].ToString("0.0")+"; Plástico: "+velocidadeReciclagem[3].ToString("0.0")+"\n";
		//saida += "    "+""+"\n";
		Debug.Log(saida);
	}

	public int		nivelMaximo {
		//get { return _custos.Length; }
		get { return 1000000; }
	}
	public long		custo {
		get 
		{ 
			if (_nivel >= nivelMaximo) return -1;
			return valores.Custos(_nivel);
		}
	}
	public int		nivel {
		get { return _nivel; }
	}

	public int separacaoAutomatica {
		get { return valores.SeparacaoAutomatica(_nivel); }
	}

	public int 		nivelRequisito
	{
		get
		{
			if (_nivel == nivelMaximo) return -1;
			return valores.NivelRequisito(_nivel);
		}
	}

	public int NivelMinimo()
	{
		return valores.NivelRequisito(1);
	}

	public string 	descricao{
		get { return valores.Descricao(_nivel); }
	}

	public int		taxaSeparacaoLixo {
		get
		{
			if (_nivel == 0) return 0;
			return valores.TaxaSeparacaoLixo(_nivel);
		}
	}
	public long		dinheiroPorTempo {
		get
		{
			if (_nivel == 0) return 0;
			return valores.DinheiroPorTempo(_nivel);
		}
	}
	public float 	aumentoXP {
		get
		{
			if (_nivel == 0) return 0;
			return valores.AumentoXP(_nivel);
		}
	}
	public int 		nivelMinimoLixo {
		get
		{
			if (_nivel == 0) return 0;
			return valores.NivelMinimoLixo(_nivel);
		}
	}
	public int []	limiteRecicladoras {
		get 
		{
			if (_nivel == 0) return _valorBaseI;
			/*
			int [] ret = new int[4];
			ret[0] = (int)_limiteRecicladoras[_nivel - 1].x;
			ret[1] = (int)_limiteRecicladoras[_nivel - 1].y;
			ret[2] = (int)_limiteRecicladoras[_nivel - 1].z;
			ret[3] = (int)_limiteRecicladoras[_nivel - 1].w;
			return ret;
			*/
			return valores.LimiteRecicladoras(_nivel);
		}
	}
	public float []	valorDeVenda {
		get
		{
			if (_nivel == 0) return _valorBaseF;
			/*
			float [] ret = new float[4];
			ret[0] = _valorDeVenda[_nivel - 1].x;
			ret[1] = _valorDeVenda[_nivel - 1].y;
			ret[2] = _valorDeVenda[_nivel - 1].z;
			ret[3] = _valorDeVenda[_nivel - 1].w;
			return ret;
			*/
			return valores.ValorDeVenda(_nivel);
		}
	}
	public float []	velocidadeReciclagem {
		get
		{
			if (_nivel == 0) return _valorBaseF;
			/*
			float [] ret = new float[4];
			ret[0] = _velocidadeReciclagem[_nivel - 1].x;
			ret[1] = _velocidadeReciclagem[_nivel - 1].y;
			ret[2] = _velocidadeReciclagem[_nivel - 1].z;
			ret[3] = _velocidadeReciclagem[_nivel - 1].w;
			return ret;
			*/
			return valores.VelocidadeReciclagem(_nivel);
		}
	}

	public float 	velocidadeAparecerLixo {
		get
		{
			if (_nivel == 0) return 0;
			return valores.VelocidadeAparecerLixo(_nivel);
		}
	}

	public void Reiniciar()
	{
		_nivel = 0;
	}

	public bool SubirDeNivel()
	{
		if (_nivel < nivelMaximo)
		{
			_nivel++;
			return true;
		}
		return false;
	}

	override public string ToString()
	{
		string saida = "";
		saida += "Identificador: " 	+ identificador + "\n";
		saida += "Nome: " 			+ nome + "\n";
		saida += "Descrição: " 		+ descricao + "\n";
		saida += "Nível máximo: " 	+ nivelMaximo + "\n\n";

		for (int nv = 0; nv < nivelMaximo; nv++)
		{
			saida += "Nível: " 		+ (nv+1) + "\n";
			saida += "    Atributos: " 	+ "\n";
			saida += "        Velocidade de reciclagem: "	+ _velocidadeReciclagem[nv].x + ", " + _velocidadeReciclagem[nv].y + ", " + _velocidadeReciclagem[nv].z + ", " + _velocidadeReciclagem[nv].w + "\n";
			saida += "        Valor de venda: " + _valorDeVenda[nv].x + ", " + _valorDeVenda[nv].y + ", " + _valorDeVenda[nv].z + ", " + _valorDeVenda[nv].w + "\n";
			saida += "        Experiência extra: " + _aumentoXP[nv] + "\n";
			saida += "        Velocidade aparecer Lixo: "	+ _velocidadeAparecerLixo[nv] + "\n";
			saida += "        Limite das filas de reciclagem: "	+ _limiteRecicladoras[nv].x + ", " + _limiteRecicladoras[nv].y + ", " + _limiteRecicladoras[nv].z + ", " + _limiteRecicladoras[nv].w + "\n";
			saida += "        Nível mínimo do lixo: "	+ _nivelMinimoLixo[nv] + "\n";
			saida += "        Dinheiro gerado por tempo: "	+ _dinheiroPorTempo[nv] + "\n";
			saida += "        Separação automática: "	+ _separacaoAutomatica[nv] + "\n";
			saida += "        Taxa de separação do jogador: " + _taxaSeparacaoLixo[nv] + "\n";

			saida += "    Requisitos: " 	+ "\n";
			saida += "        Preço: " + _custos[nv] + "\n";
			saida += "        Sustentabilidade Mínima: " + _nivelRequisito[nv] + "\n";
			saida += "        Empreendimentos construídos: " +  "\n";
			foreach(string s in _empreendimentosRequisitos[nv+1].Keys)
			{
				saida += "            " + s + ": "+ _empreendimentosRequisitos[nv+1][s] + "\n";
			}
			saida += "\n";
		}

		return saida;
	}

	public bool PodeComprar()
	{
		if (custo <= Jogador.pontos && custo > 0 &&
		    nivelRequisito >= 0 && nivelRequisito <= Jogador.nivel
			)//&& TemRequisitos())
		{
			return true;
		}
		return false;
	}

	bool TemRequisitos()
	{
		if (nivel >= nivelMaximo)
		{
			Debug.Log ("Nivel >= nivel maximo");
			return false;
		}

		if (_empreendimentosRequisitos.ContainsKey(nivel+1))
		{
			foreach(string s in _empreendimentosRequisitos[nivel+1].Keys)
			{
				if (GerenciadorEmpreendimentos.TemRequisito(
					s, _empreendimentosRequisitos[nivel+1][s]) == false)
				{
					Debug.Log ("Nao tem: "+s+": "+_empreendimentosRequisitos[nivel+1][s]);
					return false;
				}
			}
			return true;
		}

		Debug.Log ("Nao contem nivel "+nivel);
		return false;
	}

	public void Carregar()
	{
		if (PlayerPrefs.HasKey(identificador))
		{
			_nivel = PlayerPrefs.GetInt(identificador);
			Debug.Log ("Empreendimento '"+identificador+"' carregado. Nivel: "+_nivel);
		}
	}

	public void Salvar()
	{
		PlayerPrefs.SetInt(identificador, _nivel);
	}
}
/*
Os empreendimentos sustentáveis (upgrades) podem fazer:
aumentar a taxa de separação do lixo (hp)
aumentar o ganho de $ ($/tempo)
aumentar % a xp ganha (+25% ex)
Aumentar o limite da fila das lixeiras
Aumentar a velocidade de reciclagem
Nivel minimo do lixo
*/

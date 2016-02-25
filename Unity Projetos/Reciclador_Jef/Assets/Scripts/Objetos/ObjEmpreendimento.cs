using UnityEngine;
using System.Collections;

public class ObjEmpreendimento : MonoBehaviour
{

	public string 	nome						= "";
	
	public int		[]	_taxaSeparacaoLixo		= {0};
	public long		[]	_dinheiroPorTempo		= {0};
	public float	[]	_aumentoXP				= {0};
	public int 		[]	_nivelMinimoLixo		= {0};
	public Vector4	[]	_limiteRecicladoras		= {Vector4.zero};
	public Vector4	[]	_valorDeVenda 			= {Vector4.zero};
	public Vector4	[]	_velocidadeReciclagem	= {Vector4.zero};
	
	public float	[]	_velocidadeAparecerLixo	= {0};
	
	public long		[]	_custos					= {	1 };
	public int		[]	_nivelRequisito			= { 1 };
	
	// Precisa de 1 nivel a mais, para mostrar a descriçao
	// sem comprar e de cada nivel
	public string []	_descricao				= {""};
	
	int [] 		_valorBaseI = {0,0,0,0};
	float [] 	_valorBaseF = {0,0,0,0};
	
	int 	_nivel = 0;
	
	public int		nivelMaximo {
		get { return _custos.Length; }
	}
	public long		custo {
		get 
		{ 
			if (_nivel >= nivelMaximo) return -1;
			return _custos[_nivel]; 
		}
	}
	public int		nivel {
		get { return _nivel; }
	}
	
	public int 		nivelRequisito
	{
		get
		{
			if (_nivel == nivelMaximo) return -1;
			return _nivelRequisito[_nivel];
		}
	}
	
	public string 	descricao{
		get { return _descricao[_nivel]; }
	}
	
	public int		taxaSeparacaoLixo {
		get
		{
			if (_nivel == 0) return 0;
			return _taxaSeparacaoLixo[_nivel - 1];
		}
	}
	public long		dinheiroPorTempo {
		get
		{
			if (_nivel == 0) return 0;
			return _dinheiroPorTempo[_nivel - 1];
		}
	}
	public float 	aumentoXP {
		get
		{
			if (_nivel == 0) return 0;
			return _aumentoXP[_nivel - 1];
		}
	}
	public int 		nivelMinimoLixo {
		get
		{
			if (_nivel == 0) return 0;
			return _nivelMinimoLixo[_nivel - 1];
		}
	}
	public int []	limiteRecicladoras {
		get 
		{
			if (_nivel == 0) return _valorBaseI;
			int [] ret = new int[4];
			ret[0] = (int)_limiteRecicladoras[_nivel - 1].x;
			ret[1] = (int)_limiteRecicladoras[_nivel - 1].y;
			ret[2] = (int)_limiteRecicladoras[_nivel - 1].z;
			ret[3] = (int)_limiteRecicladoras[_nivel - 1].w;
			return ret;
		}
	}
	public float []	valorDeVenda {
		get
		{
			if (_nivel == 0) return _valorBaseF;
			float [] ret = new float[4];
			ret[0] = _valorDeVenda[_nivel - 1].x;
			ret[1] = _valorDeVenda[_nivel - 1].y;
			ret[2] = _valorDeVenda[_nivel - 1].z;
			ret[3] = _valorDeVenda[_nivel - 1].w;
			return ret;
		}
	}
	public float []	velocidadeReciclagem {
		get
		{
			if (_nivel == 0) return _valorBaseF;
			float [] ret = new float[4];
			ret[0] = _velocidadeReciclagem[_nivel - 1].x;
			ret[1] = _velocidadeReciclagem[_nivel - 1].y;
			ret[2] = _velocidadeReciclagem[_nivel - 1].z;
			ret[3] = _velocidadeReciclagem[_nivel - 1].w;
			return ret;
		}
	}
	
	public float 	velocidadeAparecerLixo {
		get
		{
			if (_nivel == 0) return 0;
			return _velocidadeAparecerLixo[_nivel - 1];
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
}


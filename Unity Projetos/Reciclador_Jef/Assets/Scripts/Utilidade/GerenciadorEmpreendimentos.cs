using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Classe para gerenciar a lista dos empreendimentos carregados.
/// </summary>
public class GerenciadorEmpreendimentos : MonoBehaviour
{
	/// <summary>	/// Dicionário com todos os empreendimentos. A chave é o identificador.	/// </summary>
	public static Dictionary<string,Empreendimento> dicionarioEmpreendimentos = 
		new Dictionary<string, Empreendimento>();

	/// <summary> 	/// Usado para mostrar os empreendimentos apenas quando estiverem carregados.	/// </summary>
	static bool _carregado = false;
	/// <summary> 	/// Usado para mostrar os empreendimentos apenas quando estiverem carregados.	/// </summary>
	public static bool carregado { get { return _carregado; } }


	static public Empreendimento [] listaEmpreendimentosEstatica = null;

	/// <summary>
	/// Carrega a lista dos empreendimentos e a coloca em um dicionario
	/// </summary>
	void Awake()
	{
		if (_carregado) return;

		//Empreendimento [] listaEmpreendimentos = GerenciadorCarregamento.CarregarEmpreendimentos();
		//Empreendimento [] listaEmpreendimentos = Jogador.lista

		if (listaEmpreendimentosEstatica == null)
		{
			// TODO: Ajeitar para não mostrar que já está no nível máximo
			//listaEmpreendimentosEstatica = GerenciadorCarregamento.CarregarEmpreendimentos();
			listaEmpreendimentosEstatica = FuncoesEmpreendimentos.CriarEmpreendimentos();
		}

		dicionarioEmpreendimentos.Clear();
		//foreach(Empreendimento e in listaEmpreendimentos)
		foreach(Empreendimento e in listaEmpreendimentosEstatica)
		{
			e.Reiniciar();
			e.Carregar();
			dicionarioEmpreendimentos.Add(e.identificador, e);
		}

		_carregado = true;

	}

	/// <summary>
	/// Salva os empreendimentos
	/// </summary>
	static public void Salvar()
	{
		/*
		foreach(string s in dicionarioEmpreendimentos.Keys)
		{
			dicionarioEmpreendimentos[s].Salvar();
		}
		//*/

		foreach(Empreendimento e in dicionarioEmpreendimentos.Values)
		{
			e.Salvar();
		}
	}

	static public void Reiniciar()
	{
		/*
		foreach(string s in dicionarioEmpreendimentos.Keys)
		{
			dicionarioEmpreendimentos[s].Reiniciar();
		}
		//*/

		foreach(Empreendimento e in dicionarioEmpreendimentos.Values)
		{
			e.Reiniciar();
		}
	}

	/// <summary>
	/// Verifica se a lista com os emprendimentos contem o empreendimento requisitado no nivel correto.
	/// </summary>
	/// <returns><c>true</c>, se possuir o empreendimento no nivel correto, <c>false</c> caso contrario.</returns>
	/// <param name="identificador">Identificador do empreemento requisitado.</param>
	/// <param name="nivel">Nivel requisitado.</param>
	static public bool TemRequisito(string identificador, int nivel)
	{
		if (dicionarioEmpreendimentos.ContainsKey(identificador))
		{
			if (dicionarioEmpreendimentos[identificador].nivel >= nivel)
			{
				return true;
			}
		}
		return false;
	}

	/// <summary> 
	/// Compra o empreendimento selecionado, se este atender aos pre-requisitos.
	/// </summary>
	public void Comprar()
	{
		UI_Empreendimento.ComprarEstatico();
	}

	/// <summary>
	/// Verifica se o jogador possui o empreendimento relacionado ao easter egg
	/// </summary>
	/// <returns><c>true</c>, if empreendimento tiver nivel 1 ou mais, <c>false</c> otherwise.</returns>
	/// <param name="id">Identificador do empreendimento</param>
	static public bool VerificarEmpreendimentoEasterEgg(string id)
	{
		if (dicionarioEmpreendimentos.ContainsKey(id))
		{
			Debug.Log ("Nivel empreendimento "+id+": "+dicionarioEmpreendimentos[id].nivel);
			if (dicionarioEmpreendimentos[id].nivel > 0)
			{
				return true;
			}
		}
		return false;
	}
}


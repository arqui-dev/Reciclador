using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GerenciadorEmpreendimentos : MonoBehaviour
{
	public static Dictionary<string,Empreendimento> dicionarioEmpreendimentos =
		new Dictionary<string, Empreendimento>();

	static Empreendimento [] listaEmpreendimentos;

	static bool _carregado = false;
	public static bool carregado { get { return _carregado; } }

	void Awake()
	{
		listaEmpreendimentos = 	
			GerenciadorCarregamento.CarregarEmpreendimentos();

		foreach(Empreendimento e in listaEmpreendimentos)
		{
			dicionarioEmpreendimentos.Add(e.identificador, e);
		}

		_carregado = true;
	}

	public static Empreendimento PegarEmpreendimento(int indice)
	{
		if (listaEmpreendimentos != null &&
		    indice >= listaEmpreendimentos.Length)

		{
			return null;
		}

		return listaEmpreendimentos[indice];
	}
}


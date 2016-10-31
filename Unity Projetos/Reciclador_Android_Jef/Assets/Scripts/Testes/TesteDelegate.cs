using UnityEngine;
using System.Collections;

public class TesteDelegate : MonoBehaviour
{

	delegate int NumeroTeste();
	delegate int NumeroTeste2(int nivel);

	int NumTeste()
	{
		return 1;
	}

	int NumTeste2(int nivel)
	{
		return nivel;
	}

	// Use this for initialization
	void Start ()
	{
		NumeroTeste numTeste = NumTeste;
		NumeroTeste2 numTeste2 = NumTeste2;
		Debug.Log("Número Teste = " + numTeste.Invoke());
		Debug.Log("Número Teste 2 = " + numTeste2.Invoke(18));
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}


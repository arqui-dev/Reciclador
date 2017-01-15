using UnityEngine;
using System.Collections;

public class FuncoesCamera : MonoBehaviour
{
	static public float relacaoAltura = 1;

	float alturaBase = 1080;

	int altura = 0;
	int largura = 0;

	void Awake ()
	{
		altura = Screen.height;
		largura = Screen.width;

		relacaoAltura = altura / alturaBase;
	}
	
	void Update ()
	{
		if (altura != Screen.height ||
		    largura != Screen.width)
		{
			OrganizarTela();
			altura = Screen.height;
			largura = Screen.width;

			relacaoAltura = altura / alturaBase;
		}
	}

	void OrganizarTela()
	{
		Debug.Log ("Mudou resolução, de ("+
		           largura+"x"+altura+") para ("+
		           Screen.width+"x"+Screen.height+").");
	}
}

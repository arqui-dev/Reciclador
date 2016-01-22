using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObjTextoFlutuante : MonoBehaviour
{
	public enum Movimento {
		Reto, Arco, Aleatorio
	}

	public Movimento	movimento	= Movimento.Reto;
	public Vector2 []	_direcao	= {Vector2.up};
	public Vector2		gravidade	= Vector2.down;
	public float 	velocidade		= 1;
	public float	duracao			= 1;

	float	tempo		= 0;
	Color 	cor			= Color.white;
	float	alfa		= 1;
	bool	pronto 		= false;

	Text	texto;

	Vector2 direcao = Vector2.up;

	static Transform	localTextos = null;

	public void Criar(string t, Vector2 posicao)
	{
		if (localTextos == null)
		{
			localTextos = GameObject.Find("_Textos").transform;
		}
		transform.SetParent(localTextos, false);

		transform.position = posicao;

		if (_direcao.Length > 0)
		{
			direcao = _direcao[Random.Range(0, _direcao.Length)];
		}

		if (movimento == Movimento.Aleatorio)
		{
			movimento = Movimento.Reto;
			if (Random.Range(0,2) > 0)
			{
				movimento = Movimento.Arco;
			}
		}

		texto	= GetComponent<Text>();

		cor		= texto.color;
		alfa	= cor.a;

		texto.text = t;

		//direcao.Normalize();

		tempo	= Time.time + duracao;

		pronto	= true;
	}

	void Update ()
	{
		if (!pronto) return;

		Mover ();

		cor.a = ((tempo - Time.time) / (duracao * 0.5f)) * alfa;
		texto.color = cor;

		if (Time.time > tempo)
		{
			Destroy (gameObject);
		}
	}

	void Mover()
	{
		switch(movimento)
		{
		case Movimento.Reto: MoverReto(); break;
		case Movimento.Arco: MoverArco(); break;
		}
	}

	void MoverArco()
	{
		transform.Translate(direcao * velocidade * Time.deltaTime);
		direcao += gravidade * Time.deltaTime;
	}

	void MoverReto()
	{
		transform.Translate(direcao * velocidade * Time.deltaTime);
	}
}


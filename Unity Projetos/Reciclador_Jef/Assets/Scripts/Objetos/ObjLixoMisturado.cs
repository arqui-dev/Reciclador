using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObjLixoMisturado : MonoBehaviour
{
	LixoMisturado lixoMisturado;

	Text	texto;

	bool	adicionar	= false;
	bool 	remover		= false;

	bool 	brilhandoJuncao		= false;
	bool	brilhandoApanhou	= false;

	float	tempoBrilhoAtual		= 0;
	float 	tempoPararBrilho		= 0;
	float	duracaoBrilhoAcertado	= 0.33f;
	float 	velBrilhoJuntando		= 3;
	float 	velBrilhoAcertado		= 15;
	int 	direcaoBrilho			= 1;

	Color	corBrilhoJuntando	= Color.yellow;
	Color	corBrilhoAcertado	= Color.red;
	Color	corNomal			= Color.white;

	Image	imagem;

	Vector2	tamanho;

	void Awake()
	{
		tamanho			= GetComponent<RectTransform>().sizeDelta;
		imagem			= GetComponent<Image>();
		corNomal		= imagem.color;
		texto			= GetComponentInChildren<Text>();
		lixoMisturado	= new LixoMisturado(
			ObjEmpreendimentos.nivelMinimoLixo);
		AjeitarTexto();
		Adicionar();
	}

	void Update()
	{
		VerificarBrilhos();

		if (remover)
		{
			Remover();
		}
		else if (adicionar)
		{
			Adicionar();
		}
	}

	void VerificarBrilhos()
	{
		Color cor = corNomal;

		if (brilhandoApanhou)
		{
			tempoBrilhoAtual += velBrilhoAcertado * Time.deltaTime;
			if (tempoBrilhoAtual > 1)
			{
				tempoBrilhoAtual = 0;
				direcaoBrilho = -direcaoBrilho;
			}

			if (direcaoBrilho == 1)
			{
				cor = Color.Lerp(
					corNomal, 
					corBrilhoAcertado, 
					tempoBrilhoAtual);
			}
			else
			{
				cor = Color.Lerp(
					corBrilhoAcertado,
					corNomal,
					tempoBrilhoAtual);
			}

			if (Time.time > tempoPararBrilho)
			{
				brilhandoApanhou = false;
			}
		}
		else if (brilhandoJuncao)
		{
			tempoBrilhoAtual += velBrilhoJuntando * Time.deltaTime;
			if (tempoBrilhoAtual > 1)
			{
				tempoBrilhoAtual = 0;
				direcaoBrilho = -direcaoBrilho;
			}
			
			if (direcaoBrilho == 1)
			{
				cor = Color.Lerp(
					corNomal, 
					corBrilhoJuntando, 
					tempoBrilhoAtual);
			}
			else
			{
				cor = Color.Lerp(
					corBrilhoJuntando,
					corNomal,
					tempoBrilhoAtual);
			}
		}

		imagem.color = cor;
	}

	void AjeitarTexto()
	{
		texto.text = "Monstro\nNível "+lixoMisturado.nivel+
			"\nHP "+lixoMisturado.vida;
	}

	void Quebrar()
	{
		for (int i = 0; i < Nivel() + 1; i++)
		{
			ObjGerenciadorLixo.CriarReciclavel();
		}

		ObjGerenciadorLixo.CriarXP(XP(), transform);
		Remover();
	}

	void Adicionar()
	{
		if (!ObjGerenciadorLixo.Adicionar(this))
		{
			adicionar = true;
		}
		else
		{
			adicionar = false;
		}
	}

	void Remover()
	{
		if (!ObjGerenciadorLixo.Remover(this))
		{
			remover = true;
		}
		else
		{
			remover = false;
			Destruir();
		}
	}

	void Destruir()
	{
		Destroy(gameObject);
	}

	public void ReceberDano(int dano, int redutorArmadura = 0)
	{
		tempoPararBrilho	= Time.time + duracaoBrilhoAcertado;
		brilhandoApanhou	= true;

		bool derrotado		=
			lixoMisturado.ReceberDano(dano, redutorArmadura);
		
		AjeitarTexto();

		ObjGerenciadorLixo.CriarTextoDano(dano, transform);

		Som.Tocar(Som.Tipo.AcertarMonstro);
		
		if (derrotado)
		{
			Quebrar();
		}
	}

	public void Segurar()
	{
		Transform pai = transform.parent;
		transform.SetParent(null, false);
		transform.SetParent(pai, false);
		//transform.position = Input.mousePosition;
	}

	// TODO JECA
	bool movendo = false;
	public void Mover()
	{
		if (ObjGerenciadorLixo.NoMeioDeUmaJuncao(this))
		{
			return;
		}

		movendo = true;
		transform.position = Input.mousePosition;
		ObjGerenciadorLixo.ManterNaArea(transform, tamanho);
	}
	
	public void Tocado()
	{
		if (!movendo || true)
		{
			ReceberDano(Jogador.dano, Jogador.quebrarArmadura);
		}
		movendo = false;
	}

	public bool EstaNivelMaximo()
	{
		return lixoMisturado.estaNivelMaximo;
	}

	public int Nivel()
	{
		return lixoMisturado.nivel;
	}

	public int XP()
	{
		return Nivel() * 3;
	}

	public void BrilharJuntar()
	{
		brilhandoJuncao = true;
	}

	public void PararBrilhoJuntar()
	{
		brilhandoJuncao = false;
	}

	public bool PodeJuntar(ObjLixoMisturado outro)
	{
		if (this == outro) return false;
		return lixoMisturado.PodeFundir(outro.lixoMisturado);
	}

	public void Juntar(ObjLixoMisturado outro)
	{
		int novoNivel = this.Nivel() + outro.Nivel();

		Vector2 pos = (Vector2) transform.position;

		this.Remover();
		outro.Remover();

		ObjGerenciadorLixo.CriarLixoEstatico(novoNivel, pos);

		//lixoMisturado.Fundir(outro.lixoMisturado);
		//AjeitarTexto();
		//Debug.Log ("Aumentar tamanho e afins");
		//PararBrilhoJuntar();

	}
}



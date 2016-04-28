using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObjReciclavel : MonoBehaviour
{
	public GameObject objPontuacao;

	public Reciclavel.Tipo tipo	= Reciclavel.Tipo.Aleatorio;
	public Sprite [] sprites;

	public float	tempoParaSumir = 15;

	public long 	pontuacaoConcedidaAoSumir	= 1;
	public int		xpPerdidaAoSumir			= 1;

	Reciclavel reciclavel;
	
	Text	texto;

	bool 	reciclando	= false;

	bool	adicionar	= false;
	bool 	remover		= false;

	float 	tempoSumir	= 0;
	bool	sumindo		= false;
	
	bool 	brilhandoJuncao		= false;
	bool	brilhandoReciclar	= false;
	
	float	tempoBrilhoAtual		= 0;
	int 	direcaoBrilho			= 1;

	static float 	demoraParaSumir		= 5;

	static float 	velBrilhoJuntando	= 3;
	static float 	velBrilhoReciclando	= 7;

	static Color	corBrilhoJuntando	= Color.gray;
	static Color	corBrilhoReciclar	= Color.black;

	Color	corNomal			= Color.white;
	
	Image	imagem;
	
	Vector2	tamanho;

	int easteregg = -1;

	public void EasterEgg(int easter = 1)
	{
		tipo = Reciclavel.Tipo.EasterEgg;
		easteregg = easter;
	}

	public int TipoEaster()
	{
		return reciclavel.EasterEgg();
	}
	
	void Awake()
	{
		tamanho			= GetComponent<RectTransform>().sizeDelta;
		imagem			= GetComponent<Image>();
		imagem.sprite	= sprites[Random.Range(0, sprites.Length)];
		corNomal		= imagem.color;
		texto			= GetComponentInChildren<Text>();
		reciclavel		= new Reciclavel(tipo, easteregg);
		tipo			= reciclavel.tipo;
		AjeitarTexto();
		Adicionar();

		tempoSumir		= Time.time + tempoParaSumir;
	}
	
	void Update()
	{
		VerificarBrilhos();

		if (reciclando == false)
		{
			if (Time.time > tempoSumir)
			{
				if (sumindo == false)
				{
					brilhandoJuncao = true;
					sumindo = true;
					tempoSumir = Time.time + demoraParaSumir;
				}
				else
				{
					Sumir();
				}
			}

		}
		
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
		
		if (brilhandoReciclar)
		{
			tempoBrilhoAtual += velBrilhoReciclando * Time.deltaTime;
			if (tempoBrilhoAtual > 1)
			{
				tempoBrilhoAtual = 0;
				direcaoBrilho = -direcaoBrilho;
			}
			
			if (direcaoBrilho == 1)
			{
				cor = Color.Lerp(
					corNomal, 
					corBrilhoReciclar, 
					tempoBrilhoAtual);
			}
			else
			{
				cor = Color.Lerp(
					corBrilhoReciclar,
					corNomal,
					tempoBrilhoAtual);
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
		if (texto != null)
		{
			texto.text = "R\n"+tipo;
		}
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

			//if (reciclando == false)
			Destruir();
		}
	}

	void Sumir()
	{
		long pontos = pontuacaoConcedidaAoSumir;

		if (tipo == Reciclavel.Tipo.EasterEgg)
		{
			pontos = 0;
		}

		Jogador.Pontuar(pontos);

		Instantiate<GameObject>(objPontuacao).
			GetComponent<ObjTextoFlutuante>().Criar(
				"$"+pontos, transform.position);

		Som.Tocar(Som.Tipo.SumirReciclavel);

		if (xpPerdidaAoSumir > 0)
		{
			ObjGerenciadorLixo.CriarXP(
				-xpPerdidaAoSumir, transform, false);
		}

		Remover();
	}
	
	public void Destruir()
	{
		Destroy(gameObject);
	}

	public void Segurar()
	{
		if (tipo == Reciclavel.Tipo.EasterEgg)
		{
			if (GerenciadorEmpreendimentos.VerificarEmpreendimentoEasterEgg(idEaster()))
			{
				ObjGerenciadorLixo.CriarXP(xpPerdidaAoSumir, transform);

				Instantiate<GameObject>(objPontuacao).
					GetComponent<ObjTextoFlutuante>().Criar(
						"$"+pontuacaoConcedidaAoSumir, transform.position);

				brilhandoReciclar = true;
				reciclando = true;
				
				Som.Tocar(Som.Tipo.AcertarLixeira);
				
				Remover();
				return;
			}
		}

		if (reciclando) return;
		Transform pai = transform.parent;
		transform.SetParent(null, false);
		transform.SetParent(pai, false);
		//transform.position = Input.mousePosition;
	}

	string idEaster()
	{
		return Dados.idsEmpreendimentoEasterEggs[TipoEaster() - 1];
	}
	
	public void Mover()
	{
		if (reciclando) return;
		transform.position = Input.mousePosition;
	}
	
	public void Soltar()
	{
		Debug.Log("Nome: " + gameObject.name + " - Reciclando = "+reciclando);
		if (reciclando) return;
		ObjGerenciadorLixo.VerificarSoltarReciclavel(this, tamanho);
	}
	
	public void Reciclar(Transform pai, float duracao)
	{
		transform.SetParent(pai, true);
		brilhandoReciclar = true;
		reciclando = true;

		Som.Tocar(Som.Tipo.AcertarLixeira);

		Remover();
	}
}


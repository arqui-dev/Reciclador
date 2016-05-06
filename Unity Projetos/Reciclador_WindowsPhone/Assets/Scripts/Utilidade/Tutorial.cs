using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Tutorial : MonoBehaviour {

	private Queue<string> mensagens;
	private List<GameObject> areasTexto;

	public float tempoLer = 10.0f;

    public GameObject lixeiraAzul;
    public GameObject lixeiraVerde;
    public GameObject lixeiraAmarela;
    public GameObject lixeiraVermelha;
    public GameObject monstro;
	public GameObject areaPapel;
	public GameObject areaVidro;
	public GameObject areaMetal;
	public GameObject areaPlastico;

	public GameObject txtEsquerda;
	public GameObject txtDireita;
	public GameObject txtMeio;
	public GameObject HUD;
	public GameObject empreendimentos;
	public GameObject XP;
	public GameObject Achievements;
	public GameObject Config;

	public GameObject jornal;
	public GameObject[] reciclaveisEtapa4;
	public GameObject[] reciclaveisEtapa5;
	public GameObject lata;

	public GameObject dinheiroHUD;

	public GameObject painelEmpreendimentos;

	public GameObject painelConquistas;

	private float cont = 0.0f;
	private int step = 1;
	private bool primeiroPasso = true;
	private bool esperarAcao = true;
	private bool etapaComAcao = false;

	private GameObject objetoDaAcao;

	public ObjGerenciadorLixo ogl;

	static public bool pararReciclagem = false;
	static public bool reciclarInstantaneo = false;

	static public bool esperarTentarJogarNaLixeira = false;

	static public bool esperandoFechar = false;

	public static int quantidadeReciclados = 0;

	float proximoTempo = 0;

	static public bool esperarDerrotarMonstro = false;

	static bool abriuEmpreendimentos = false;

	static public bool desabilitarDanoEmMonstros = false;

	static public bool juntando = false;

	private bool jaAtribuiTempo = false;

	static public bool easterEgg = false;

	static public bool completouConquista = false;

	void Start ()
	{
		painelConquistas.SetActive(false);

		pararReciclagem = false;
		reciclarInstantaneo = false;
		esperarTentarJogarNaLixeira = false;
		esperandoFechar = false;
		quantidadeReciclados = 0;
		proximoTempo = 0;
		esperarDerrotarMonstro = false;

		abriuEmpreendimentos = false;
		desabilitarDanoEmMonstros = false;

		cont = 0.0f;
		step = 1;
		primeiroPasso = true;
		esperarAcao = true;
		etapaComAcao = false;
		jaAtribuiTempo = false;

		completouConquista = false;

		juntando = false;

		easterEgg = false;

		objetoDaAcao = null;

		areasTexto = new List<GameObject> ();

		areasTexto.Add (txtDireita);
		areasTexto.Add (txtEsquerda);
		areasTexto.Add (txtMeio);

		mensagens = new Queue<string> ();

		mensagens.Enqueue ("Olá, bem vindo ao mundo da reciclagem, eu sou a lixeira de coleta de papel, " +
			"mas pode me chamar de azul.");
		mensagens.Enqueue ("Sabia que jornais, caixas de papelão, folhas de caderno e embalagens de leite " +
			"são papeis recicláveis.");
		mensagens.Enqueue ("Olhe um jornal! Arraste e solte-o sobre a lixeira de coleta de papel, para " +
			"que ele seja encaminhado para a reciclagem.");
		mensagens.Enqueue ("Olá, eu sou o Verdão. Sou responsável pela coleta de vidro. Todos os cacos, " +
			"copos, garrafas e frascos de vidro arraste para mim.");
		mensagens.Enqueue ("Oi, eu sou a lixeira para coleta de metal, a Amarela. Latas, tampinhas, " +
			"ferro velho e materiais de aluminio são meu trabalho.");
		mensagens.Enqueue ("Ops! Parece que a Amarela atingiu seu limite, vamos ter de esperar a reciclagem." +
			" Aliás sou o Vermelho, garrafas pets e outros plasticos são comigo.");
		mensagens.Enqueue ("Quando um lixo é reciclado ele gera <color=#008000ff>$</color>, olhe o menu acima de nós.");
		mensagens.Enqueue ("Esta é a sua interface de usuário, vamos conhece-la melhor ? Primeiro esse é o seu " +
			"dinheiro, que você ganha por reciclar o lixo.");
		mensagens.Enqueue ("Com <color=#008000ff>$</color> você pode comprar e melhorar empreendimentos sustentáveis." +
			"Clique no botão acima para conhecermos os empreendimentos");
		mensagens.Enqueue ("Grrr! Somos monstros saco lixo, quando o lixo não é separado e reciclado surgimos, nos  acumulamos " +
			"e ficamos cada vez mais fortes. Muahahahaha!");
		mensagens.Enqueue ("Não se preocupe, basta ir clicando sobre os monstros para separar o lixo se você não deixar eles " +
			"se acumularem, eles não serão um problema");
		mensagens.Enqueue ("Ao derrotar um monstro saco de lixo, ele irá deixar materiais que você poderá reciclar.");
		mensagens.Enqueue ("Muahahaha! Quanto mais o tempo passa mais nos acumulamos e maiores ficamos, sempre que 2 de nós " +
			"se juntam, ficamos mais forte");
		mensagens.Enqueue ("Lixo acumulado é um problema, vamos derrotar esses para aumentarmos o nível de sustentabilidade " +
			"e liberarmos novos empreendimentos");
		mensagens.Enqueue ("Uma <color=#ffa500ff>lâmpada</color>, ela não é reciclável. Para tratar alguns resíduos precisamos " +
			"de empreendimentos especificos. Clique na <color=#ffa500ff>lâmpada</color> para tratar dela.");
		mensagens.Enqueue ("Parabéns, agora você está pronto para ser sustentável. Isso é uma <color=#0000ffff>CONQUISTA</color>. " +
			"Existem várias conquistas que você pode buscar em sua empreitada.");
		mensagens.Enqueue ("E lembre, caso você tenha alguma dúvida, nos estaremos prontos para te ensinar. Basta acesso o menu de " +
			"<color=#ffa500ff>OPÇÕES</color>. Agora sim, vamos começar.");
		mensagens.Enqueue ("");

		Jogador.LimparCenario();
	}
		
	void Update () {
		cont += Time.deltaTime;

		switch (step) {
		case 1:
			if (primeiroPasso) {
				reciclarInstantaneo = true;
				Debug.Log("Step "+step);
				Jogador.tutorialRodando = true;
				ativarIcones ("azul");
				activeTxtArea ("esquerda");
			}
			break;
		case 2:
			if (primeiroPasso)
			{
				Debug.Log("Step "+step);
				areaPapel.SetActive (true);
			}
			break;
		case 3:
			if (primeiroPasso) {
				Debug.Log("Step "+step);
				etapaComAcao = true;
				objetoDaAcao = jornal;
				objetoDaAcao.SetActive (true);
			}
			
			if (objetoDaAcao == null) {
				esperarAcao = true;
				cont = tempoLer;
			}
			break;
		case 4:
			if (primeiroPasso) {
				etapaComAcao = true;
				Debug.Log("Step "+step);
				ativarIcones ("verde");
				areaVidro.SetActive (true);
				activeTxtArea ("direita");
				foreach (GameObject go in reciclaveisEtapa4) {
					go.SetActive (true);
				}
				objetoDaAcao = reciclaveisEtapa4[0];
				quantidadeReciclados = 0;
			}

			if (quantidadeReciclados >= 4) {
				esperarAcao = true;
				cont = tempoLer;
			}

			break;
		case 5:
			if (primeiroPasso) {
				reciclarInstantaneo = false;
				quantidadeReciclados = 0;
				etapaComAcao = true;
				areaMetal.SetActive (true);
				//areaPlastico.SetActive (true);
				ativarIcones ("amarelo");
				activeTxtArea ("esquerda");
				//*
				foreach (GameObject go in reciclaveisEtapa4) {
					if (go != null) {
						go.SetActive (false);
					}
				}
				foreach (GameObject go in reciclaveisEtapa5) {
					go.SetActive (true);
				}
				//*/
				objetoDaAcao = reciclaveisEtapa5[0];
				pararReciclagem = true;
			}

			if (quantidadeReciclados >= 3) {
				esperarAcao = true;
				cont = tempoLer;
			}

			break;
		case 6:
			if (primeiroPasso) {
				esperarTentarJogarNaLixeira = true;
				etapaComAcao = true;

				areaPlastico.SetActive (true);
				ativarIcones ("vermelho");
				activeTxtArea ("direita");
				foreach (GameObject go in reciclaveisEtapa5) {
					if (go != null) {
						go.SetActive (false);
					}
				}
				lata.SetActive (true);
				objetoDaAcao = lata;
			}

			if (objetoDaAcao == false && pararReciclagem == true) 
			{
				pararReciclagem = false;
			}

			if (pararReciclagem == false)
			{
				esperarAcao = true;
				cont = tempoLer;
			}
			// ajeitar
			break;
		case 7:
			if (primeiroPasso) {
				etapaComAcao = true;
				HUD.SetActive (true);
				ativarIcones ("vermelho,amarelo");
				activeTxtArea ("meio");
				proximoTempo = Time.time + 
					areaMetal.GetComponent<ObjAreaReciclavel>().duracaoReciclagem;
			}

			if (Time.time > proximoTempo)
			{
				esperarAcao = true;
				cont = tempoLer;
			}
			break;
		case 8:
			if (primeiroPasso) {
				etapaComAcao = false;
				//HUD.SetActive (true);
				dinheiroHUD.SetActive(true);
				ativarIcones ("azul");
				activeTxtArea ("esquerda");
			}
			break;
		case 9:
			if (primeiroPasso) {
				etapaComAcao = true;
				ativarIcones ("verde");
				activeTxtArea ("direita");
				empreendimentos.SetActive (true);
				//painelEmpreendimentos.SetActive(true);
				objetoDaAcao = painelEmpreendimentos;
				abriuEmpreendimentos = false;
			}

			if (abriuEmpreendimentos == true && !objetoDaAcao.activeSelf)
			{
				esperarAcao = true;
				cont = tempoLer;
			}

			if (objetoDaAcao.activeSelf)
			{
				abriuEmpreendimentos = true;
			}

			break;
		case 10:
			if (primeiroPasso) {
				etapaComAcao = false;
				desabilitarDanoEmMonstros = true;
				ObjGerenciadorLixo.CriarLixoEstatico(1, ObjGerenciadorLixo.instancia.transform.position);
				ativarIcones ("monstro");
				activeTxtArea ("esquerda");
			}
			break;
		case 11:
			if (primeiroPasso) {
				desabilitarDanoEmMonstros = false;
				etapaComAcao = true;
				esperarDerrotarMonstro = true;
				ativarIcones ("vermelho");
				activeTxtArea ("direita");
			}

			if (!esperarDerrotarMonstro)
			{
				esperarAcao = true;
				cont = tempoLer;
			}
			break;
		case 12:
			if (primeiroPasso) {
				etapaComAcao = true;
				ativarIcones ("verde");
				activeTxtArea ("direita");
				quantidadeReciclados = 0;
			}

			if (quantidadeReciclados >= 2)
			{
				esperarAcao = true;
				cont = tempoLer;
			}
			break;
		case 13:
			if (primeiroPasso) {
				esperarAcao = true;
				desabilitarDanoEmMonstros = true;
				Vector2 pos = ObjGerenciadorLixo.instancia.transform.position;
				pos.x -= Screen.width / 4;
				ObjGerenciadorLixo.CriarLixoEstatico(1, pos);
				pos.x += Screen.width / 2;
				ObjGerenciadorLixo.CriarLixoEstatico(1, pos);
				ativarIcones ("monstro");
				activeTxtArea ("esquerda");

				juntando = true;
				jaAtribuiTempo = false;

				ObjGerenciadorLixo.AtribuirProximaJuncao(3);
			}

			if (juntando == false)
			{
				if (jaAtribuiTempo == false)
				{
					proximoTempo = Time.time + 1;
					jaAtribuiTempo = true;
				}
				else if (Time.time > proximoTempo)
				{
					esperarAcao = true;
					cont = tempoLer;
				}
			}
			break;
		case 14:
			if (primeiroPasso) {
				etapaComAcao = true;
				esperarDerrotarMonstro = true;
				ativarIcones ("verde");
				activeTxtArea ("direita");
				desabilitarDanoEmMonstros = false;
				juntando = false;
				jaAtribuiTempo = false;
			}

			if (esperarDerrotarMonstro == false)
			{
				esperarAcao = true;
				cont = tempoLer;
			}
			break;
		case 15:
			if (primeiroPasso) {
				etapaComAcao = true;
				ObjGerenciadorLixo.CriarReciclavelEasterEgg(1, false);
				ativarIcones ("vermelho");
				activeTxtArea ("direita");
				easterEgg = true;
			}

			if (easterEgg == false)
			{
				esperarAcao = true;
				cont = tempoLer;
			}
			break;
		case 16:
			if (primeiroPasso) {
				completouConquista = true;
				etapaComAcao = true;
				Achievements.SetActive (true);
				ativarIcones ("azul");
				activeTxtArea ("esquerda");
				painelConquistas.SetActive(true);
			}

			if (painelConquistas.activeSelf == false)
			{
				esperarAcao = true;
				cont = tempoLer;
			}
			break;
		case 17:
			etapaComAcao = false;
			Config.SetActive(true);
			break;
		case 18:
			Jogador.tutorialRodando = false;
			Jogador.tutorialCompleto = true;
			Jogador.pegouCanvasReset = false;
			ObjGerenciadorLixo.instancia = null;
			Application.LoadLevel("Jogo");
			break;
		}



		if (primeiroPasso) {
			if (etapaComAcao)
				esperarAcao = false;
			primeiroPasso = false;
			GameObject areaTexto = returnActive ();
			areaTexto.GetComponent<Text> ().text = mensagens.Dequeue();
		}

		if (cont >= tempoLer && esperarAcao) {
			esperarAcao = true;
			primeiroPasso = true;
			cont = 0.0f;
			step += 1;
		}
	}

	private GameObject returnActive () {
		foreach (GameObject go in areasTexto) {
			if (go.active) {
				return go;
			}
		}
		return null;
	}

	private void activeTxtArea (string area) {
		if (area.Equals ("esquerda")) {
			txtEsquerda.SetActive (true);
			txtDireita.SetActive (false);
			txtMeio.SetActive (false);
		} else {
			if (area.Equals ("direita")) {
				txtEsquerda.SetActive (false);
				txtDireita.SetActive (true);
				txtMeio.SetActive (false);
			} else {
				if (area.Equals ("meio")) {
					txtEsquerda.SetActive (false);
					txtDireita.SetActive (false);
					txtMeio.SetActive (true);
				} else {
					Debug.Log ("Erro ao ativar area de texto");
				}
			}
		}
	}

	private void ativarIcones (string icones) {
		string[] icons = icones.Split (',');
		deactiveAll ();

		foreach (string c in icons) {
			switch (c) {
			case "azul":
				lixeiraAzul.SetActive (true);
				break;
			case "verde":
				lixeiraVerde.SetActive (true);
				break;
			case "amarelo":
				lixeiraAmarela.SetActive (true);
				break;
			case "vermelho":
				lixeiraVermelha.SetActive (true);
				break;
			case "monstro":
				monstro.SetActive (true);
				break;
			}
		}
	}
		
	private void deactiveAll () {
		lixeiraAzul.SetActive (false);
		lixeiraAmarela.SetActive (false);
		lixeiraVerde.SetActive (false);
		lixeiraVermelha.SetActive (false);
		monstro.SetActive (false);
	}
}

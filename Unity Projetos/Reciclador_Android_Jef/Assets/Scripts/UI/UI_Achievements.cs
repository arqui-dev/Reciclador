using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

class BaseadoDinheiro : AchievementBase {

	private int dinheiroNecessario;

	public BaseadoDinheiro (string nome, string descricao,
		int dinheiro) : base (nome, descricao) {

		this.dinheiroNecessario = dinheiro;
	}

	public bool Won () {
		if ((int)Jogador.pontos >= dinheiroNecessario) {
			Unlocked = true;
			UI_Mensanges.AdicionarMensagem ("Você desbloqueou a conquista " + Nome);
			return true;
		} else {
			return false;
		}
	}

	public int GetDinheiroNecessario {
		get {
			return dinheiroNecessario;
		}
	}
}

class BaseadoMateriais : AchievementBase {

	private int materiaisNecessario;

	public BaseadoMateriais (string nome, string descricao,
		int materiais) : base (nome, descricao) {

		this.materiaisNecessario = materiais;
	}

	public bool Won () {
		if (ObjAreaReciclavel.numMateriaisReciclados >= materiaisNecessario) {
			Unlocked = true;
			UI_Mensanges.AdicionarMensagem ("Você desbloqueou a conquista " + Nome);
			return true;
		} else {
			return false;
		}
	}

	public int GetMateriaisNecessario {
		get {
			return materiaisNecessario;
		}
	}
}

class BaseadoNivel : AchievementBase {

	private int nivelNecessario;

	public BaseadoNivel (string nome, string descricao,
		int nivelNecessario) : base (nome, descricao) {

		this.nivelNecessario = nivelNecessario;
	}

	public bool Won () {

		if (!Unlocked && Jogador.tutorialRodando && 
			Tutorial.completouConquista)
		{
			Unlocked = true;
			UI_Mensanges.AdicionarMensagem ("Você desbloqueou a conquista " + Nome);
			Debug.Log ("Você desbloqueou a conquista " + Nome);
			return true;
		}

		if (Jogador.nivel > nivelNecessario) {
			Unlocked = true;
			UI_Mensanges.AdicionarMensagem ("Você desbloqueou a conquista " + Nome);
			Debug.Log ("Você desbloqueou a conquista " + Nome);
			return true;
		} else {
			return false;
		}
	}

	public int GetMateriaisNecessario {
		get {
			return nivelNecessario;
		}
	}
}

public interface tiposAchievements {}
	
public class UI_Achievements : MonoBehaviour
{
	static UI_Achievements instancia = null;

	private List<BaseadoDinheiro> baseadoDinheiro;
	private List<BaseadoNivel> baseadoNivel;
	private List<BaseadoMateriais> baseadoMateriais;

	private BaseadoDinheiro bemIntencionado;
	private BaseadoDinheiro naoFoiUmaAposta;
	private BaseadoDinheiro capitalistaLimpo;
	private BaseadoDinheiro genioPlayboyFilantropoBilionario;

	private BaseadoMateriais catadorDeLatinhas;
	private BaseadoMateriais colecionadorDeTranqueiras;
	private BaseadoMateriais rainhaDaSucata;
	private BaseadoMateriais capitaoPlaneta;

	public GameObject botaoAchievements;
	public RectTransform localDosBotoesAchievements;
	public GameObject localDescricaoAchievements;
	public float tamanhoBotao = 90;

	private float espacoEntreBotoes = 10.0f;

	void Start () {
		if (instancia == null)
		{
			instancia = this;
		}

		Criar ();

		CarregarDados();

		VerificarUnlock();

		//Carregar ();

		GetComponentInParent<PopupConquistas>().gameObject.SetActive(false);
	}

	void Criar()
	{
		baseadoDinheiro = new List<BaseadoDinheiro> ();
		baseadoNivel = new List<BaseadoNivel> ();
		baseadoMateriais = new List<BaseadoMateriais>();

		BaseadoNivel bn = new BaseadoNivel("Eureka!!!", "Encontre um material não reciclável",101);
		baseadoNivel.Add(bn);
		
		bemIntencionado = new BaseadoDinheiro ("Bem-intencionado", "Acumule $10.000,00", 10000);
		naoFoiUmaAposta = new BaseadoDinheiro ("Não foi uma aposta!", "Acumule $100.000,00", 100000);
		capitalistaLimpo = new BaseadoDinheiro ("Capitalista Limpo", "Acumule $500.000,00", 500000);
		genioPlayboyFilantropoBilionario = new BaseadoDinheiro ("Gênio, playboy, filantropo e milionário",
		                                                        "Acumule $1.000.000,00.", 1000000);
		baseadoDinheiro.Add (bemIntencionado);
		baseadoDinheiro.Add (naoFoiUmaAposta);
		baseadoDinheiro.Add (capitalistaLimpo);
		baseadoDinheiro.Add (genioPlayboyFilantropoBilionario);
		
		catadorDeLatinhas = new BaseadoMateriais ("Catador de latinha", "Recicle 100 materiais", 100);
		colecionadorDeTranqueiras = new BaseadoMateriais ("Colecionador de tranqueiras", "Recicle 300 materiais", 300);
		rainhaDaSucata = new BaseadoMateriais ("Rainha da Sucata", "Recicle 500 materiais", 500);
		capitaoPlaneta = new BaseadoMateriais ("Capitão Planeta", "Recicle 1000 materiais.", 1000);
		baseadoMateriais.Add (catadorDeLatinhas);
		baseadoMateriais.Add (colecionadorDeTranqueiras);
		baseadoMateriais.Add (rainhaDaSucata);
		baseadoMateriais.Add (capitaoPlaneta);
	}

	void OnEnable()
	{
		if (instancia != null)
		{
			if (Jogador.tutorialRodando)
			{
				VerificarUnlock();
			}

			Carregar ();
		}
	}
		
	void Update () {
		//VerificarUnlock();
	}

	public static void VerificarUnlockEstatico()
	{
		if (instancia)
			instancia.VerificarUnlock();
	}

	void SalvarDados()
	{
		foreach (BaseadoDinheiro bd in baseadoDinheiro) {
			int unlocked = bd.Unlocked ? 1 : 0;
			PlayerPrefs.SetInt(bd.Nome, unlocked);
		}
		
		foreach (BaseadoNivel be in baseadoNivel) {
			int unlocked = be.Unlocked ? 1 : 0;
			PlayerPrefs.SetInt(be.Nome, unlocked);
		}
		
		foreach (BaseadoMateriais bm in baseadoMateriais) {
			int unlocked = bm.Unlocked ? 1 : 0;
			PlayerPrefs.SetInt(bm.Nome, unlocked);
		}
	}

	void CarregarDados()
	{
		foreach (BaseadoDinheiro bd in baseadoDinheiro) {
			if (PlayerPrefs.HasKey(bd.Nome))
			{
				bool unlocked = PlayerPrefs.GetInt(bd.Nome) == 1;
				bd.Unlocked = unlocked;
				//Debug.Log ("Carregou "+bd.Nome+" - Unlocked "+bd.Unlocked);
			}
		}

		foreach (BaseadoNivel bd in baseadoNivel) {
			if (PlayerPrefs.HasKey(bd.Nome))
			{
				bool unlocked = PlayerPrefs.GetInt(bd.Nome) == 1;
				bd.Unlocked = unlocked;
			}
		}

		foreach (BaseadoMateriais bd in baseadoMateriais) {
			if (PlayerPrefs.HasKey(bd.Nome))
			{
				bool unlocked = PlayerPrefs.GetInt(bd.Nome) == 1;
				bd.Unlocked = unlocked;
			}
		}
	}

	static public bool CarregarEstatico()
	{
		if (!instancia)
			return false;

		instancia.CarregarDados();

		return true;
	}

	static public void SalvarEstatico()
	{
		if (instancia)
			instancia.SalvarDados();
	}

	void VerificarUnlock()
	{
		foreach (BaseadoDinheiro bd in baseadoDinheiro) {
			if (!bd.Unlocked)
				bd.Won ();
		}

		foreach (BaseadoNivel be in baseadoNivel) {
			if (!be.Unlocked)
				be.Won ();
		}

		foreach (BaseadoMateriais bm in baseadoMateriais) {
			if (!bm.Unlocked)
				bm.Won ();
		}
	}

	void Carregar()
	{
		float y = -espacoEntreBotoes;

		foreach (AchievementBase ab in baseadoNivel) {

			GameObject novoBotao = 
				Instantiate<GameObject>(botaoAchievements);

			RectTransform rectTransformNovoBotao = 
				novoBotao.GetComponent<RectTransform>();

			novoBotao.GetComponent<AchievementBase> ().Nome = ab.Nome;
			novoBotao.GetComponent<AchievementBase> ().Descricao = ab.Descricao;

			novoBotao.GetComponentInChildren<Text> ().text = ab.Nome;

			rectTransformNovoBotao.position = new Vector2(0, y);
			rectTransformNovoBotao.SetParent(
				localDosBotoesAchievements, false);

			y -= tamanhoBotao + espacoEntreBotoes;

			if (ab.Unlocked)
			{
				novoBotao.GetComponent<Image>().color = Color.white;
			}
			else
			{
				novoBotao.GetComponent<Image>().color = Color.gray;
			}
		}

		foreach (AchievementBase ab in baseadoDinheiro) {
			
			GameObject novoBotao = 
				Instantiate<GameObject>(botaoAchievements);

			RectTransform rectTransformNovoBotao = 
				novoBotao.GetComponent<RectTransform>();

			novoBotao.GetComponent<AchievementBase> ().Nome = ab.Nome;
			novoBotao.GetComponent<AchievementBase> ().Descricao = ab.Descricao;

			novoBotao.GetComponentInChildren<Text> ().text = ab.Nome;

			rectTransformNovoBotao.position = new Vector2(0, y);
			rectTransformNovoBotao.SetParent(
				localDosBotoesAchievements, false);

			y -= tamanhoBotao + espacoEntreBotoes;

			if (ab.Unlocked)
			{
				novoBotao.GetComponent<Image>().color = Color.white;
			}
			else
			{
				novoBotao.GetComponent<Image>().color = Color.gray;
			}
		}



		foreach (AchievementBase ab in baseadoMateriais) {

			GameObject novoBotao = 
				Instantiate<GameObject>(botaoAchievements);

			RectTransform rectTransformNovoBotao = 
				novoBotao.GetComponent<RectTransform>();

			novoBotao.GetComponent<AchievementBase> ().Nome = ab.Nome;
			novoBotao.GetComponent<AchievementBase> ().Descricao = ab.Descricao;

			novoBotao.GetComponentInChildren<Text> ().text = ab.Nome;

			rectTransformNovoBotao.position = new Vector2(0, y);
			rectTransformNovoBotao.SetParent(
				localDosBotoesAchievements, false);

			y -= tamanhoBotao + espacoEntreBotoes;

			if (ab.Unlocked)
			{
				novoBotao.GetComponent<Image>().color = Color.white;
			}
			else
			{
				novoBotao.GetComponent<Image>().color = Color.gray;
			}
		}

		localDosBotoesAchievements.sizeDelta = 
			new Vector2(localDosBotoesAchievements.sizeDelta.x, -y);
	}

	#if UNITY_EDITOR
	public void atualizarDescricaoDebug (string nome, string descricao, bool unlockedTest) {
		foreach (BaseadoDinheiro tp in baseadoDinheiro) {
			if (tp.Nome.Equals(nome)) {
				if (unlockedTest) {
					string novaDescricao = descricao + " Conquistado!";
					Debug.Log (novaDescricao);
					localDescricaoAchievements.GetComponent<Text> ().text = novaDescricao;
					break;
				} else {
					localDescricaoAchievements.GetComponent<Text> ().text = descricao;
					break;
				}
			}
		}

		foreach (BaseadoNivel tp in baseadoNivel) {
			if (tp.Nome.Equals(nome)) {
				if (unlockedTest) {
					string novaDescricao = descricao + "\n" + "Conquistado!";
					localDescricaoAchievements.GetComponent<Text> ().text = novaDescricao;
					break;
				} else {
					localDescricaoAchievements.GetComponent<Text> ().text = descricao;
					break;
				}
			}
		}

		foreach (BaseadoMateriais tp in baseadoMateriais) {
			if (tp.Nome.Equals(nome)) {
				if (unlockedTest) {
					string novaDescricao = descricao + "\n" + "Conquistado!";
					localDescricaoAchievements.GetComponent<Text> ().text = novaDescricao;
					break;
				} else {
					localDescricaoAchievements.GetComponent<Text> ().text = descricao;
					break;
				}
			}
		}
	}
	#endif

	#if !UNITY_EDITOR
	public void atualizarDescricao (string nome, string descricao) {
		foreach (BaseadoDinheiro tp in baseadoDinheiro) {
			if (tp.Nome.Equals(nome)) {
				if (tp.Unlocked) {
					localDescricaoAchievements.GetComponent<Text> ().text = descricao + "\n" + "Conquistado!";
					break;
				} else {
					localDescricaoAchievements.GetComponent<Text> ().text = descricao;
					break;
				}
			}
		}

		foreach (BaseadoNivel tp in baseadoNivel) {
			if (tp.Nome.Equals(nome)) {
				if (tp.Unlocked) {
					localDescricaoAchievements.GetComponent<Text> ().text = descricao + "\n" + "Conquistado!";
					break;
				} else {
					localDescricaoAchievements.GetComponent<Text> ().text = descricao;
					break;
				}
			}
		}

		foreach (BaseadoMateriais tp in baseadoMateriais) {
			if (tp.Nome.Equals(nome)) {
				if (tp.Unlocked) {
					localDescricaoAchievements.GetComponent<Text> ().text = descricao + "\n" + "Conquistado!";
					break;
				} else {
					localDescricaoAchievements.GetComponent<Text> ().text = descricao;
					break;
				}
			}
		}
	}
	#endif
}
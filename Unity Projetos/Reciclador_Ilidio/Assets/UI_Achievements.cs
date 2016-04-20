using UnityEngine;
using UnityEngine.UI;
using System.Collections;

abstract class AchievementsBase {
	private string Nome;
	private string Descricao;
	private bool Unlocked = false;

	protected AchievementsBase (string nome, string descricao) {
		this.Nome = nome;
		this.Descricao = descricao;
	}

	public string GetNome {
		get {
			return Nome;
		}
	}

	public string GetDescricao {
		get {
			return Descricao;
		}
	}

	public bool GetUnlocked {
		get {
			return Unlocked;
		}
	}

	public abstract bool Won ();
}

class BaseadoDinheiro : AchievementsBase {

	private int dinheiroNecessario;

	public BaseadoDinheiro (string nome, string descricao,
		int dinheiro) : base (nome, descricao) {

		this.dinheiroNecessario = dinheiro;
	}

	public override bool Won () {
		if ((int)Jogador.pontos >= dinheiroNecessario) {
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

class BaseadoMateriais : AchievementsBase {

	private int materiaisNecessario;

	public BaseadoMateriais (string nome, string descricao,
		int materiais) : base (nome, descricao) {

		this.materiaisNecessario = materiais;
	}

	public override bool Won () {
		if (ObjAreaReciclavel.numMateriaisReciclados >= materiaisNecessario) {
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


public class UI_Achievements : MonoBehaviour
{
	private AchievementsBase[] Achievements;

	private BaseadoDinheiro bemIntencionado;

	void Start () {
		Achievements = new AchievementsBase[12];

		bemIntencionado = new BaseadoDinheiro ("Bem-intencionado", "Acumule $10.000,00", 10001);
		Achievements [0] = bemIntencionado;
	}

	void Update () {
		Debug.Log (bemIntencionado.Won());
	}
}
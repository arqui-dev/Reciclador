using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AchievementBase : MonoBehaviour {
	public string Nome;
	public string Descricao;
	public bool Unlocked;

	public AchievementBase (string nome, string descricao) {
		this.Nome = nome;
		this.Descricao = descricao;
	}

	public void mudarDescricao () {
		GameObject.FindGameObjectWithTag ("UI_Achievements").GetComponent<UI_Achievements> ().atualizarDescricao (Nome, Descricao);
	}
}

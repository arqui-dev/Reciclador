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
		#if UNITY_EDITOR
		//Debug.Log("Conquista " + Nome + ": " + Unlocked);
		GameObject.FindGameObjectWithTag ("UI_Achievements").GetComponent<UI_Achievements> ().atualizarDescricaoDebug (Nome, Descricao, Unlocked);
		#endif

		#if !UNITY_EDITOR
		GameObject.FindGameObjectWithTag ("UI_Achievements").GetComponent<UI_Achievements> ().atualizarDescricao (Nome, Descricao);
		#endif
	}

}

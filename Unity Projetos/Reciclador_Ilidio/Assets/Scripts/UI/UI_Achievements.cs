using UnityEngine;
using UnityEngine.UI;
using System.Collections;

class Achievements {
	private string title;
	private string description;

	public void setAchievement (string title, string description) {
		this.title = title;
		this.description = description;
	}

	public bool Won () {
	
	}

	public string GetTitle () {
		return title;
	}

	public string GetDescription () {
		return description;
	}
}

public class UI_Achievements : Achievements
{
	private static Achievements[] achievementsList;

	void Start () {
		achievementsList = new Achievements[12];

		achievementsList [0] = new Achievements ();
		achievementsList [0].setAchievement ("Bem-intencionado", "Acumule $10.000,00");
		achievementsList[0].Wo
	}



}


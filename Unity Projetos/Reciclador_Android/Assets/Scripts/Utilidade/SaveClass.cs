using UnityEngine;
using System.Collections;

public class SaveClass: MonoBehaviour
{
	public void Save()
	{
		Jogador.SalvarTudo();
	}

	public void Load()
	{
		Jogador.CarregarTudo();
	}
}


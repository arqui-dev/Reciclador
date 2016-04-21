using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUD_BarraXP : MonoBehaviour
{
	Image imagem;

	void Awake()
	{
		imagem = GetComponent<Image>();
	}

	void Update ()
	{
		float escalaBarraXP = 
			(float) Jogador.xpAtual / (float) Jogador.xpProximoNivel;
		if (escalaBarraXP > 1) escalaBarraXP = 1;
		if (escalaBarraXP < 0) escalaBarraXP = 0;

		imagem.transform.localScale = new Vector3(
			escalaBarraXP, 
			imagem.transform.localScale.y,
			imagem.transform.localScale.z);
	}
}


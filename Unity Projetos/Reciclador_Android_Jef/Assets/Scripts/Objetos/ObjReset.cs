using UnityEngine;
using System.Collections;

public class ObjReset : MonoBehaviour
{
	public GameObject telaReset;

	public void AbrirTelaReset()
	{
		telaReset.SetActive(true);
	}

	public void ResetarJogo()
	{
		Jogador.Resetar();
		telaReset.SetActive(false);
		gameObject.SetActive(false);
	}

	public void CancelarReset()
	{
		telaReset.SetActive(false);
	}
}


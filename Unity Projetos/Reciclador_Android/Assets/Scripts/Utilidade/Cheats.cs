using UnityEngine;
using System.Collections;

public class Cheats : MonoBehaviour
{

	public void Nv1()
	{
		Jogador.CheatNivel1();
	}

	public void NvMais(int quantidade)
	{
		Jogador.CheatNivelSomar(quantidade);
	}

	public void DinheiroZero()
	{
		Jogador.CheatDinheiroZero();
	}

	public void DinheiroMais(int quantidade)
	{
		Jogador.CheatDinheiroSomar(quantidade);
	}

	public void ReciclarMateriais(int quantidade)
	{
		Jogador.CheatReciclarMateriais(quantidade);
	}

	public void ReciclarZerar()
	{
		Jogador.CheatReciclarZerar();
	}

	public void Reset()
	{
		Jogador.Reset();
	}

	public void AdicionarEasterEggAleatorio()
	{
		ObjGerenciadorLixo.CriarReciclavelEasterEgg();
	}

	public void AdicionarEasterEgg(int ee)
	{
		ObjGerenciadorLixo.CriarReciclavelEasterEgg(ee, false);
	}

	public void AdicionarLixoAleatorioNormal()
	{
		ObjGerenciadorLixo.SimularMonstroDerrotado();
	}

	public void SaltarTutorial()
	{
		Jogador.tutorialRodando = false;
		Jogador.pegouCanvasReset = false;
		ObjGerenciadorLixo.instancia = null;
		Jogador.tutorialCompleto = true;

		Application.LoadLevel("Jogo");
	}
}


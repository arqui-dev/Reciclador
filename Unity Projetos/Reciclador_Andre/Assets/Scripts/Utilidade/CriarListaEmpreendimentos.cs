using UnityEngine;
using System.Collections;

/// <summary>
/// Cria os botões dos empreendimentos no popup de empreendimentos.
/// </summary>
public class CriarListaEmpreendimentos : MonoBehaviour
{
	/// <summary>	/// Prefab com o botão base de empreendimento.	/// </summary>
	public GameObject botaoEmpreendimento;

	/// <summary>
	/// O local onde serão colocados os botões de empreendimentos.	/// </summary>
	public RectTransform localDosBotoesDeEmpreendimento;

	/// <summary>	/// O espaço vertical, em pixels da resolução base (1080p), entre os botões.	/// </summary>
	public float espacoEntreBotoes = 10;

	/// <summary>	/// O tamanho vertical do botão, em pixels da resolução base.	/// </summary>
	public float tamanhoBotao = 90;

	/// <summary>	/// Controla o carregamento, para mostrar apenas quando os empreendimentos forem carregados corretamente.	/// </summary>
	bool pronto = false;

	/// <summary>
	/// Verifica se os empreendimentos já foram carregados e criados.
	/// </summary>
	void Update()
	{
		if (!pronto && GerenciadorEmpreendimentos.carregado)
		{
			Carregar();
			pronto = true;
		}
	}

	/// <summary>
	/// Cria os botões dos empreendimentos no local adequado.
	/// </summary>
	void Carregar()
	{
		float y = -espacoEntreBotoes;

		foreach (Empreendimento e in 
		         GerenciadorEmpreendimentos.
		         dicionarioEmpreendimentos.Values)
		{
			GameObject novoBotao = 
				Instantiate<GameObject>(botaoEmpreendimento);

			RectTransform rectTransformNovoBotao = 
				novoBotao.GetComponent<RectTransform>();

			UI_Empreendimento UI_EmpreendimentoNovoBotao = 
				novoBotao.GetComponent<UI_Empreendimento>();

			rectTransformNovoBotao.position = new Vector2(0, y);
			rectTransformNovoBotao.SetParent(
				localDosBotoesDeEmpreendimento, false);

			UI_EmpreendimentoNovoBotao.empreendimento = e;

			y-= tamanhoBotao + espacoEntreBotoes;
		}

		localDosBotoesDeEmpreendimento.sizeDelta = 
			new Vector2(localDosBotoesDeEmpreendimento.sizeDelta.x, -y);
	}
}


using UnityEngine;
using System.Collections;

public class MensagensAleatorias : MonoBehaviour
{
	string [] mensagens = {
		"A reciclagem é uma prática, uma oportunidade e uma obrigação de cada cidadão consciente. Preservar a natureza é a única forma de mantermos vida neste planeta!",
		"Para contribuir com a melhora do nosso ecossistema é preciso Reduzir, Reutilizar, Reciclar e Repensar.",
		"Fique atento quando comprar uma embalagem que é reciclável pois dependendo do material, ela poderá ir para o lixo comum no final do processo.",
		"A presença de lixo não reciclável no processo de reciclagem é um problema pois pode prejudicar a qualidade do produto final reciclado ou até quebrar a máquina que processa o material." ,
		"“Somos a primeira geração que está sentindo os problemas do efeito estufa e a última a poder agir.” -Barack Obama",
		"Os vidros não são biodegradáveis e permanecem na natureza cerca de dez mil anos.",
		"Uma tonelada de plástico reciclado economiza 130 quilos de petróleo, que é um recurso fóssil e não renovável.",
		"Reciclar uma tonelada de alumínio gasta 95% menos energia e poupa extração de 5 toneladas de minério.",
		"Para cada garrafa de vidro reciclada é economizada energia elétrica suficiente para acender uma lâmpada de 100 watts durante quatro horas.",
		"Para cada tonelada de vidro reciclado, gasta-se menos 70% do que se gastaria para se fabricar mais vidro.",
		"Usa-se areia para a fabricação do vidro, assim, com a reciclagem, o processo de extração de areia em rios diminui. Esse ponto é muito importante, porque essa extração devasta matas, provoca erosões e assoreamento de rios.",
		"Lembre-se que pilhas descartadas sem critério prejudicam drasticamente o meio ambiente. Que tal beber agua com mercúrio?",
		"Uma tonelada de papel reciclado poupa 22 árvores, consome 71% menos energia elétrica que representa uma redução de 74% na emissão de poluentes atmosféricos.",
		"A energia economizada para reciclar uma única lata de refrigerante é o suficiente para manter uma televisão ligada por três horas.",
		"Com a reciclagem economiza-se água, energia elétrica e evita-se a extração de matéria-prima da natureza.",
		"Procure agentes ambientais e associações para descartar os materiais que não são reciclados!",
		"Fraldas descartáveis levam cerca de 500 anos para se decompor.",
		"O isopor é um produto sintético proveniente do petróleo que leva cerca de 150 anos para ser totalmente degradado na natureza.",
		"Lembre-se que seringas usadas podem ferir e contaminar os agentes recicladores, pessoas comuns, animais e até você! Informe-se na farmácia ou no hospital como fazer o descarte de uma seringa!",
		"Materiais não recicláveis são aqueles que não podem ser reutilizados após transformação química ou física, porém muitos materiais não são reciclados no Brasil apenas por ainda não existir tecnologia para o tipo específico de material.",
		"Fique atento quando comprar uma embalagem que é reciclável pois dependendo do material, ela poderá ir para o lixo comum no final do processo.",
		"A presença de lixo não reciclável no processo de reciclagem é um problema pois pode prejudicar a qualidade do produto final reciclado ou até quebrar a máquina que processa o material."
	};

	public float tempoEntreMensagens = 180;
	public float duracaoMensagens = 10;

	float tempoProximaMensagem = 0;

	void Mensagem(int mensagem = -1)
	{
		if (mensagem < 0 || mensagem >= mensagens.Length)
		{
			mensagem = Random.Range(0, mensagens.Length);
		}

		UI_Mensanges.AdicionarMensagem(mensagens[mensagem], duracaoMensagens);

		Debug.Log(mensagens[mensagem]);
	}

	void VerificarProximaMensagem()
	{
		if (Time.time > tempoProximaMensagem)
		{
			tempoProximaMensagem = Time.time + tempoEntreMensagens;
			Mensagem();
		}
	}
	
	void Awake()
	{
		tempoProximaMensagem = Time.time + tempoEntreMensagens / 2;
	}

	void Update()
	{
		VerificarProximaMensagem();
	}
}


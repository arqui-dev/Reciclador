using UnityEngine;
using System.Collections;

public class EasterEggLampada : IValoresEmpreendimentos
{
	
	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}


	//**************************************************************
	string 	nome			= "Máquina descaracterização de lâmpadas";
	string 	identificador	= "lampada";
	public int ID()
	{
		return 0;
	}

	public string Nome()
	{
		return nome;
	}

	public string Identificador()
	{
		return identificador;
	}

	public int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// a cada 10 segundos
	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno = 10;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		float retorno = 0.5f;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		return retorno;
	}

	public float []	ValorDeVenda(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}
	//

	// REQUISITOS
	public long		Custos(int nivel)
	{
		if (nivel > 0) return 0;
		long retorno = 1200;
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		if (nivel > 0) return -1;	// deixar essa linha para todos os eastereggs, pra considerar nível máximo e não deixar comprar mais
		int retorno = 9;
		return retorno;
	}

	public string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		retorno += "A descontaminação das lâmpadas é feita no local da coleta, com uma máquina portátil, e após isso ela é triturada. filtrada e aspirada, garantindo a destinação correta dos passivos ambientais.";
		return retorno;
	}
}

public class EasterEggMadeira : IValoresEmpreendimentos
{
	

	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}


	//**************************************************************
	string 	nome			= "Máquina de trituração de madeira";
	string 	identificador	= "madeira";

	public int ID()
	{
		return 1;
	}
	public string Nome()
	{
		return nome;
	}

	public string Identificador()
	{
		return identificador;
	}

	public int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// a cada 10 segundos
	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno = 10;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		float retorno = 0.5f;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		return retorno;
	}

	public float []	ValorDeVenda(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}
	//

	// REQUISITOS
	public long		Custos(int nivel)
	{
		if (nivel > 0) return 0;
		long retorno = 4800;
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		if (nivel > 0) return -1;	// deixar essa linha para todos os eastereggs, pra considerar nível máximo e não deixar comprar mais
		int retorno = 12;
		return retorno;
	}

	public string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		retorno += "A madeira é triturada e acaba por ser enviada ao reuso na fabricação de placas aglomeradas que são utilizadas por indústrias de móveis. Parte por ser encaminhada ao aquecimento dos fornos e caldeiras, bem como no fabrico de papéis e celulose.";
		return retorno;
	}
}
public class EasterEggIsopor : IValoresEmpreendimentos
{
	public int ID()
	{
		return 2;
	}

	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}


	//**************************************************************
	string 	nome			= "Usina de reciclagem de isopor";
	string 	identificador	= "isopor";
	public string Nome()
	{
		return nome;
	}

	public string Identificador()
	{
		return identificador;
	}

	public int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// a cada 10 segundos
	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno = 10;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		float retorno = 0.5f;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		return retorno;
	}

	public float []	ValorDeVenda(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}
	//

	// REQUISITOS
	public long		Custos(int nivel)
	{
		if (nivel > 0) return 0;
		long retorno = 20700;
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		if (nivel > 0) return -1;	// deixar essa linha para todos os eastereggs, pra considerar nível máximo e não deixar comprar mais
		int retorno = 23;
		return retorno;
	}

	public string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		retorno += "Após a coleta seletiva o isopor passa pela máquina de reciclagem, e é compactado em fardos, que passam por um segundo processo de reciclagem, onde o isopor é triturado, derretido, granulado e volta a ser matéria-prima de novos produtos.";
		return retorno;
	}
}
public class EasterEggFraldas : IValoresEmpreendimentos
{
	public int ID()
	{
		return 3;
	}

	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}


	//**************************************************************
	string 	nome			= "Máquina de reciclagem de fraldas";
	string 	identificador	= "fraldas";
	public string Nome()
	{
		return nome;
	}

	public string Identificador()
	{
		return identificador;
	}

	public int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// a cada 10 segundos
	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno = 10;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		float retorno = 0.5f;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		return retorno;
	}

	public float []	ValorDeVenda(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}
	//

	// REQUISITOS
	public long		Custos(int nivel)
	{
		if (nivel > 0) return 0;
		long retorno = 86400;
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		if (nivel > 0) return -1;	// deixar essa linha para todos os eastereggs, pra considerar nível máximo e não deixar comprar mais
		int retorno = 36;
		return retorno;
	}

	public string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		retorno += "Após a coleta de objetos como fraldas e absorventes, a máquina esteriliza seus componentes e então os transforma em novos produtos, como madeira plástica, telhas e materiais de absorção.";
		return retorno;
	}
}
public class EasterEggLataTinta : IValoresEmpreendimentos
{
	public int ID()
	{
		return 4;
	}

	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}


	//**************************************************************
	string 	nome			= "Usina de Blendagem";
	string 	identificador	= "lata_tinta";
	public string Nome()
	{
		return nome;
	}

	public string Identificador()
	{
		return identificador;
	}

	public int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// a cada 10 segundos
	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno = 10;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		float retorno = 0.5f;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		return retorno;
	}

	public float []	ValorDeVenda(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}
	//

	// REQUISITOS
	public long		Custos(int nivel)
	{
		if (nivel > 0) return 0;
		long retorno = 220500;
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		if (nivel > 0) return -1;	// deixar essa linha para todos os eastereggs, pra considerar nível máximo e não deixar comprar mais
		int retorno = 49;
		return retorno;
	}

	public string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		retorno += "Na blendagem, o resíduo é totalmente descaracterizado e misturado junto a outros resíduos que recebemos de forma a produzir uma mistura líquido ou sólido com alto poder calorífero (blend).";
		return retorno;
	}
}
public class EasterEggPatoBorracha : IValoresEmpreendimentos
{
	public int ID()
	{
		return 5;
	}

	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}


	//**************************************************************
	string 	nome			= "Triturador de borracha";
	string 	identificador	= "pato";
	public string Nome()
	{
		return nome;
	}

	public string Identificador()
	{
		return identificador;
	}

	public int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// a cada 10 segundos
	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno = 10;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		float retorno = 0.5f;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		return retorno;
	}

	public float []	ValorDeVenda(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}
	//

	// REQUISITOS
	public long		Custos(int nivel)
	{
		if (nivel > 0) return 0;
		long retorno = 585000;
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		if (nivel > 0) return -1;	// deixar essa linha para todos os eastereggs, pra considerar nível máximo e não deixar comprar mais
		int retorno = 65;
		return retorno;
	}

	public string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		retorno += "O processo de reciclagem de borrachas é realizado através do triturador de pneu e borracha e tem se tornado cada vez mais importante e lucrativo no mundo.";
		return retorno;
	}
}
public class EasterEggSeringa : IValoresEmpreendimentos
{
	public int ID()
	{
		return 6;
	}
	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}


	//**************************************************************
	string 	nome			= "Usina de Incineração";
	string 	identificador	= "seringa";
	public string Nome()
	{
		return nome;
	}

	public string Identificador()
	{
		return identificador;
	}

	public int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// a cada 10 segundos
	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno = 10;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		float retorno = 0.5f;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		return retorno;
	}

	public float []	ValorDeVenda(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}
	//

	// REQUISITOS
	public long		Custos(int nivel)
	{
		if (nivel > 0) return 0;
		long retorno = 1411200;
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		if (nivel > 0) return -1;	// deixar essa linha para todos os eastereggs, pra considerar nível máximo e não deixar comprar mais
		int retorno = 84;
		return retorno;
	}

	public string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		retorno += "Lixo hospitalar não pode ser reciclado, porém, existem tratamentos melhores que o descarte, como a incineração. Durante a incineração não destruídos além do objeto, todos os microorganismos que podem existir nele.";
		return retorno;
	}
}
public class EasterEggPneu : IValoresEmpreendimentos
{
	public int ID()
	{
		return 7;
	}
	// Não altera nada
	public int 		NivelMinimoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public float		VelocidadeAparecerLixo(int nivel)
	{
		float retorno = 0;
		return retorno;
	}

	// NÃO IMPLEMENTADO, pode deixar como zero mesmo
	public int 		SeparacaoAutomatica(int nivel)
	{
		// Esse empreendimento não mexe com esse atributo
		int retorno = 0;
		return retorno;
	}


	//**************************************************************
	string 	nome			= "Fábrica de móveis de pneu";
	string 	identificador	= "pneu";
	public string Nome()
	{
		return nome;
	}

	public string Identificador()
	{
		return identificador;
	}

	public int		TaxaSeparacaoLixo(int nivel)
	{
		int retorno = 0;
		return retorno;
	}

	// a cada 10 segundos
	public long		DinheiroPorTempo(int nivel)
	{
		int v = nivel;
		if (v <= 0) return 0;
		long retorno = 10;
		return retorno;
	}

	public float	AumentoXP(int nivel)
	{
		float retorno = 0.5f;
		return retorno;
	}

	//
	public int []	LimiteRecicladoras(int nivel)
	{
		// Papel, Vidro, Metal, Plástico
		int [] retorno = {0,0,0,0};
		return retorno;
	}

	public float []	ValorDeVenda(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}

	public float []	VelocidadeReciclagem(int nivel)
	{
		float [] retorno = {0f,0f,0f,0f};
		return retorno;
	}
	//

	// REQUISITOS
	public long		Custos(int nivel)
	{
		if (nivel > 0) return 0;
		long retorno = 3088800;
		return retorno;
	}

	public int		NivelRequisito(int nivel)
	{
		if (nivel > 0) return -1;	// deixar essa linha para todos os eastereggs, pra considerar nível máximo e não deixar comprar mais
		int retorno = 99;
		return retorno;
	}

	public string 		Descricao(int nivel)
	{
		// Descrição pode chamar outras funções, para mostrar valores exatos
		string retorno = "";
		retorno += "Os pneus pode ser reutilizados entre muitas outras coisas, em tiras usadas em móveis estofados, o que além de preservar o meio ambiente ajuda na geração de centenas de empregos.";
		return retorno;
	}
}
﻿using UnityEngine;
using System.Collections;

public class ArquivoStrings : MonoBehaviour
{
	static public string empreendimentos =
@"## Modelo de um arquivo de empreendimentos
## Linhas que comecem com ## (dois sharp/hashtag/sustenido/jogo-da-velha) são comentários e serão descartadas pelo parser.
		## Apenas linhas inteiras podem ser comentadas, não se deve usar os ## em outro local senão no começo da linha (podem haver espaços e tabulações normalmente)

## Linhas em branco serão descartadas pelo parser.

## O esqueleto de um empreendimento tem a seguinte forma:

##empreendimento		::identificador_do_empreendimento
	##nome			::Versão amigável do nome real do empreendimento.
	##descricao		::Resumo do empreendimento. Se o nome não for o nome real, colocar aqui.
	##nivel maximo	::Número inteiro, entre 1 e 6, representando o nível máximo deste empreendimento.
	
	##nivel empreendimento				::Número inteiro, entre 1 e nível máximo, representando o nível que será descrito a seguir. Cada nível deve ser representado, um abaixo do outro, com todas as características.
		##atributos						::(Nada precisa ser escrito aqui, é apenas um separador)
			##velocidade reciclagem		::Quatro valores inteiros, entre zero e cem (0-100), separados por ##vírgulas, cada um representando uma das quatro recicladoras, na ordem: papel, vidro, metal e plástico. Esse valor indica o quanto a velocidade de reciclagem, em porcentagem, da recicladora em questão, será aumentado.
			##valor venda					::Valor inteiro extra do valor de venda dos itens na recicladora em questão. Quatro valores inteiros, entre zero e cem (0-100), separados por vírgulas, cada um representando uma das quatro recicladoras, na ordem: papel, vidro, metal e plástico.
			##experiencia					::Valor inteiro indicando a porcentagem extra de experiência que o jogador ganha de todas as fontes.
			##velocidade aparecer lixo	::Velocidade extra que reduz o tempo de aparição de lixos no cenário.
			##limite fila					::Quatro valores inteiros, entre zero e cem (0-100), separados por vírgulas, cada um representando uma das quatro recicladoras, na ordem: papel, vidro, metal e plástico. Esses valores aumentam o limite da fila de reciclagem que cada recicladora tem.
			##lixo minimo					::Nível mínimo de novos lixos que surgem. Valor inteiro.
			##dinheiro gerado				::Dinheiro gerado por tempo para o jogador. Valor inteiro.
			##separacao automatica		::Dano causado automaticamente a todos os lixos no cenário. Valor inteiro. (Ainda não implementado)
			##poder jogador				::Dano extra causado pelo jogador. Valor inteiro.
		##requisitos						::(Nada precisa ser escrito aqui, é apenas um separador)
			##preco						::Custo em $ deste nível do empreendimento. Valor inteiro.
			##nivel sustentabilidade		::Nível mínimo de sustentabilidade que o jogador deve estar para poder comprar esse nível deste empreendimento. Valor inteiro.
			##empreendimentos construidos	::Lista dos empreendimentos necessários, e seus níveis, para poder comprar este nível deste aprimoramento. Cada empreendimento requisitado é separado por  (ponto-e-vírgula), e é descrito da maneira ""identificador : nível"" (sem aspas), sendo que o identificador é um identificador de um empreendimento existente, e o nível é um número inteiro entre 1 e o nível máximo daquele empreendimento. Após o ultimo empreendimento da lista NÃO é colocado o ponto-e-vírgula. Se não houverem emprendimentos requisitados, mesmo assim essa linha deve existir, porém com nada colocado após os ::
##fim empreendimento	::identificador_do_empreendimento

##iníco do arquivo

##_______________________________________________##			
## empreendimentos:
##================================
##Coleta seletiva, aumenta em: 
##(começando do 1, logo nível do monstro = 1+nível do empreendimento) o nível máximo do monstro que pode surgir 
## ##(sim chama lixo mínimo, reclame com o jé)  
##o poder do jogador em +1 por nível do empreendimento 
##libera nos seguintes níveis de sustentábilidade: [1 2 3 6 9 15 24 39 53 92] 
## não possui outros pré-requisitos
##preco 24 * nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::coleta_seletiva
	nome			::Coleta seletiva
	descricao		::Coleta seletiva é a coleta diferenciada de resíduos que foram previamente separados segundo a sua constituição ou composição. Ou seja, resíduos com características similares são selecionados pelo gerador (que pode ser o cidadão, uma empresa ou outra instituição) e disponibilizados para a coleta separadamente. 
	nivel maximo	::10
	##======================================
	nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::
			limite fila					::0,0,0,0
			lixo minimo					::2
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 24
			nivel sustentabilidade		::1
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::
			limite fila					::0,0,0,0
			lixo minimo					::3
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 96
			nivel sustentabilidade		:: 2
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::
			limite fila					::0,0,0,0
			lixo minimo					::4
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 216
			nivel sustentabilidade		:: 3
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento :: 4
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::
			limite fila					::0,0,0,0
			lixo minimo					::5
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::4
		requisitos		::
			preco						:: 576
			nivel sustentabilidade		:: 6
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento :: 5
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::
			limite fila					::0,0,0,0
			lixo minimo					::6
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::5
		requisitos		::
			preco						:: 1080
			nivel sustentabilidade		:: 9
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento :: 6
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::
			limite fila					::0,0,0,0
			lixo minimo					::7
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::6
		requisitos		::
			preco						:: 2160
			nivel sustentabilidade		:: 15
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento :: 7
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::
			limite fila					::0,0,0,0
			lixo minimo					::8
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::7
		requisitos		::
			preco						:: 4032
			nivel sustentabilidade		:: 24
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento :: 8
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::
			limite fila					::0,0,0,0
			lixo minimo					::9
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::8
		requisitos		::
			preco						:: 7488
			nivel sustentabilidade		:: 39
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento ::9
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::
			limite fila					::0,0,0,0
			lixo minimo					::10
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::9
		requisitos		::
			preco						:: 11448
			nivel sustentabilidade		:: 53
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento :: 10
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::
			limite fila					::0,0,0,0
			lixo minimo					::10
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::10
		requisitos		::
			preco						:: 22080
			nivel sustentabilidade		:: 92
			empreendimentos construidos	:: 
fim empreendimento	::
##_______________________________________##
##Associação de catadores, aumenta em: 
##+1 de limite das filas por nível
##+ de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [1 2 7 17 29 41 53 67 79 97] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 32 * nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::catadores
	nome			::Associação de catadores
	descricao		::A cooperativa dos catadores é uma iníciativa social que ajuda não só as pessoas mas o meio ambiente. A reciclagem de papel é uma atividade que diminui tanto o consumo de recursos naturais, quanto sua presença nos aterros sanitários e gera renda para as famílias envolvidas no processo.
	nivel maximo	::10
	##======================================
	nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::0
		requisitos		::
			preco						:: 32
			nivel sustentabilidade		::1
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::2
			velocidade aparecer lixo	:: 2
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 128
			nivel sustentabilidade		:: 2
			empreendimentos construidos	:: 
	##======================================
	nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::3
			velocidade aparecer lixo	:: 2
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 672
			nivel sustentabilidade		:: 7
			empreendimentos construidos	:: 
		##======================================
	nivel empreendimento :: 4
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::4
			velocidade aparecer lixo	:: 2
			limite fila					::4,4,4,4
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 2176
			nivel sustentabilidade		:: 17
			empreendimentos construidos	:: 
		##======================================
	nivel empreendimento :: 5
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::5
			velocidade aparecer lixo	:: 2
			limite fila					::5,5,5,5
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 4640
			nivel sustentabilidade		:: 29
			empreendimentos construidos	:: 
		##======================================
	nivel empreendimento :: 6
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::6
			velocidade aparecer lixo	:: 2
			limite fila					::6,6,6,6
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 7872
			nivel sustentabilidade		:: 41
			empreendimentos construidos	:: 
		##======================================
	nivel empreendimento :: 7
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::7
			velocidade aparecer lixo	:: 2
			limite fila					::7,7,7,7
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 11872
			nivel sustentabilidade		:: 53
			empreendimentos construidos	:: 
		##======================================
	nivel empreendimento :: 8
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::8
			velocidade aparecer lixo	:: 2
			limite fila					::8,8,8,8
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 17152
			nivel sustentabilidade		:: 67
			empreendimentos construidos	:: 
		##======================================
	nivel empreendimento :: 9
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::9
			velocidade aparecer lixo	:: 2
			limite fila					::9,9,9,9
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 22752
			nivel sustentabilidade		:: 79
			empreendimentos construidos	:: 
		##======================================
	nivel empreendimento :: 10
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::10
			velocidade aparecer lixo	:: 2
			limite fila					::10,10,10,10
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 31040
			nivel sustentabilidade		:: 97
			empreendimentos construidos	:: 
fim empreendimento	::
##_________________________________________##
##Atêlie de recicláveis, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [1 4 8 14 22 37 50 65 81 93] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 55* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::atelie_reciclaveis
		nome			::Atêlie de Recicláveis
		descricao		::Recicláveis são reciclado são materiais super versáteis, podendo ser usado para fazer inúmeros novos objetos, como bijuterias, embalagens, jogos, brinquedos entre outros.
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 55
			nivel sustentabilidade		::1
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 440
			nivel sustentabilidade		:: 4
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 1320
			nivel sustentabilidade		:: 8
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::5
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 3080
				nivel sustentabilidade		:: 14
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::6
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 6050
				nivel sustentabilidade		:: 22
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 12210
				nivel sustentabilidade		:: 37
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 19250
				nivel sustentabilidade		:: 50
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 28600
				nivel sustentabilidade		:: 65
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 40095
				nivel sustentabilidade		:: 81
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 51150
				nivel sustentabilidade		:: 93
				empreendimentos construidos	:: 
fim empreendimento	::
##_____________________________________________##
##Ferro Velho, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [11 23 30 42 51 62 68 74 85 91] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 80* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::ferro_velho
		nome			::Ferro Velho
		descricao		::O benefício da reciclagem e do reaproveitamento de sucatas de metal reduz o consumo de energia para a produção do alumínio e outros metais, preserva o meio ambiente e movimenta a economia, gerando empregos e fonte de renda.
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 80
			nivel sustentabilidade		::11
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 3680
			nivel sustentabilidade		:: 23
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 7200
			nivel sustentabilidade		::30
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::5
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 13440
				nivel sustentabilidade		:: 42
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::6
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 20400
				nivel sustentabilidade		:: 51
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 29760
				nivel sustentabilidade		:: 62
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 38080
				nivel sustentabilidade		:: 68
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 47360
				nivel sustentabilidade		:: 74
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 61200
				nivel sustentabilidade		:: 85
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 72800
				nivel sustentabilidade		:: 91
				empreendimentos construidos	:: 
fim empreendimento	::
##__________________________________________________##
##Usina de Reciclagem, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [1 2 5 16 31 43 57 69 82 95] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 48* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::usina_reciclagem
		nome			::Usina de Reciclagem
		descricao		::A reciclagem é uma atividade industrial que diminui o consumo de recursos naturais e impede que estes resíduos acumulem em aterros sanitários e gera renda no processo.
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 48
			nivel sustentabilidade		::1
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 192
			nivel sustentabilidade		:: 2
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 720
			nivel sustentabilidade		:: 5
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::4
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 3072
				nivel sustentabilidade		:: 26
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::5
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 7440
				nivel sustentabilidade		:: 31
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::6
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 12384
				nivel sustentabilidade		:: 43
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 19152
				nivel sustentabilidade		:: 57
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 26496
				nivel sustentabilidade		:: 69
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 35424
				nivel sustentabilidade		:: 82
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 45600
				nivel sustentabilidade		:: 95
				empreendimentos construidos	:: 
fim empreendimento	::
##___________________________________________##
##Prensa de Papel, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [12 20 29 38 46 52 60 66 78 86] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 1000* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::prensa_papel	
		nome			::Prensa de Papel
		descricao		::O papel é enfardado em prensas e depois encaminhado aos aparistas, que classificam as aparas e revendem para as fábricas de papel como matéria-prima.
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 1000
			nivel sustentabilidade		::12
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 40000
			nivel sustentabilidade		:: 20
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 87000
			nivel sustentabilidade		:: 29
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::5
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 144000
				nivel sustentabilidade		:: 36
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::6
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 230000
				nivel sustentabilidade		:: 46
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 312000
				nivel sustentabilidade		:: 52
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 420000
				nivel sustentabilidade		:: 60
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 528000
				nivel sustentabilidade		:: 66
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 702000
				nivel sustentabilidade		:: 78
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 860000
				nivel sustentabilidade		:: 86
				empreendimentos construidos	:: 
fim empreendimento	::
##____________________________________________##
##Oficina de brinquedos reciclados, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [14 23 34 40 49 58 67 76 82 96] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 2000* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::oficina_brinquedos
		nome			::Oficina de Brinquedos Reciclados
		descricao		::Além de ensinar como organizar atividades que ajudem na preservação da natureza, usando materiais recicláveis as oficinas colaboram para a formação de crianças conscientes e no desenvolvimento do potencial artístico.
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 2000
			nivel sustentabilidade		::14
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 92000
			nivel sustentabilidade		:: 23
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 204000
			nivel sustentabilidade		:: 34
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::5
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 320000
				nivel sustentabilidade		:: 40
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::6
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 490000
				nivel sustentabilidade		:: 49
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 696000
				nivel sustentabilidade		:: 58
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 938000
				nivel sustentabilidade		:: 67
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 1216000
				nivel sustentabilidade		:: 76
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 1476000
				nivel sustentabilidade		:: 82
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 1920000
				nivel sustentabilidade		:: 96
				empreendimentos construidos	:: 
fim empreendimento	::
##_____________________________________________##
##Viveiro de garrafas pet, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [16 21 33 39 45 54 65 71 87 98] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 3000* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::viveiro_garrafas
		nome			::Viveiros de Garrafas Pet
		descricao		::As garrafas pet, antes de serem enviadas para reciclagem, podem ser utilizadas em diversas atividades. Uma prática muito comum é a utilização das garrafas pets para produção de mudas. As garrafas são lavadas e cortadas, deixando apenas a parte inferior para o uso (potes). A parte superior é enviada para reciclagem. São inseridos terra e adubo nos potes e em seguida as sementes, que em alguns meses estarão prontas para plantio.
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 3000
			nivel sustentabilidade		::16
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 126000
			nivel sustentabilidade		:: 21
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 297000
			nivel sustentabilidade		:: 33
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::5
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 468000
				nivel sustentabilidade		:: 39
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::6
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 675000
				nivel sustentabilidade		:: 45
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 972000
				nivel sustentabilidade		:: 54
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 1365000
				nivel sustentabilidade		:: 65
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 1704000
				nivel sustentabilidade		:: 71
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 2349000
				nivel sustentabilidade		:: 87
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 2940000
				nivel sustentabilidade		:: 98
				empreendimentos construidos	:: 
fim empreendimento	::
##___________________________________________##
##Triturador de resíduos sólidos, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [17 26 34 41 48 53 63 70 81 92] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 5000* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::triturador_residuos	
		nome			::Triturador de Resíduos Sólidos
		descricao		::As necessidades de grandes áreas para criação de aterros sanitários e elevado volume de lixo produzido pelas metrópoles fez-se necessário a trituração e processamento dos mesmos. Através destes equipamentos pode-se obter redução de volume, separação de materiais que possam virar matéria prima tais como metais, plásticos, papéis entre outros recicláveis envolvidos.
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 5000
			nivel sustentabilidade		::17
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 260000
			nivel sustentabilidade		:: 26
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 510000
			nivel sustentabilidade		:: 34
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::5
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 820000
				nivel sustentabilidade		:: 41
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::6
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 1200000
				nivel sustentabilidade		:: 48
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 1590000
				nivel sustentabilidade		:: 53
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 2205000
				nivel sustentabilidade		:: 63
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 2800000
				nivel sustentabilidade		:: 70
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 3945000
				nivel sustentabilidade		:: 81
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 4600000
				nivel sustentabilidade		:: 92
				empreendimentos construidos	:: 
fim empreendimento	::
##______________________________________________##
##Galeria de arte em metal, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [18 30 37 45 50 58 66 74 80 90] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 10000* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::galeria_arte
		nome			::Galeria de Arte em Metal
		descricao		::Para Esculturas em sucatam os artistas utilizam apenas metal reciclado para sua produção criando peças maravilhosas a partir de materiais descartados.
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 10000
			nivel sustentabilidade		::18
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 600000
			nivel sustentabilidade		:: 30
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 1110000
			nivel sustentabilidade		:: 37
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::5
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 1800000
				nivel sustentabilidade		:: 45
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::6
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 2500000
				nivel sustentabilidade		:: 50
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 3480000
				nivel sustentabilidade		:: 58
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 4620000
				nivel sustentabilidade		:: 66
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 5920000
				nivel sustentabilidade		:: 74
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 7200000
				nivel sustentabilidade		:: 80
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 9000000
				nivel sustentabilidade		:: 90
				empreendimentos construidos	:: 
fim empreendimento	::
##____________________________________________##
##Indústria de reciclagem e processamento, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [50 60 65 70 75 80 85 90 95 99] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 100000* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::industria_reciclagem
		nome			::Indústria de reciclagem e processamento
		descricao		:: Essa indústria vira mais uma página na história da destinação dos resíduos sólidos da cidade. Em vez de enterrar e desperdiçar lixo em aterros sanitários, Você entra na era da indústria da transformação do lixo. Trata-se de uma indústria limpa, que tem grande potencial de atrair outras indústrias de reciclagem para as suas imediações. O estímulo à atividade tende a elevar o preço dos materiais recicláveis, melhorando também a renda dos ecocidadãos.
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 100000
			nivel sustentabilidade		::50
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						::12000000
			nivel sustentabilidade		:: 60
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 19500000
			nivel sustentabilidade		:: 65
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::5
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 28000000
				nivel sustentabilidade		:: 70
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::6
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 37500000
				nivel sustentabilidade		:: 75
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 48000000
				nivel sustentabilidade		:: 80
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 59500000
				nivel sustentabilidade		:: 85
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 72000000
				nivel sustentabilidade		:: 90
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 85500000
				nivel sustentabilidade		:: 95
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 99000000
				nivel sustentabilidade		:: 99
				empreendimentos construidos	:: 
fim empreendimento	::
##_______________________________________________##
##Fábrica de vitrais, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [15 26 39 47 53 60 72 87 92 98] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 50000* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::fabrica_vitrais
		nome			::Fábrica de Vitrais
		descricao		::O vidro pode passar por esse processo infinitas vezes sem perda de qualidade ou pureza do produto. Isso tudo nos mostra a importância da conscientização de todos, para que realizem em suas residências a coleta seletiva do vidro para a sua reciclagem. 
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 50000
			nivel sustentabilidade		::15
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 2600000
			nivel sustentabilidade		:: 26
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 5850000
			nivel sustentabilidade		:: 39
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::5
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 9400000
				nivel sustentabilidade		:: 47
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::6
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 13250000
				nivel sustentabilidade		::53
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 18000000
				nivel sustentabilidade		:: 60
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 25200000
				nivel sustentabilidade		:: 72
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 34800000
				nivel sustentabilidade		:: 87
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 41400000
				nivel sustentabilidade		:: 92
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 49000000
				nivel sustentabilidade		:: 98
				empreendimentos construidos	:: 
fim empreendimento	::
##_____________________________________________##
##Recicladora de alumínio, aumenta em: 
##+1 de limite das filas por nível
##+1 de velocidade para aparecer lixos 
##libera nos seguintes níveis de sustentabilidade: [13 22 29 38 44 56 61 70 79 89] 
## não possui outros pré-requisitos
## +1 de xp por nivel
##preco 25000* nível do empreendimento * nível de sustentabilidade para liberar
##
empreendimento		::recicladora_aluminio
		nome			::Recicladora de alumínio
		descricao		::A lata de alumínio pode ser reciclada infinitas vezes e sempre volta como lata. O benefício da reciclagem reduz o consumo de energia para a produção do alumínio, preserva o meio ambiente e movimenta a economia, gerando empregos e fonte de renda na coleta e promovendo a educação dos cidadãos para o desenvolvimento sustentável. Hoje, 95% das bebidas vendidas em lata no nosso País utilizam a embalagem de alumínio.
 
		nivel maximo	::10
		##======================================
		nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	:: 2
			limite fila					::1,1,1,1
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::1
		requisitos		::
			preco						:: 25000
			nivel sustentabilidade		::13
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 2
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::3
			limite fila					::2,2,2,2
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::2
		requisitos		::
			preco						:: 1100000
			nivel sustentabilidade		:: 22
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 3
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::1
			velocidade aparecer lixo	::4
			limite fila					::3,3,3,3
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::3
		requisitos		::
			preco						:: 2175000
			nivel sustentabilidade		:: 29
			empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 4
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::5
				limite fila					::4,4,4,4
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::4
		requisitos		::
				preco						:: 3800000
				nivel sustentabilidade		:: 38
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 5
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::2
				velocidade aparecer lixo	::6
				limite fila					::5,5,5,5
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::5
		requisitos		::
				preco						:: 5500000
				nivel sustentabilidade		:: 44
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 6
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::7
				limite fila					::6,6,6,6
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::6
		requisitos		::
				preco						:: 8400000
				nivel sustentabilidade		:: 56
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 7
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::8
				limite fila					::7,7,7,7
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::7
		requisitos		::
				preco						:: 10675000
				nivel sustentabilidade		:: 61
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 8
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::9
				limite fila					::8,8,8,8
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::8
		requisitos		::
				preco						:: 14000000
				nivel sustentabilidade		:: 70
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 9
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::9,9,9,9
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::9
		requisitos		::
				preco						:: 17775000
				nivel sustentabilidade		:: 79
				empreendimentos construidos	:: 
		##======================================
		nivel empreendimento :: 10
		atributos		::
				velocidade reciclagem		::0,0,0,0
				valor venda					::0,0,0,0
				experiencia					::1
				velocidade aparecer lixo	::10
				limite fila					::10,10,10,10
				lixo minimo					::0
				dinheiro gerado				::0
				separacao automatica		::0
				poder jogador				::10
		requisitos		::
				preco						:: 22250000
				nivel sustentabilidade		:: 89
				empreendimentos construidos	:: 
fim empreendimento	::
## Fim dos empreendimentos normais

## Início dos easter eggs
##[9, 12, 23, 36, 49, 65, 84, 99]
##derrota o tipo de lixo específico
##preco numero do empreendimento * nível de sustentabilidade para liberar * 100
##Valor de $ por derrotar lixo nível de sustentabilidade para liberar
##1
empreendimento		::lampada
	nome			::Máquina descaracterização de lâmpadas
	descricao		::A descontaminação das lâmpadas é feita no local da coleta, com uma máquina portátil, e após isso ela é triturada. filtrada e aspirada, garantindo a destinação correta dos passivos ambientais.
	nivel maximo	::1
	nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::5
			velocidade aparecer lixo	::1
			limite fila					::0,0,0,0
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::0
		requisitos		::
			preco						:: 900
			nivel sustentabilidade		::9
			empreendimentos construidos	:: 
fim empreendimento	::
##2
empreendimento		::madeira
	nome			::Máquina de trituração de madeira
	descricao		::A madeira é triturada e acaba por ser enviada ao reuso na fabricação de placas aglomeradas que são utilizadas por indústrias de móveis. Parte por ser encaminhada ao aquecimento dos fornos e caldeiras, bem como no fabrico de papéis e celulose. 
	nivel maximo	::1
	nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::5
			velocidade aparecer lixo	::1
			limite fila					::0,0,0,0
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::0
		requisitos		::
			preco						:: 4800
			nivel sustentabilidade		::12
			empreendimentos construidos	:: 
fim empreendimento	::
##3
empreendimento		::isopor
	nome			::Usina de reciclagem de isopor
	descricao		::Após a coleta seletiva o isopor passa pela máquina de reciclagem, e é compactado em fardos, que passam por um segundo processo de reciclagem, onde o isopor é triturado, derretido, granulado e volta a ser matéria-prima de novos produtos.
	nivel maximo	::1
	nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::5
			velocidade aparecer lixo	::1
			limite fila					::0,0,0,0
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::0
		requisitos		::
			preco						::20700
			nivel sustentabilidade		::23
			empreendimentos construidos	:: 
fim empreendimento	::
##4
empreendimento		::fraldas
	nome			::Máquina de reciclagem de fraldas
	descricao		:: Após a coleta de objetos como fraldas e absorventes, a máquina esteriliza seus componentes e então os transforma em novos produtos, como madeira plástica, telhas e materiais de absorção.
	nivel maximo	::1
	nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::5
			velocidade aparecer lixo	::1
			limite fila					::0,0,0,0
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::0
		requisitos		::
			preco						::86400
			nivel sustentabilidade		::36
			empreendimentos construidos	:: 
fim empreendimento	::
##5
empreendimento		::lata_tinta
	nome			::Usina de Blendagem
	descricao		::Na blendagem, o resíduo é totalmente descaracterizado e misturado junto a outros resíduos que recebemos de forma a produzir uma mistura líquido ou sólido com alto poder calorífero (blend).
	nivel maximo	::1
	nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::5
			velocidade aparecer lixo	::1
			limite fila					::0,0,0,0
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::0
		requisitos		::
			preco						::220500
			nivel sustentabilidade		::49
			empreendimentos construidos	:: 
fim empreendimento	::
##6
empreendimento		::pato
	nome			::Triturador de borracha
	descricao		::O processo de reciclagem de borrachas é realizado através do triturador de pneu e borracha e tem se tornado cada vez mais importante e lucrativo no mundo.
	nivel maximo	::1
	nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::5
			velocidade aparecer lixo	::1
			limite fila					::0,0,0,0
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::0
		requisitos		::
			preco						::585000
			nivel sustentabilidade		::65
			empreendimentos construidos	:: 
fim empreendimento	::
##7
empreendimento		::seringa
	nome			::Usina de Incineração
	descricao		::Lixo hospitalar não pode ser reciclado, porém, existem tratamentos melhores que o descarte, como a incineração. Durante a incineração não destruídos além do objeto, todos os microorganismos que podem existir nele. 
	nivel maximo	::1
	nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::5
			velocidade aparecer lixo	::1
			limite fila					::0,0,0,0
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::0
		requisitos		::
			preco						::1411200
			nivel sustentabilidade		::84
			empreendimentos construidos	:: 
fim empreendimento	::
##8
empreendimento		::pneu
	nome			::Fábrica de móveis de pneu
	descricao		::Os pneus pode ser reutilizados entre muitas outras coisas, em tiras usadas em móveis estofados, o que além de preservar o meio ambiente ajuda na geração de centenas de empregos.
	nivel maximo	::1
	nivel empreendimento :: 1
		atributos		::
			velocidade reciclagem		::0,0,0,0
			valor venda					::0,0,0,0
			experiencia					::5
			velocidade aparecer lixo	::1
			limite fila					::0,0,0,0
			lixo minimo					::0
			dinheiro gerado				::0
			separacao automatica		::0
			poder jogador				::0
		requisitos		::
			preco						:: 3088800
			nivel sustentabilidade		::99
			empreendimentos construidos	:: 
fim empreendimento	::";


	static public string [] empreendimentosLinhas = {
		"empreendimento		::coleta_seletiva",
		"	nome			::Coleta seletiva",
		"	descricao		::Coleta seletiva é a coleta diferenciada de resíduos que foram previamente separados segundo a sua constituição ou composição. Ou seja, resíduos com características similares são selecionados pelo gerador (que pode ser o cidadão, uma empresa ou outra instituição) e disponibilizados para a coleta separadamente. ",
		"	nivel maximo	::10",
		"	nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::2",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 24",
		"			nivel sustentabilidade		::1",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::3",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 96",
		"			nivel sustentabilidade		:: 2",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::4",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 216",
		"			nivel sustentabilidade		:: 3",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 4",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::5",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::4",
		"		requisitos		::",
		"			preco						:: 576",
		"			nivel sustentabilidade		:: 6",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 5",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::6",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::5",
		"		requisitos		::",
		"			preco						:: 1080",
		"			nivel sustentabilidade		:: 9",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 6",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::7",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::6",
		"		requisitos		::",
		"			preco						:: 2160",
		"			nivel sustentabilidade		:: 15",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 7",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::8",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::7",
		"		requisitos		::",
		"			preco						:: 4032",
		"			nivel sustentabilidade		:: 24",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 8",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::9",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::8",
		"		requisitos		::",
		"			preco						:: 7488",
		"			nivel sustentabilidade		:: 39",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento ::9",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::10",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::9",
		"		requisitos		::",
		"			preco						:: 11448",
		"			nivel sustentabilidade		:: 53",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 10",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::10",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::10",
		"		requisitos		::",
		"			preco						:: 22080",
		"			nivel sustentabilidade		:: 92",
		"			empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::catadores",
		"	nome			::Associação de catadores",
		"	descricao		::A cooperativa dos catadores é uma iníciativa social que ajuda não só as pessoas mas o meio ambiente. A reciclagem de papel é uma atividade que diminui tanto o consumo de recursos naturais, quanto sua presença nos aterros sanitários e gera renda para as famílias envolvidas no processo.",
		"	nivel maximo	::10",
		"	nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::0",
		"		requisitos		::",
		"			preco						:: 32",
		"			nivel sustentabilidade		::1",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::2",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 128",
		"			nivel sustentabilidade		:: 2",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::3",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 672",
		"			nivel sustentabilidade		:: 7",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 4",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::4",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::4,4,4,4",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 2176",
		"			nivel sustentabilidade		:: 17",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 5",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::5",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::5,5,5,5",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 4640",
		"			nivel sustentabilidade		:: 29",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 6",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::6",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::6,6,6,6",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 7872",
		"			nivel sustentabilidade		:: 41",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 7",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::7",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::7,7,7,7",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 11872",
		"			nivel sustentabilidade		:: 53",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 8",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::8",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::8,8,8,8",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 17152",
		"			nivel sustentabilidade		:: 67",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 9",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::9",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::9,9,9,9",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 22752",
		"			nivel sustentabilidade		:: 79",
		"			empreendimentos construidos	:: ",
		"	nivel empreendimento :: 10",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::10",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::10,10,10,10",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 31040",
		"			nivel sustentabilidade		:: 97",
		"			empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"##_________________________________________##",
		"##Atêlie de recicláveis, aumenta em: ",
		"##+1 de limite das filas por nível",
		"##+1 de velocidade para aparecer lixos ",
		"##libera nos seguintes níveis de sustentabilidade: [1 4 8 14 22 37 50 65 81 93] ",
		"## não possui outros pré-requisitos",
		"## +1 de xp por nivel",
		"##preco 55* nível do empreendimento * nível de sustentabilidade para liberar",
		"##",
		"empreendimento		::atelie_reciclaveis",
		"		nome			::Atêlie de Recicláveis",
		"		descricao		::Recicláveis são reciclado são materiais super versáteis, podendo ser usado para fazer inúmeros novos objetos, como bijuterias, embalagens, jogos, brinquedos entre outros.",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 55",
		"			nivel sustentabilidade		::1",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 440",
		"			nivel sustentabilidade		:: 4",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 1320",
		"			nivel sustentabilidade		:: 8",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 3080",
		"				nivel sustentabilidade		:: 14",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 6050",
		"				nivel sustentabilidade		:: 22",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 12210",
		"				nivel sustentabilidade		:: 37",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 19250",
		"				nivel sustentabilidade		:: 50",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 28600",
		"				nivel sustentabilidade		:: 65",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 40095",
		"				nivel sustentabilidade		:: 81",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 51150",
		"				nivel sustentabilidade		:: 93",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"##_____________________________________________##",
		"##Ferro Velho, aumenta em: ",
		"##+1 de limite das filas por nível",
		"##+1 de velocidade para aparecer lixos ",
		"##libera nos seguintes níveis de sustentabilidade: [11 23 30 42 51 62 68 74 85 91] ",
		"## não possui outros pré-requisitos",
		"## +1 de xp por nivel",
		"##preco 80* nível do empreendimento * nível de sustentabilidade para liberar",
		"##",
		"empreendimento		::ferro_velho",
		"		nome			::Ferro Velho",
		"		descricao		::O benefício da reciclagem e do reaproveitamento de sucatas de metal reduz o consumo de energia para a produção do alumínio e outros metais, preserva o meio ambiente e movimenta a economia, gerando empregos e fonte de renda.",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 80",
		"			nivel sustentabilidade		::11",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 3680",
		"			nivel sustentabilidade		:: 23",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 7200",
		"			nivel sustentabilidade		::30",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 13440",
		"				nivel sustentabilidade		:: 42",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 20400",
		"				nivel sustentabilidade		:: 51",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 29760",
		"				nivel sustentabilidade		:: 62",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 38080",
		"				nivel sustentabilidade		:: 68",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 47360",
		"				nivel sustentabilidade		:: 74",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 61200",
		"				nivel sustentabilidade		:: 85",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 72800",
		"				nivel sustentabilidade		:: 91",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::usina_reciclagem",
		"		nome			::Usina de Reciclagem",
		"		descricao		::A reciclagem é uma atividade industrial que diminui o consumo de recursos naturais e impede que estes resíduos acumulem em aterros sanitários e gera renda no processo.",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 48",
		"			nivel sustentabilidade		::1",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 192",
		"			nivel sustentabilidade		:: 2",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 720",
		"			nivel sustentabilidade		:: 5",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::4",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 3072",
		"				nivel sustentabilidade		:: 26",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 7440",
		"				nivel sustentabilidade		:: 31",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 12384",
		"				nivel sustentabilidade		:: 43",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 19152",
		"				nivel sustentabilidade		:: 57",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 26496",
		"				nivel sustentabilidade		:: 69",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 35424",
		"				nivel sustentabilidade		:: 82",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 45600",
		"				nivel sustentabilidade		:: 95",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::prensa_papel	",
		"		nome			::Prensa de Papel",
		"		descricao		::O papel é enfardado em prensas e depois encaminhado aos aparistas, que classificam as aparas e revendem para as fábricas de papel como matéria-prima.",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 1000",
		"			nivel sustentabilidade		::12",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 40000",
		"			nivel sustentabilidade		:: 20",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 87000",
		"			nivel sustentabilidade		:: 29",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 144000",
		"				nivel sustentabilidade		:: 36",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 230000",
		"				nivel sustentabilidade		:: 46",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 312000",
		"				nivel sustentabilidade		:: 52",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 420000",
		"				nivel sustentabilidade		:: 60",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 528000",
		"				nivel sustentabilidade		:: 66",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 702000",
		"				nivel sustentabilidade		:: 78",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 860000",
		"				nivel sustentabilidade		:: 86",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::oficina_brinquedos",
		"		nome			::Oficina de Brinquedos Reciclados",
		"		descricao		::Além de ensinar como organizar atividades que ajudem na preservação da natureza, usando materiais recicláveis as oficinas colaboram para a formação de crianças conscientes e no desenvolvimento do potencial artístico.",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 2000",
		"			nivel sustentabilidade		::14",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 92000",
		"			nivel sustentabilidade		:: 23",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 204000",
		"			nivel sustentabilidade		:: 34",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 320000",
		"				nivel sustentabilidade		:: 40",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 490000",
		"				nivel sustentabilidade		:: 49",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 696000",
		"				nivel sustentabilidade		:: 58",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 938000",
		"				nivel sustentabilidade		:: 67",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 1216000",
		"				nivel sustentabilidade		:: 76",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 1476000",
		"				nivel sustentabilidade		:: 82",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 1920000",
		"				nivel sustentabilidade		:: 96",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::viveiro_garrafas",
		"		nome			::Viveiros de Garrafas Pet",
		"		descricao		::As garrafas pet, antes de serem enviadas para reciclagem, podem ser utilizadas em diversas atividades. Uma prática muito comum é a utilização das garrafas pets para produção de mudas. As garrafas são lavadas e cortadas, deixando apenas a parte inferior para o uso (potes). A parte superior é enviada para reciclagem. São inseridos terra e adubo nos potes e em seguida as sementes, que em alguns meses estarão prontas para plantio.",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 3000",
		"			nivel sustentabilidade		::16",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 126000",
		"			nivel sustentabilidade		:: 21",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 297000",
		"			nivel sustentabilidade		:: 33",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 468000",
		"				nivel sustentabilidade		:: 39",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 675000",
		"				nivel sustentabilidade		:: 45",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 972000",
		"				nivel sustentabilidade		:: 54",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 1365000",
		"				nivel sustentabilidade		:: 65",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 1704000",
		"				nivel sustentabilidade		:: 71",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 2349000",
		"				nivel sustentabilidade		:: 87",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 2940000",
		"				nivel sustentabilidade		:: 98",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::triturador_residuos	",
		"		nome			::Triturador de Resíduos Sólidos",
		"		descricao		::As necessidades de grandes áreas para criação de aterros sanitários e elevado volume de lixo produzido pelas metrópoles fez-se necessário a trituração e processamento dos mesmos. Através destes equipamentos pode-se obter redução de volume, separação de materiais que possam virar matéria prima tais como metais, plásticos, papéis entre outros recicláveis envolvidos.",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 5000",
		"			nivel sustentabilidade		::17",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 260000",
		"			nivel sustentabilidade		:: 26",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 510000",
		"			nivel sustentabilidade		:: 34",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 820000",
		"				nivel sustentabilidade		:: 41",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 1200000",
		"				nivel sustentabilidade		:: 48",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 1590000",
		"				nivel sustentabilidade		:: 53",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 2205000",
		"				nivel sustentabilidade		:: 63",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 2800000",
		"				nivel sustentabilidade		:: 70",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 3945000",
		"				nivel sustentabilidade		:: 81",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 4600000",
		"				nivel sustentabilidade		:: 92",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::galeria_arte",
		"		nome			::Galeria de Arte em Metal",
		"		descricao		::Para Esculturas em sucatam os artistas utilizam apenas metal reciclado para sua produção criando peças maravilhosas a partir de materiais descartados.",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 10000",
		"			nivel sustentabilidade		::18",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 600000",
		"			nivel sustentabilidade		:: 30",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 1110000",
		"			nivel sustentabilidade		:: 37",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 1800000",
		"				nivel sustentabilidade		:: 45",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 2500000",
		"				nivel sustentabilidade		:: 50",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 3480000",
		"				nivel sustentabilidade		:: 58",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 4620000",
		"				nivel sustentabilidade		:: 66",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 5920000",
		"				nivel sustentabilidade		:: 74",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 7200000",
		"				nivel sustentabilidade		:: 80",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 9000000",
		"				nivel sustentabilidade		:: 90",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::industria_reciclagem",
		"		nome			::Indústria de reciclagem e processamento",
		"		descricao		:: Essa indústria vira mais uma página na história da destinação dos resíduos sólidos da cidade. Em vez de enterrar e desperdiçar lixo em aterros sanitários, Você entra na era da indústria da transformação do lixo. Trata-se de uma indústria limpa, que tem grande potencial de atrair outras indústrias de reciclagem para as suas imediações. O estímulo à atividade tende a elevar o preço dos materiais recicláveis, melhorando também a renda dos ecocidadãos.",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 100000",
		"			nivel sustentabilidade		::50",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						::12000000",
		"			nivel sustentabilidade		:: 60",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 19500000",
		"			nivel sustentabilidade		:: 65",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 28000000",
		"				nivel sustentabilidade		:: 70",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 37500000",
		"				nivel sustentabilidade		:: 75",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 48000000",
		"				nivel sustentabilidade		:: 80",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 59500000",
		"				nivel sustentabilidade		:: 85",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 72000000",
		"				nivel sustentabilidade		:: 90",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 85500000",
		"				nivel sustentabilidade		:: 95",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 99000000",
		"				nivel sustentabilidade		:: 99",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::fabrica_vitrais",
		"		nome			::Fábrica de Vitrais",
		"		descricao		::O vidro pode passar por esse processo infinitas vezes sem perda de qualidade ou pureza do produto. Isso tudo nos mostra a importância da conscientização de todos, para que realizem em suas residências a coleta seletiva do vidro para a sua reciclagem. ",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 50000",
		"			nivel sustentabilidade		::15",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 2600000",
		"			nivel sustentabilidade		:: 26",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 5850000",
		"			nivel sustentabilidade		:: 39",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 9400000",
		"				nivel sustentabilidade		:: 47",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 13250000",
		"				nivel sustentabilidade		::53",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 18000000",
		"				nivel sustentabilidade		:: 60",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 25200000",
		"				nivel sustentabilidade		:: 72",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 34800000",
		"				nivel sustentabilidade		:: 87",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 41400000",
		"				nivel sustentabilidade		:: 92",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 49000000",
		"				nivel sustentabilidade		:: 98",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::recicladora_aluminio",
		"		nome			::Recicladora de alumínio",
		"		descricao		::A lata de alumínio pode ser reciclada infinitas vezes e sempre volta como lata. O benefício da reciclagem reduz o consumo de energia para a produção do alumínio, preserva o meio ambiente e movimenta a economia, gerando empregos e fonte de renda na coleta e promovendo a educação dos cidadãos para o desenvolvimento sustentável. Hoje, 95% das bebidas vendidas em lata no nosso País utilizam a embalagem de alumínio.",
		" ",
		"		nivel maximo	::10",
		"		nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	:: 2",
		"			limite fila					::1,1,1,1",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::1",
		"		requisitos		::",
		"			preco						:: 25000",
		"			nivel sustentabilidade		::13",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 2",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::3",
		"			limite fila					::2,2,2,2",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::2",
		"		requisitos		::",
		"			preco						:: 1100000",
		"			nivel sustentabilidade		:: 22",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 3",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::1",
		"			velocidade aparecer lixo	::4",
		"			limite fila					::3,3,3,3",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::3",
		"		requisitos		::",
		"			preco						:: 2175000",
		"			nivel sustentabilidade		:: 29",
		"			empreendimentos construidos	:: ",
		"		nivel empreendimento :: 4",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::5",
		"				limite fila					::4,4,4,4",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::4",
		"		requisitos		::",
		"				preco						:: 3800000",
		"				nivel sustentabilidade		:: 38",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 5",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::2",
		"				velocidade aparecer lixo	::6",
		"				limite fila					::5,5,5,5",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::5",
		"		requisitos		::",
		"				preco						:: 5500000",
		"				nivel sustentabilidade		:: 44",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 6",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::7",
		"				limite fila					::6,6,6,6",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::6",
		"		requisitos		::",
		"				preco						:: 8400000",
		"				nivel sustentabilidade		:: 56",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 7",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::8",
		"				limite fila					::7,7,7,7",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::7",
		"		requisitos		::",
		"				preco						:: 10675000",
		"				nivel sustentabilidade		:: 61",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 8",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::9",
		"				limite fila					::8,8,8,8",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::8",
		"		requisitos		::",
		"				preco						:: 14000000",
		"				nivel sustentabilidade		:: 70",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 9",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::9,9,9,9",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::9",
		"		requisitos		::",
		"				preco						:: 17775000",
		"				nivel sustentabilidade		:: 79",
		"				empreendimentos construidos	:: ",
		"		nivel empreendimento :: 10",
		"		atributos		::",
		"				velocidade reciclagem		::0,0,0,0",
		"				valor venda					::0,0,0,0",
		"				experiencia					::1",
		"				velocidade aparecer lixo	::10",
		"				limite fila					::10,10,10,10",
		"				lixo minimo					::0",
		"				dinheiro gerado				::0",
		"				separacao automatica		::0",
		"				poder jogador				::10",
		"		requisitos		::",
		"				preco						:: 22250000",
		"				nivel sustentabilidade		:: 89",
		"				empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::lampada",
		"	nome			::Máquina descaracterização de lâmpadas",
		"	descricao		::A descontaminação das lâmpadas é feita no local da coleta, com uma máquina portátil, e após isso ela é triturada. filtrada e aspirada, garantindo a destinação correta dos passivos ambientais.",
		"	nivel maximo	::1",
		"	nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::5",
		"			velocidade aparecer lixo	::1",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::0",
		"		requisitos		::",
		"			preco						:: 900",
		"			nivel sustentabilidade		::9",
		"			empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::madeira",
		"	nome			::Máquina de trituração de madeira",
		"	descricao		::A madeira é triturada e acaba por ser enviada ao reuso na fabricação de placas aglomeradas que são utilizadas por indústrias de móveis. Parte por ser encaminhada ao aquecimento dos fornos e caldeiras, bem como no fabrico de papéis e celulose. ",
		"	nivel maximo	::1",
		"	nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::5",
		"			velocidade aparecer lixo	::1",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::0",
		"		requisitos		::",
		"			preco						:: 4800",
		"			nivel sustentabilidade		::12",
		"			empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::isopor",
		"	nome			::Usina de reciclagem de isopor",
		"	descricao		::Após a coleta seletiva o isopor passa pela máquina de reciclagem, e é compactado em fardos, que passam por um segundo processo de reciclagem, onde o isopor é triturado, derretido, granulado e volta a ser matéria-prima de novos produtos.",
		"	nivel maximo	::1",
		"	nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::5",
		"			velocidade aparecer lixo	::1",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::0",
		"		requisitos		::",
		"			preco						::20700",
		"			nivel sustentabilidade		::23",
		"			empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::fraldas",
		"	nome			::Máquina de reciclagem de fraldas",
		"	descricao		:: Após a coleta de objetos como fraldas e absorventes, a máquina esteriliza seus componentes e então os transforma em novos produtos, como madeira plástica, telhas e materiais de absorção.",
		"	nivel maximo	::1",
		"	nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::5",
		"			velocidade aparecer lixo	::1",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::0",
		"		requisitos		::",
		"			preco						::86400",
		"			nivel sustentabilidade		::36",
		"			empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::lata_tinta",
		"	nome			::Usina de Blendagem",
		"	descricao		::Na blendagem, o resíduo é totalmente descaracterizado e misturado junto a outros resíduos que recebemos de forma a produzir uma mistura líquido ou sólido com alto poder calorífero (blend).",
		"	nivel maximo	::1",
		"	nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::5",
		"			velocidade aparecer lixo	::1",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::0",
		"		requisitos		::",
		"			preco						::220500",
		"			nivel sustentabilidade		::49",
		"			empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::pato",
		"	nome			::Triturador de borracha",
		"	descricao		::O processo de reciclagem de borrachas é realizado através do triturador de pneu e borracha e tem se tornado cada vez mais importante e lucrativo no mundo.",
		"	nivel maximo	::1",
		"	nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::5",
		"			velocidade aparecer lixo	::1",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::0",
		"		requisitos		::",
		"			preco						::585000",
		"			nivel sustentabilidade		::65",
		"			empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::seringa",
		"	nome			::Usina de Incineração",
		"	descricao		::Lixo hospitalar não pode ser reciclado, porém, existem tratamentos melhores que o descarte, como a incineração. Durante a incineração não destruídos além do objeto, todos os microorganismos que podem existir nele. ",
		"	nivel maximo	::1",
		"	nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::5",
		"			velocidade aparecer lixo	::1",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::0",
		"		requisitos		::",
		"			preco						::1411200",
		"			nivel sustentabilidade		::84",
		"			empreendimentos construidos	:: ",
		"fim empreendimento	::",
		"empreendimento		::pneu",
		"	nome			::Fábrica de móveis de pneu",
		"	descricao		::Os pneus pode ser reutilizados entre muitas outras coisas, em tiras usadas em móveis estofados, o que além de preservar o meio ambiente ajuda na geração de centenas de empregos.",
		"	nivel maximo	::1",
		"	nivel empreendimento :: 1",
		"		atributos		::",
		"			velocidade reciclagem		::0,0,0,0",
		"			valor venda					::0,0,0,0",
		"			experiencia					::5",
		"			velocidade aparecer lixo	::1",
		"			limite fila					::0,0,0,0",
		"			lixo minimo					::0",
		"			dinheiro gerado				::0",
		"			separacao automatica		::0",
		"			poder jogador				::0",
		"		requisitos		::",
		"			preco						:: 3088800",
		"			nivel sustentabilidade		::99",
		"			empreendimentos construidos	:: ",
		"fim empreendimento	::"	
	};
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarInimigoScript : MonoBehaviour {

	public GameObject inimigo;
	public float limiteEsquerdo, limiteDireito;
	public float tempoInicial, tempoFinal;

	IEnumerator Start (){

		//Aguarda para criacao de um inimigo
		yield return new WaitForSeconds (Random.Range (tempoInicial, tempoFinal));

		//Sorteia posicao em x para instanciar o inimigo
		Vector2 posicao = new Vector2(
			Random.Range(limiteEsquerdo,limiteDireito),transform.position.y);
	

		//Instancia o inimigo

		Instantiate (inimigo, posicao, transform.rotation);


		//Looping
		StartCoroutine (Start ());
	}



}

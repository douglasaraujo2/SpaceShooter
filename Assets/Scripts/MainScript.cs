using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {

	public Text placar;
	public Sprite[] HealthSprites;
	public Image ImageHealth;
	private JogadorScript jogador;

	void Start(){
		jogador = GameObject.FindGameObjectWithTag ("Jogador").GetComponent<JogadorScript>();
	}


	// Update is called once per frame
	void Update () {
		placar.text = JogadorScript.pontos.ToString();
		ImageHealth.sprite = HealthSprites [jogador.vidas];
	}
}

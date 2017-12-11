using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

	public float velocidade;
	public float tempoDeVida;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, tempoDeVida);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * velocidade * Time.deltaTime);
	}

	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "Inimigo") {
			Destroy (gameObject);
		}

	}
}

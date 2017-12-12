using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjetilScript : MonoBehaviour {

	public float velocidade;
	public float tempoDeVida;
	public GameObject explosaoPrefab;

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
			Instantiate (explosaoPrefab, transform.position, transform.rotation);
			Destroy (c.gameObject);
			Destroy (gameObject);		
			JogadorScript.pontos++;
		}
		
	}
}

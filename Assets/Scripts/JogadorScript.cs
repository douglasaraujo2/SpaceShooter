using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JogadorScript : MonoBehaviour {

	public float velocidade;
	public float limiteEsquerdo, limiteDireito;
	public int vidas;
	public GameObject explosaoPrefab;
	public static int pontos;

	void Update () {
		Mover ();			
	}


	void Mover(){
		float move_x = Input.acceleration.x * velocidade * Time.deltaTime;
		//float move_y = Input.acceleration.y * velocidade * Time.deltaTime;
		transform.Translate (move_x, 0.0f, 0.0f);
		if (transform.position.x < limiteEsquerdo || transform.position.x > limiteDireito) {
			transform.position = new Vector2 (transform.position.x * -1 ,transform.position.y);
		}
	}


	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.tag == "Inimigo") {
			vidas--;
			Instantiate (explosaoPrefab, transform.position, transform.rotation);
			Destroy (c.gameObject);
			if (vidas <= 0) {
				
				//Destroy (gameObject);
				SceneManager.LoadScene("StartScene");	
			}
		}
	}

}

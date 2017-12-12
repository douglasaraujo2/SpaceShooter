using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaScript : MonoBehaviour {

	public GameObject projetil;


	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds (0.3f);

		Instantiate (projetil, transform.position, transform.rotation);

		StartCoroutine (Start ());
	}
	

}

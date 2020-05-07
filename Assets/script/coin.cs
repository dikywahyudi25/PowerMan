using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag.Equals ("Player")){
			print("coin diambil");
			Destroy (gameObject);
			DolarScore.hitungDolar += 50;
			
		}
	}

}

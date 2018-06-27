using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Destroy : MonoBehaviour {


public int t;

void OnCollisionEnter(Collision col) {
	
			Destroy(gameObject);
			//Destroy(col.gameObject);
		
	}

	// Use this for initialization
	void Start () {

		
		
	}
	



	// Update is called once per frame
	void Update () {
		
t=t+1;

if(t>100){Destroy(gameObject);};



	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	int Hourotex=0;


	// Update is called once per frame
	void Update () {
		

		if(Input.GetKey(KeyCode.Y)&&Hourotex<70){

			transform.rotation = transform.rotation*Quaternion.Euler(0,0,2);
			Hourotex=Hourotex+2;
		}

		if(Input.GetKey(KeyCode.B)&&Hourotex>-70){

			transform.rotation = transform.rotation*Quaternion.Euler(0,0,-2);
			Hourotex=Hourotex-2;
		}
		
	}
}

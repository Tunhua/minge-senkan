using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoudaiRotation : MonoBehaviour {


public int Hourotex=0;
public int Hourotey=0;


//private Rigidbody c_rigidbody;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.H)&&Hourotey<70){

			transform.rotation = transform.rotation*Quaternion.Euler(0,2,0);

			Hourotey=Hourotey+2;
		}

		if(Input.GetKey(KeyCode.G)&&Hourotey>-70){

			transform.rotation = transform.rotation*Quaternion.Euler(0,-2,0);

			Hourotey=Hourotey-2;
		}

/*		if(Input.GetKey(KeyCode.Y)&&Hourotex<70){

			Houdai.transform.rotation = Houdai.transform.rotation*Quaternion.Euler(0,0,2);

			Hourotex=Hourotex+2;
		}

		if(Input.GetKey(KeyCode.B)&&Hourotex>-70){

Houdai.transform.rotation = Houdai.transform.rotation*Quaternion.Euler(0,0,-2);

		Hourotex=Hourotex-2;
		};

*/
	
		//transform.rotation = transform.rotation*Quaternion.Euler(0,Hourotey,Hourotex);
	
	
	}
}

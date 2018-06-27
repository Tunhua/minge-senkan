using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class SenkanMove : MonoBehaviour {

	// Use this for initialization

	private Rigidbody c_rigidbody;

	public int speed = 0;
  		
	public int rotex=0;
	public int rotey=0;
	public int rotez=0;
	
	

	void Start () {

			c_rigidbody =  GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 posi = GameObject.Find("senkan0").transform.position;




		if(Input.GetKey(KeyCode.RightArrow)){

			if(rotey>=0){
				transform.rotation = transform.rotation * Quaternion.Euler(0,1,0) ; 
				rotey=0;//-2;
			}
			rotey=0;//+1;
		}
		
		if(Input.GetKey(KeyCode.LeftArrow)){

			if(rotey<=0){
				transform.rotation = transform.rotation * Quaternion.Euler(0,-1,0) ; 
				rotey=0;//2;
			}
			rotey=rotey;//-1;
		}

		if(Input.GetKey(KeyCode.UpArrow)){

			if(rotex>=0){
				transform.rotation = transform.rotation * Quaternion.Euler(0,0,1) ; 			
				rotex=0;//-2;
			}
			rotex=rotex;//+1;
		}

		if(Input.GetKey(KeyCode.DownArrow)){

			if(rotex<=0){
				transform.rotation = transform.rotation * Quaternion.Euler(0,0,-1) ; 
				rotex=0;//2;
			}
			rotex=rotex;//-1;
		}

		if(Input.GetKey(KeyCode.Space)&&speed<500){

			speed+=2;

		}
		if(speed>0)speed-=1;

		// transform.rotation = Quaternion.Euler(rotez,rotey,rotex);

		// c_rigidbody.velocity = new Vector3(speed*Mathf.Sin(rotey)*Mathf.Cos(rotex),speed*Mathf.Cos(rotey),speed*Mathf.Sin(rotey)*Mathf.Sin(rotex));


		//kaitenjiku = GameObject.Find("RoteX").transform.position;

		this.transform.Translate(0.0005f*speed,0,0);
		this.GetComponent<Rigidbody>().velocity=posi*0;
		//transform.rotation = Quaternion.LookRotation(this.GetComponent<Rigidbody>().velocity);

	}
}
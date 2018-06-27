using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting2 : MonoBehaviour {

// bullet prefab
	public GameObject lazer;
 int t=0;
	
 
	// 弾丸の速度
	public float speed = 10000;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
t+=1;
		if(Input.GetKey (KeyCode.A)&&t>5){
			t=0;
			// 弾丸の複製
			GameObject lazers = GameObject.Instantiate(lazer)as GameObject;
 
			Vector3 force;
            Vector3 vecM;
			Vector3 vecC;
		
			vecC =  GameObject.Find("muzzle2").transform.position;
			vecM =  GameObject.Find("target2").transform.position;

			force.x = (vecM.x-vecC.x)*speed;
			force.y = (vecM.y-vecC.y)*speed;
			force.z = (vecM.z-vecC.z)*speed;

// Rigidbodyに力を加えて発射
			lazers.GetComponent<Rigidbody>().AddForce (force);

	// 弾丸の位置を調整
		lazers.transform.position = GameObject.Find("target2").transform.position;
		
		lazers.transform.rotation =  GameObject.Find("Houdai").transform.rotation*Quaternion.Euler(0,0,-90);
	}
}
}

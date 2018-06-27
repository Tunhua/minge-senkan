using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoudaiShot : MonoBehaviour {

// bullet prefab
	public GameObject Bullet;
 
 	public GameObject HoudaiPosition;

	public GameObject muzzle;

	
 
	// 弾丸の速度
	public double speed = 0.01;




public double l;
int t=0;
public int n;//狙う敵の番号
public Vector3 array;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			

		//	l=GetComponent<syoujunAI>().max;

//GameObject obj = GameObject.Find("HoudaiPosition");

l=HoudaiPosition.GetComponent<HoudaiAI>().max;

n=HoudaiPosition.GetComponent<HoudaiAI>().i;

array=HoudaiPosition.GetComponent<HoudaiAI>().array[n];



//l=GetComponent<syoujunAI>().max;

t+=1;

if(l>0&&t>25){

	t=0;
			// 弾丸の複製
			GameObject bullets = GameObject.Instantiate(Bullet)as GameObject;
 
			Vector3 force;
            Vector3 vecM;
			Vector3 vecC;



			vecC = HoudaiPosition.transform.position;
			vecM =  muzzle.transform.position;

			Vector3 muki = array - vecC;

			force.x = muki.x/muki.magnitude;
			force.y = muki.y/muki.magnitude;
			force.z = muki.z/muki.magnitude;

			//force = GameObject.Find("Cube").transform.forward* speed;
			// Rigidbodyに力を加えて発射
			bullets.GetComponent<Rigidbody>().AddForce (force);
			// 弾丸の位置を調整
		bullets.transform.position = muzzle.transform.position;
		
		//bullets.transform.rotation =  GameObject.Find("HoudaiPosition").transform.rotation;//Quaternion.Euler(force.x,force.y,0);
		
bullets.transform.forward = muki;

		}





	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoudaiAI : MonoBehaviour {



/* 
public int Hourotex=0;
public int Hourotey=0;

*/

//public int k=2; //敵の数

public GameObject HoudaiPosition;

public GameObject muzzle;


int syatei=500;//射程

public Vector3[] array = new Vector3[6]; //配列

Vector3 houkou;

double cos;

public double max=0;

public int i;//ターゲット

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	i=5;

	for(int k=0;k<=4;k++){
		if(GameObject.Find("senkan"+k)!=null){
			array[k]=GameObject.Find("senkan"+k).transform.position;
		}else{
			array[k].x=100000000;
			array[k].y=100000000;
			array[k].z=100000000;
			}
		}

//方向の記憶
Vector3 vecM;
Vector3 vecC;
vecC =  HoudaiPosition.transform.position;//GameObject.Find("HoudaiPosition").transform.position;
vecM =  muzzle.transform.position;//GameObject.Find("muzzle").transform.position;
array[5] = vecM;
houkou = vecM - vecC;
max=-1;//リセット
cos=0;

Vector3 ab;

for(int j=0;j<=4;j++){

	ab = array[j]-vecC;

	if(ab.magnitude<=syatei){

		cos = Vector3.Dot(houkou, ab)/ab.magnitude/houkou.magnitude;

	if(cos>max){
		max=cos;

		i=j;
		}

	}

}

	}

}


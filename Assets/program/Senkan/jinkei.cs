using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jinkei : MonoBehaviour {
	public Vector3[] array = new Vector3[6]; //配列
	public Vector3[] array1 = new Vector3[5]; //相対座標用の配列
	public Vector2[] array2 = new Vector2[5]; //相対座標の三角関数用の配列

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		for(int j=0;j<6;j++){
			if(GameObject.Find("senkan"+j)!=null){
				array[j]=GameObject.Find("senkan"+j).transform.position;
			}else{
				array[j].x=100000000;
				array[j].y=100000000;
				array[j].z=100000000;
			}
		}

		for(int j=0;j<5;j++){
			array1[j].x = array[j].x - array[0].x;
			array1[j].y = array[j].y - array[0].y;
		}

		for(int k=1;k<5;k++){
			GameObject.Find("senkan"+k).transform.forward = GameObject.Find("senkan0").transform.forward;
			array[k].x = array[0].x + 100*k;
			array[k].y = array[0].y;
			array[k].z = array[0].z;
			GameObject.Find("senkan"+k).transform.position = array[k];
		}
	}
}

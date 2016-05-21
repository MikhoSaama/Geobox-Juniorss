using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class gamecontroller : MonoBehaviour {

	public float timer;

	public GameObject UnivarsalBall;
	public List<Sprite> SpriteList;
	float oldTimer;
	void Start () {
		oldTimer = timer;
	}
	

	void Update () {
	

			print(Time.deltaTime);
			timer-=Time.deltaTime;
			if(timer<= 0){

			Instantiate(UnivarsalBall, new Vector3(Random.Range(-2f,2f), 5, 0),Quaternion.identity);
			UnivarsalBall.GetComponent<SpriteRenderer>().sprite =SpriteList[Random.Range (0,SpriteList.Count)];
			if(oldTimer>0.001f)oldTimer-= 0.001f;
			timer=oldTimer;
		}




	}
}

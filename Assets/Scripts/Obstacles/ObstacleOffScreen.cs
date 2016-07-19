using UnityEngine;
using System.Collections;

public class ObstacleOffScreen : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D target){
		if(target.tag =="Collector"){
			gameObject.SetActive(false);
		}
//		if(target.tag =="Zombie"){
//			gameObject.SetActive(false);
//		}
	}
}

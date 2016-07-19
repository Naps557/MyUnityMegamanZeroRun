using UnityEngine;
using System.Collections;

public class Obstacles : MonoBehaviour {

	private float speed = -3f;
	
	private Rigidbody2D myBody;
	
	void Awake () {
		myBody = GetComponent<Rigidbody2D> ();
	}
	

	void Update () {
		myBody.velocity = new Vector2 (speed, 0f);
	}
	
	void OnTriggerEnter2D(Collider2D target){			
		if (target.gameObject.tag == "Shot"){
			if (gameObject.tag == "Enemy"){
				//Destroy(gameObject);
				//Destroy(target.gameObject);
				gameObject.SetActive(false);
				target.gameObject.SetActive(false);				
			} else {
			//Destroy(gameObject);
			//Destroy(target.gameObject);
			//gameObject.SetActive(false);
			target.gameObject.SetActive(false);
			}
		}
	}
}
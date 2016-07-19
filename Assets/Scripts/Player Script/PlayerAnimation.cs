using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

	private Animator anim;
	
	void Awake () {
		anim = GetComponent<Animator> ();
		Debug.Log("Animatorfound");
	}
	
	void OnCollisionEnter2D(Collision2D target){
		if(target.gameObject.tag == "Obstacle"){
			anim.Play("MegaManZeroGunnerIdle");
		}
	}
		
	void OnCollisionExit2D(Collision2D target){
			if(target.gameObject.tag == "Obstacle"){
			anim.Play("MegaManZeroGunnerRun");
		}
	}
}



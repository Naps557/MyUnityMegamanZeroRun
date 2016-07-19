using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject projectile;
	public float moveSpeed;
	public AudioClip shootClip;

	[SerializeField]
	private Button shootBtn;	
	private bool canShoot;
	private bool canJump;

	void Awake () {
		shootBtn = GameObject.Find ("Shoot Button").GetComponent<Button> ();
		shootBtn.onClick.AddListener (() => Shoot());
	}

	public void Shoot(){
			
			AudioSource.PlayClipAtPoint(shootClip, transform.position);
			
			GameObject shot = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
			shot.GetComponent<Rigidbody2D>().velocity = new Vector3(moveSpeed, 0, -2);
		}	
		


	//void Update () {
	
	//	if(Input.GetKeyDown(KeyCode.Space)){
	//		GameObject shot = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
	//		shot.GetComponent<Rigidbody2D>().velocity = new Vector3(moveSpeed, 0, -2);
	//	}
		
	//}	
}

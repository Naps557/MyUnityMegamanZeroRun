using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	public float speed = 0.1f;
	
	private Vector2 offset = Vector2.zero;
	private Material Mat;

	// Use this for initialization
	void Start () {
		Mat = GetComponent<Renderer>().material;
		offset = Mat.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
		offset.x += speed * Time.deltaTime;
		Mat.SetTextureOffset ("_MainTex", offset);
	}
}

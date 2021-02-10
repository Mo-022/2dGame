using UnityEngine;
using System.Collections;

public class AniamMoveForword : MonoBehaviour {

	private Rigidbody2D reg;
	public float speed=10f;
	// Use this for initialization
	void Start () {
		reg = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		reg.velocity=new Vector2 (transform.localScale.x, 0) * speed;
	}
}

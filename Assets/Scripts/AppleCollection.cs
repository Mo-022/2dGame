using UnityEngine;
using System.Collections;

public class AppleCollection : MonoBehaviour {

	private Animator anim;
	public Door door;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		//iBirdFly = GetComponent<BirdFly> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D target){
		anim.SetInteger ("StateChange", 1);	
	 	door.open ();
	}

	void OnCollisionExit2D(Collision2D target){
		anim.SetInteger ("StateChange", 0);
		 door.close ();
	}
}

using UnityEngine;
using System.Collections;

public class AnimaPackage : MonoBehaviour {

	private Animator anim;
	public DoorOn dooron;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D target){
		anim.SetInteger ("anim", 1);
		dooron.Open ();
	}


	void OnCollisionExit2D(Collision2D target){
		anim.SetInteger ("anim", 0);
		dooron.Close ();
	}
}

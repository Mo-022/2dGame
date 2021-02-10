using UnityEngine;
using System.Collections;

public class DoorOn : MonoBehaviour {

	// Use this for initialization
	private Animator anim;
	Collider2D t;
	void Start () {
		anim = GetComponent<Animator> ();
		t = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Open(){
		anim.SetInteger ("anim", 1);
		t.isTrigger = true;
	}


	public void Close(){
		anim.SetInteger ("anim", 0);
		t.isTrigger = false;
	}
}

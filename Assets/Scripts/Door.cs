using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	private Animator anim;
	Collider2D t;
	// Use this for initialization
	void Start () {
		t = GetComponent<Collider2D> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Update is called once per frame
 public	void open () {
 	anim.SetInteger ("MoveSt", 1);
		t.isTrigger = true;
		 
	}
 public void close () {
		anim.SetInteger ("MoveSt", 0);	
		t.isTrigger = false;
	}
}

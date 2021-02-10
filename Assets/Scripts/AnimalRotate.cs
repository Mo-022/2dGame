using UnityEngine;
using System.Collections;

public class AnimalRotate : MonoBehaviour {

	public Transform animaT, OAnimaT;
	private  bool Collisons=false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Collisons = Physics2D.Linecast (animaT.position, OAnimaT.position, 1 << LayerMask.NameToLayer ("solid"));

		if (Collisons)
			transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
	}
}

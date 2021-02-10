using UnityEngine;
using System.Collections;

public class helloWord : MonoBehaviour {

	public float speed = 3.5f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (new Vector3 (-speed, -speed, transform.position.z) * Time.deltaTime);
 

	 
	}
}









 	 
//transform.Translate (new Vector3 (speed, 0, transform.position.z) * Time.deltaTime);
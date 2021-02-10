using UnityEngine;
using System.Collections;
 
public class ExitLevel : MonoBehaviour {
	public string levelName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "player") {
			Destroy (other.gameObject);
			Application.LoadLevel (levelName);
	 
		}
	
	}
}

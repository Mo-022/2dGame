using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class collectcions : MonoBehaviour {
	public Slider sd;
 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "player") {
			Destroy (gameObject);
			sd.value = sd.value + 1;
		}

	}
}

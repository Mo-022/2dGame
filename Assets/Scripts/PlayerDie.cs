using UnityEngine;
using System.Collections;

public class PlayerDie : MonoBehaviour {
	public AudioClip audioClip;
	 
	public int totalParts=5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "KillPlayerAnial") {
			Destroy (gameObject);
			AudioSource.PlayClipAtPoint (audioClip, transform.position);

			GameObject go = new GameObject ("NextLevel");
			NextLevel script = go.AddComponent<NextLevel>();
			script.levelName = Application.loadedLevelName;
		  
		}

	}
 
}

//GameObject go = new GameObject ("NextLevel");
//NextLevel script = go.AddComponent<NextLevel> ();
//script.levelName= Application.loadedLevelName;
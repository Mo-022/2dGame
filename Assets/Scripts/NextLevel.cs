using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	public string levelName;
	private bool LockMode = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && !LockMode) {
			//LockMode = true;
			Application.LoadLevel (levelName);

		}
	 
	}
}

using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float speed = 10f;
	private Rigidbody2D rigidbody2Du;
	public Vector2 maxVelocity = new Vector2(3, 5);

	// Update is called once per frame
	void Update () {
		rigidbody2Du = GetComponent<Rigidbody2D>();
		var forceX = 0f;
		var forceY = 0f;

		var absVelX = Mathf.Abs (rigidbody2Du.velocity.x);
		var absVelY = Mathf.Abs (rigidbody2Du.velocity.y);
		if (Input.GetKey ("right")) {

			if(absVelX < maxVelocity.x)
				forceX = speed;
			Debug.Log (absVelX);
			transform.localScale = new Vector3(1, 1, 1);

		} else if (Input.GetKey ("left")) {

			if(absVelX < maxVelocity.x)
				forceX = -speed;

			transform.localScale = new Vector3(-1, 1, 1);
		}
		else if (Input.GetKey ("up")) {

			if(absVelY < maxVelocity.y)
				forceY = speed;

			transform.localScale = new Vector3(1, 1, 1);
		}
		rigidbody2Du.AddForce (new Vector2 (forceX, forceY));
	}
}

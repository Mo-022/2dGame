using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {

	private Rigidbody2D reg;
	public float speed = 10f;
	// Use this for initialization
	public bool standing;
	public float SpeedSlow = 0.3f;
	public Animator animvar;
	public Vector2 MaxVelocity = new Vector2 (2, 3);
	public AudioClip audioClip;
	void Start () {
		animvar = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		reg = GetComponent<Rigidbody2D> ();
		float ForceX = Mathf.Abs (reg.velocity.x);
		float ForceY = Mathf.Abs (reg.velocity.y);
		if (ForceY < 0.2f)
			standing = true;
		else
			standing = false;
		

		var NewX = 0f;
		var NewY = 0f;
		if(Input.GetKey("right")){ // when click irro right in keyborad
			if (ForceX < MaxVelocity.x) {
				NewX = standing ? speed : speed * SpeedSlow;
				animvar.SetInteger ("AnimTrans", 1);
				AudioSource.PlayClipAtPoint (audioClip, transform.position);
			}
			else
				animvar.SetInteger ("AnimTrans", 0);
			transform.localScale = new Vector3 (1, 1, 1);
		}
		else if(Input.GetKey("left")){  
			if(ForceX<MaxVelocity.x){
			NewX=standing? -speed:-speed*SpeedSlow;
			animvar.SetInteger ("AnimTrans", 1);
				AudioSource.PlayClipAtPoint (audioClip, transform.position);
		}
		else
			animvar.SetInteger ("AnimTrans", 0);
			
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		else if(Input.GetKey("up")){ 
			if(ForceY<MaxVelocity.y)
			{NewY=speed;
			animvar.SetInteger ("AnimTrans", 2);
		}
		else
			animvar.SetInteger ("AnimTrans", 0);
			transform.localScale = new Vector3 (1, 1, 1);
		}

		//print ("x:" + reg.velocity.x);
		reg.AddForce (new Vector2 (NewX, NewY));
	}
}

//public AudioClip audioclip;
//	AudioSource.PlayClipAtPoint (audioclip, transform.position);
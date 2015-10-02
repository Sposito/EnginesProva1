using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {
	public float speed = 20f;
	Rigidbody rb;

	private bool touchingPlataform;
	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		MovePlayer();
	}

	void MovePlayer(){
		if(touchingPlataform){
			rb.AddForce(Input.GetAxis("Horizontal") * speed, 0f, Input.GetAxis("Vertical") * speed );

		}
	}

	void OnCollisionStay (Collision col)
	{
		if(col.gameObject.tag == "Plataform")
		{
			touchingPlataform = true;
		}
	}

	void OnCollisionExit (Collision col)
	{
		if(col.gameObject.tag == "Plataform")
		{
			touchingPlataform = false;
		}
	}
}

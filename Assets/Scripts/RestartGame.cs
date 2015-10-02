using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class RestartGame : MonoBehaviour {
	Vector3 startPos;
	void Start () {
		startPos = transform.position;
	}
	void OnCollisionEnter (Collision col) {
	 if (col.gameObject.tag == "Terrain"){
			transform.position = startPos;
			GetComponent<Rigidbody>().velocity = Vector3.zero;
	}
	}
	
	// Update is called once per frame

}

using UnityEngine;
using System.Collections;

public class FinishGame : MonoBehaviour {

	Vector3 startPos;
	void Start () {
		startPos = transform.position;
	}
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "END"){
			Application.LoadLevel(0);
		}
	}
	
	// Update is called once per frame

}

using UnityEngine;
using System.Collections;

public class RotatePlataform : MonoBehaviour {
	public float rotX;
	public float rotY;
	public float rotZ;

	public bool trigger = false;

	#if UNITY_EDITOR
	void OnDrawGizmosSelected() {
		Gizmos.DrawSphere(transform.position, 0.5f);
	}
	#endif
	
	// Update is called once per frame
	void Update () {
		if(trigger) transform.Rotate(rotX,rotY,rotZ);
	}

	public void SetTrigger(){
		trigger = true;
	}
}

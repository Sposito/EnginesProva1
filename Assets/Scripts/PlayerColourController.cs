using UnityEngine;
using System.Collections;
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerColourController : MonoBehaviour {
	MeshRenderer mR;
	Rigidbody rB;
	Material glow;
	Color assignedColor;


	// Use this for initialization
	void Start () {
		mR = GetComponent<MeshRenderer>();
		rB = GetComponent<Rigidbody>();
		glow = mR.materials[1];
		assignedColor = glow.color;
	}
	
	// Update is called once per frame
	void Update () {
		if (rB.velocity.magnitude < 0.1f){
			glow.color = Color.black;

		}
		else{
			glow.color = assignedColor;
		}
	}


}

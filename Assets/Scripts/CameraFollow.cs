using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	private Vector3 playerDist;
	void Start () {
		playerDist = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentDist = transform.position - player.transform.position  ;
		transform.position += playerDist - currentDist; 
	}
}

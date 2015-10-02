using UnityEngine;
using System.Collections;

public class SetTrigger : MonoBehaviour {

	void OnTriggerEnter(){
		if(transform.parent.GetComponent<RotatePlataform>() != null)
			transform.parent.SendMessage("SetTrigger");
	}
}

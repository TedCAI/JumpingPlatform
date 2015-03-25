using UnityEngine;
using System.Collections;

public class reloadfail : MonoBehaviour {

void OnCollisionEnter(Collision collision) 
	{

		//Application.LoadLevel (Application.loadedLevel);

	}
	
	void OnTriggerEnter(Collider collider){
		collider.GetComponent<JumpGameController> ().i -= 1;
		int i = collider.GetComponent<JumpGameController> ().i;
		collider.rigidbody.velocity = new Vector3 (0, 0, 0);
		collider.GetComponent<JumpGameController> ().isJumping = false;
		collider.transform.position = collider.GetComponent<JumpGameController> ().platforms [i-1].transform.position;
	}
}

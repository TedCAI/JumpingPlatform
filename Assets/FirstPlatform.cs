using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FirstPlatform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GameObject.Find("Player").GetComponent<JumpGameController> ().i += 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		GameObject.Find ("FadeInAndOut").GetComponent<SceneFadeInOut> ().sceneStarting = true;
		other.rigidbody.velocity = new Vector3 (0, 0, 0);
		other.transform.position = new Vector3 (transform.parent.position.x, other.transform.position.y, transform.parent.position.z);
		other.GetComponent<JumpGameController> ().isJumping = false;
		//Destroy (gameObject);
		other.GetComponent<JumpGameController> ().i = 1;
		GameObject.Find ("FrontBar").GetComponent<Image> ().fillAmount = 0f;
		Debug.Log ("enter");
	}
	/*
	void OnTriggerStay(Collider other){
		Debug.Log ("stay");
	}
	*/
}

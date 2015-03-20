using UnityEngine;
using System.Collections;

public class PlatformRotater : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		transform.RotateAround (transform.rotation*Vector3.up, Time.deltaTime*0.2f);
			
	}

	void OnTriggerEnter(Collider other)
	{
		transform.RotateAround (transform.rotation*Vector3.up, Time.deltaTime*0.0f);
	}

}

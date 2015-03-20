using UnityEngine;
using System.Collections;

public class PlatformStop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		other.rigidbody.velocity = new Vector3 (0, 0, 0);
		other.transform.position = new Vector3 (transform.parent.position.x, other.transform.position.y, transform.parent.position.z);
		Destroy (gameObject);
	}
}

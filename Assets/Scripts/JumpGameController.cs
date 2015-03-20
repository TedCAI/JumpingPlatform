using UnityEngine;
using System.Collections;

public class JumpGameController : MonoBehaviour {

	float jumpHeight = 3f;
	public Transform[] platforms;

	Vector3 distance;
	int numberOfPlat;
	int i;
	// Use this for initialization
	void Start () {
	
		i = 1;
		numberOfPlat = platforms.Length;

		distance = new Vector3 (0, 0, 0);
	}
	

	// Update is called once per frame
	void FixedUpdate () {

		if (i < numberOfPlat) {

			distance = platforms [i].position - platforms [i-1].position;
			Debug.Log(distance);
			if (Input.GetMouseButtonDown (0)) {
				rigidbody.velocity = new Vector3 (0, Mathf.Sqrt (-2.0f * Physics.gravity.y*jumpHeight ), 0)+ 
					new Vector3 (Mathf.Sqrt (Mathf.Abs(distance.x))* Mathf.Sign(distance.x), Mathf.Sqrt (Mathf.Abs(distance.y))*Mathf.Sign(distance.y), Mathf.Sqrt (Mathf.Abs(distance.z))*Mathf.Sign(distance.z));
					i++;

			}
		}

	}
}

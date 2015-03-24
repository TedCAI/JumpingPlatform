using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JumpGameController : MonoBehaviour {

	float jumpHeight;
	public Transform[] platforms;
	Image energy;
	float percentage;

	bool mouseDown;
	public bool isJumping;

	Vector3 distance;
	int numberOfPlat;
	int i;
	// Use this for initialization
	void Start () {
		//jumpHeight = 3f;
		energy = GameObject.Find ("FrontBar").GetComponent<Image> ();
		energy.fillAmount = 0f;
		jumpHeight = 0f;
		i = 1;
		numberOfPlat = platforms.Length;

		distance = new Vector3 (0, 0, 0);
	}
	
	void Update(){
		if (i < numberOfPlat) {
			energyBar();
			distance = platforms [i].position - platforms [i-1].position;
			//Debug.Log(distance);
			//Debug.Log(transform.position.z );
			if(Input.GetMouseButtonDown(0) && !isJumping){
				mouseDown = true;
			}

			if(Input.GetMouseButton(0) && mouseDown && !isJumping){
				mousePress();
			}

			if (Input.GetMouseButtonUp (0) && mouseDown) {
				mouseRelease();

			}
		}
	}

	void mousePress(){
		//mouseDown = true;
		jumpHeight += 0.01f;
		//Debug.Log(jumpHeight);
	}

	void mouseRelease(){
		isJumping = true;
		rigidbody.velocity = new Vector3 (0, Mathf.Sqrt (-2.0f * Physics.gravity.y*jumpHeight ), 0)+ 
			new Vector3 (Mathf.Sqrt (Mathf.Abs(distance.x))* Mathf.Sign(distance.x), Mathf.Sqrt (Mathf.Abs(distance.y))*Mathf.Sign(distance.y), Mathf.Sqrt (Mathf.Abs(distance.z))*Mathf.Sign(distance.z));
		i++;
		jumpHeight = 0f;
		mouseDown = false;
	}

	void energyBar(){
		percentage = jumpHeight / 5f;
		energy.fillAmount = percentage;
	}
	/*
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
	 */
}

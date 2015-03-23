using UnityEngine;
using System.Collections;

public class CanvasRotation : MonoBehaviour {
	public GameObject player;
	private Vector3 velocity = Vector3.zero;
	private float smoothTime = 1f/90f;
	// Use this for initialization
	void Start () {
		//player = GameObject.Find ("Came");
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<RectTransform>().rotation = player.transform.rotation;
		//Debug.Log (player.transform.forward);
		Vector3 newLocation = player.transform.position;
		newLocation += 300f * player.transform.forward;

		gameObject.GetComponent<RectTransform> ().position = Vector3.SmoothDamp (gameObject.GetComponent<RectTransform> ().position, newLocation, ref velocity, smoothTime);
		//GetComponent<CharacterController> ().Move (newLocation);
		//Debug.Log (gameObject.GetComponent<RectTransform>().rotation);
		//Debug.Log (player.transform.rotation);
	}
}

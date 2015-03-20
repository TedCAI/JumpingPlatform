using UnityEngine;
using System.Collections;

public class ShotFire : MonoBehaviour {

	public ParticleSystem fire;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (fire != null && Input.GetMouseButtonDown(0)) 
		{

			fire.Emit(1);
		}
	
	}
}

using UnityEngine;
using System.Collections;

public class reloadfail : MonoBehaviour {

void OnCollisionEnter(Collision collision) 
	{

		Application.LoadLevel (Application.loadedLevel);

	}
	

}

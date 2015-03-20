using UnityEngine;
using System.Collections;

public class Reload : MonoBehaviour {
	

	void OnCollisionEnter(Collision collision) {


		StartCoroutine("ReloadGame");


		//yield return new WaitForSeconds();
		// ... and then reload the level.
		//Application.LoadLevel ("Scene0");

		}





	IEnumerator ReloadGame()
	{			
		// ... pause briefly
		yield return new WaitForSeconds(2);
		// ... and then reload the level.
		Application.LoadLevel("JumpGame");
	}



}

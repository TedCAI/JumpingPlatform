using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {

	private bool loading;
	private bool loadingComplete;
	private AsyncOperation async;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(loadingComplete)
		{
			async.allowSceneActivation = true;
		}

		if (Input.GetMouseButtonDown (1))
		{
			StartCoroutine(LoadScene0());
		}
	
	}
	IEnumerator LoadScene0() {
		
		async = Application.LoadLevelAsync("Scene0");
		async.allowSceneActivation = false;
		Debug.Log("Loading complete");
		loadingComplete = true;
		yield return null;
		
	}
}

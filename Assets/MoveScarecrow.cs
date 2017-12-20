using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScarecrow : MonoBehaviour {

	private GameObject scarecrow;
	// Use this for initialization
	void OnTriggerEnter(Collider col)
	{
		if (this.enabled) 
		{
			this.enabled = false;
			GameObject scarecrow = GameObject.Find ("Scarecrow1");
			Debug.Log ("Object entered the trigger.");
			scarecrow.transform.position = new Vector3 ((float)418.209, (float)0.12, (float)417.428);
			scarecrow.GetComponent<AudioSource> ().Play ();
		}
	}

	void OnTriggerExit(Collider col)
	{
		GameObject scarecrow = GameObject.Find ("Scarecrow1");
		var destroyTimer = 4.5;
		Destroy (scarecrow, (float) destroyTimer);
	}
}

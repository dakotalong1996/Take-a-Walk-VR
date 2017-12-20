using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimScript : MonoBehaviour {

	private Animator anim;
	private GameObject crawler;
	private bool ready;
	private float speed;
	private float distance;
	private float xStartPosition;


	void Start () {
		xStartPosition = transform.position.x;
	}

	void OnTriggerEnter(Collider col)
	{
		Debug.Log ("Entered second trigger.");
		if (this.enabled) 
		{
			GameObject crawler = GameObject.Find ("crawler");
			anim = crawler.GetComponent<Animator> ();
			ready = true;
			this.enabled = false;
		}
	
	}

	// Update is called once per frame
	void Update () {
		if (ready == true)
		{
			speed *= -1;
			crawler.transform.position = new Vector3 (transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
		}

	}
}

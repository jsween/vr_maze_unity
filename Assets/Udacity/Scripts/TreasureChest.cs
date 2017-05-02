using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour {

	public int openSpeed = 50;
	public bool isDoorUnlocked = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isDoorUnlocked && (transform.rotation.x > 1.2000000E-07f)) {
			OpenChest ();
		}
	}

	//Rotate the top chest
	void OpenChest() {
		transform.Rotate(Vector3.right * openSpeed * Time.deltaTime);
	}
}

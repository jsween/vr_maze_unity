using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTop : MonoBehaviour {

	public int openSpeed = 50;
	public bool isDoorOpened = false;
	
	// Update is called once per frame
	void Update () {
		if(isDoorOpened && (transform.rotation.x > 1.2000000E-07f)) {
			OpenChest ();
		}
	}

	//Rotate the top chest
	public void OpenChest() {
		transform.Rotate(Vector3.right * openSpeed * Time.deltaTime);
	}
		
}

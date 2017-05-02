using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public Door door;

	public int spinSpeed = 50;

	public static bool isKeyCollected = false;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
		transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime, Space.World);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		Instantiate(keyPoof, transform.position, Quaternion.Euler(270f, 0f, 0f));
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
		door.Unlock();
        // Set the Key Collected Variable to true
		isKeyCollected = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}

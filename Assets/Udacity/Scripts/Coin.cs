using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;

	public int spinSpeed = 100;

	void Update() {
		transform.Rotate (Vector3.up * Time.deltaTime * spinSpeed, Space.World);
	}

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		Instantiate(coinPoof, transform.position, Quaternion.Euler(270f, 0f, 0f));
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}

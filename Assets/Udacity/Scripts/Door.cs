using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Door : MonoBehaviour 
{
	public ChestTop chestTop;
	public AudioClip unlockedDoorSound;
	public AudioClip lockedDoorSound;
	private AudioSource doorSoundPlayer;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	public bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
	private bool opening = false;
	// Height of door, measured for raising along y axis
	private float doorHeight;

	void Start() {
		doorSoundPlayer = GetComponent<AudioSource> ();
	}

    void Update() {
		doorHeight = transform.position.y;
        // If the door is opening and it is not fully raised
		if ((!locked) && opening && doorHeight < 7) {
			// Animate the door raising up
			raiseDoor();
		}
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
		if (!locked) {
			// Set the "opening" boolean to true
			opening = true;
			doorSoundPlayer.clip = unlockedDoorSound;
			doorSoundPlayer.Play ();
			chestTop.isDoorOpened = true;
		} else {
			// (optionally) Else
			// Play a sound to indicate the door is locked
			doorSoundPlayer.clip = lockedDoorSound;
			doorSoundPlayer.Play ();
		}
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }

	public void raiseDoor() {
		transform.Translate (0, 1 * Time.deltaTime, 0, Space.World);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    // Properties.

    GameObject player;

	// Use this for initialization
	void Start () {
        // Find player gameobject.
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void LateUpdate () {
		// Set camera position to be the same as player position on every frame.
        if (player != null)
        {
            transform.position = player.transform.position;
        }
	}
}

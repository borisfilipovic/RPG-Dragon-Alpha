using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

    // Properties.

    CameraRaycaster cameraRaycaster;

	// Use this for initialization
	void Start () {
        // Find raycaster camera.
        findRaycasterCamera();
	}
	
	// Update is called once per frame
	void Update () {
        print(cameraRaycaster.layerHit);
	}

    // Find raycaster camera.
    private void findRaycasterCamera()
    {
        cameraRaycaster = GetComponent<CameraRaycaster>();
    }
}

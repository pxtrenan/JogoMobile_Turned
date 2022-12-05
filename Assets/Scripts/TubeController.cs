using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeController : MonoBehaviour {

    private Vector3 clickPos;
    private bool mouseDown = false;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseDown = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            
            mouseDown = false;
        }
        if (mouseDown)
        {
            Vector3 currentMPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float move = Vector3.Distance(clickPos, currentMPos);

            Quaternion currentRotation = transform.rotation;
            currentRotation.y = move * Time.deltaTime;
            transform.rotation = currentRotation;
            
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour {

    public GameObject rotateController;

    private float speed = 250f;

    private void OnMouseDrag()
    {
        float rotz = Input.GetAxis("Mouse Y") * speed * Mathf.Deg2Rad;
        
        rotateController.transform.Rotate(Vector3.forward * -rotz);
                
        
    }

}

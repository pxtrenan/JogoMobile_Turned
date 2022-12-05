using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCenario : MonoBehaviour {

    private float speed;
    public float z;



    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


        speed = -17.7f;
        z = transform.position.z;

        z += speed * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, transform.position.y, z);

        if (z <= -35)
        {

            Destroy(transform.gameObject);
        }

    }


}

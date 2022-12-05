using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointWall : MonoBehaviour {

        
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {

            LevelManager.levelManager.SetScore();

        }
    }
   
}

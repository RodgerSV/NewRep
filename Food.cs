using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[DisallowMultipleComponent]

public class Food : MonoBehaviour
{
         
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Snakemain"))
        {
            
            other.GetComponent<SnakeMove>().AddTail();
            Destroy(gameObject);
        }
    }    
    
}

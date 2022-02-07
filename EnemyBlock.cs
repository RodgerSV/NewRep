using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBlock : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {                
            gameObject.SetActive(false);
       
    }
}

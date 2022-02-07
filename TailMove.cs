using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TailMove : MonoBehaviour
{
    public float Speed;
    public Vector3 tailTarget;
    public int index;
    public SnakeMove mainSnake;
    public GameObject tailObject;

    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("Snakemain").GetComponent<SnakeMove>();
        Speed = mainSnake.Speed +1.5f;
        tailObject = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        index = mainSnake.tailObjects.IndexOf(gameObject);
    }
    void Update() 
    {
        tailTarget = tailObject.transform.position; 
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * Speed);
    }
    public void OnTriggerEnter(Collider other)
    { if (other.CompareTag("Snakemain"))

       {
             if (index > 2) 
            {
                SceneManager.LoadScene(0);

            }          
        }
            
    }
}





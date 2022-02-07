using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]

public class moveObjekt : MonoBehaviour

{   [SerializeField] Vector3 movePos;
    [SerializeField] [Range(0,1)]float moveProg;
    [SerializeField] float moveSpeed;
     Vector3 startPos;

    
    void Start()
    { startPos = transform.position;
        
    }

    
    void Update()
    {   moveProg = Mathf.PingPong(Time.time*moveSpeed,1);
        
        Vector3 offset = movePos * moveProg;
        transform.position = startPos + offset;
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject capsule;
    Transform spawn;
    
    void Start()
    {
        spawn = GameObject.Find("Spawn").transform;
        GameObject pos = Instantiate(capsule);
        pos.transform.position = spawn.position;
       
    }

    
    void Update()
    {
        
    }
}

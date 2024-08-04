using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -4);
        
    }


}

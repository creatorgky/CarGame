using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainFuel : MonoBehaviour
{
    

    private void Start()
    {
  

    }
    public void OnTriggerEnter(Collider other)
    {
        GasolineTimer.max_time += 0f;
        Destroy(gameObject);

    }

}

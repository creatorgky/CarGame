using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GasolineTimer : MonoBehaviour
{
    float time_remaining;
    public float max_time = 5f;
    public Image fuelbar;

    // Start is called before the first frame update
    void Start()
    {
        time_remaining = max_time;
    }

    // Update is called once per frame
    void Update()
    {
        if (time_remaining > 0)
        {
            time_remaining -= Time.deltaTime;
            fuelbar.fillAmount = time_remaining / max_time;
        }

        if (time_remaining < 0)
        {
            Destroy(gameObject);
        }

    }

   
}

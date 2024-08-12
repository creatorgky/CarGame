using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour
{
    CarHealth healthBar;
    float maxHealth = 100f;
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<CarHealth>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public CarHealth1 carHealth;
    public int damage = 50;

    private void Start()
    {
        carHealth = GameObject.FindObjectOfType<CarHealth1>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Car")
        {
            carHealth.TakeDamage(damage);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Car")
        {
            Destroy(gameObject);
        }
    }



}

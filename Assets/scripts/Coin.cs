using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float turnSpeed = 90f;
    public float speed = 5f;
    public Rigidbody rb;
    public GameObject coinPrefab;
    public GameObject whellPrefab;
    public GameObject bucketPrefab;
    public GameObject wrenchPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0,0, turnSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (coinPrefab)
        {
            if (collision.gameObject.name == "Car")
            {
                CarManager.numberOfCoins += 1;
                Destroy(gameObject);
            }
        }

        if (whellPrefab)
        {
            if (collision.gameObject.name == "Car")
            {
                CarManager.numberOfWhells += 1;
                Destroy(gameObject);
            }
        }

        if (wrenchPrefab)
        {
            if (collision.gameObject.name == "Car")
            {
                CarManager.numberOfWrench += 1;
                Destroy(gameObject);
            }
        }

        if (bucketPrefab)
        {
            if (collision.gameObject.name == "Car")
            {
                CarManager.numberOfBucket += 1;
                Destroy(gameObject);
            }
        }
    }
}
 
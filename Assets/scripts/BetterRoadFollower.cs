using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterRoadFollower : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rb;
    public float maxSpeed;

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove);
    }

    // Update is called once per frame
    void Update()
    {
        if (speed < maxSpeed)
        {
            speed += 0.3f * Time.deltaTime;
        }
    }
}

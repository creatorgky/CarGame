using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CarControl3 : MonoBehaviour
{
    public float carSpeed = 10f;
    private Rigidbody rb;
    public float tilt;
    public float swipeSpeed = 90;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        tilt = Input.acceleration.x * swipeSpeed;
        Vector3 movement = transform.forward * carSpeed * Time.deltaTime;
        rb.MovePosition(rb.position +  movement);

        Quaternion targetRotation = Quaternion.Euler(0, tilt, 0);
        rb.MoveRotation(Quaternion.Lerp(rb.rotation, targetRotation, 1 * Time.fixedDeltaTime));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    Rigidbody rb;

    bool left;
    bool right;

    public float speed = 5.0f;
    public float maxSpeed;
    public float swipeSpeed = 1.2f;

    Animator animator;

    public float carSpeed = 10f;
    public float tilt;
   


    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        tilt = Input.acceleration.x * 90;
        Vector3 movement = transform.forward * carSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);

        Quaternion targetRotation = Quaternion.Euler(0, tilt, 0);
        rb.MoveRotation(Quaternion.Lerp(rb.rotation, targetRotation, 1 * Time.fixedDeltaTime));

        transform.Translate(0,0, speed * Time.deltaTime);

        
        Vector3 go_rigth = new Vector3(16f, transform.position.y, transform.position.z);
        Vector3 go_left = new Vector3(-8f, transform.position.y, transform.position.z);


        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);

            if (finger.deltaPosition.x > 30.0f)
            {
                right = true;
                left = false;
            }

            if (finger.deltaPosition.x < -30.0f)
            {
                right = false;
                left = true;
            }

            if (right == true)
            {
                transform.position = Vector3.Lerp(transform.position, go_rigth, swipeSpeed * Time.deltaTime);
                animator.SetBool("IsCarGoesRight", true);
            }
            else 
            {
                animator.SetBool("IsCarGoesRight", false);
            }

            if (left == true)
            {
                transform.position = Vector3.Lerp(transform.position, go_left, swipeSpeed * Time.deltaTime);
                animator.SetBool("IsCarGoesLeft", true) ;
            }
            else  
            {
                animator.SetBool("IsCarGoesLeft", false);

            }
        }

        if (speed < maxSpeed)
        {
            speed += 0.3f * Time.deltaTime;
        }

       
    }

}

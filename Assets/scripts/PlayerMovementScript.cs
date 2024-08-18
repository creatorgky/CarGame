using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementScript : MonoBehaviour
{
    public float speed;
    private Vector2 move;
    private Vector3 rotationTarget;

    void Update()
    {
        movePlayer();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    private void movePlayer()
    {
        Vector3 movement = new Vector3(-move.x, 0f,- move.y);

        if (movement != Vector3.zero)
        {
            rotationTarget = Quaternion.LookRotation(movement).eulerAngles;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(rotationTarget), 0.15f);
        }

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}

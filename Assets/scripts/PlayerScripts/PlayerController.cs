using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerAnimator))]
public class NewBehaviourScript : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private MobileJoystick joystick;
    [SerializeField] private PlayerAnimator playerAnimator;
    private CharacterController characterController;
    [Header("Settings")]
    [SerializeField] private float moveSpeed;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerAnimator = GetComponent<PlayerAnimator>();
    }

    void Update()
    {
        ManageMovement();
    }

    private void ManageMovement()
    {
        Vector3 moveVector = joystick.GetMoveVector() * moveSpeed * Time.deltaTime /Screen.width;

        moveVector.z = moveVector.y;
        moveVector.y=0;

        characterController.Move(moveVector);

        playerAnimator.ManageAnimations(moveVector);
    }
}

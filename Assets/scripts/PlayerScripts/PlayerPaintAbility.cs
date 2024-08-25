using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerAnimator))]
public class PlayerPaintAbility : MonoBehaviour
{
    [Header("Elements")]
    private PlayerAnimator playerAnimator;
    void Start()
    {
        playerAnimator = GetComponent<PlayerAnimator>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WashCricle"))
            playerAnimator.PlayPaintAnimaton();
            Debug.Log("Zort");
    }

    private void OnTriggerExit(Collider other)
    {

    }
}

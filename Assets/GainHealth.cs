using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainHealth : MonoBehaviour
{
    [SerializeField] CarHealth1 carHealth;

    private void OnTriggerEnter(Collider other)
    {
        HealtBar.health += 50f;
        CarHealth1.health += 50;
        Destroy(gameObject);
    }
}

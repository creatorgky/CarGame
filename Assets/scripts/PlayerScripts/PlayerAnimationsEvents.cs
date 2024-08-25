using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationsEvents : MonoBehaviour
{
    [Header ("Elements")]
    [SerializeField] private ParticleSystem paintParticles;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayPaintParticles()
    {
        paintParticles.Play();
    }
}

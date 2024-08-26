using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth1 : MonoBehaviour
{
    [SerializeField] public static int health;
    public int maxHealth = 100;

    public GameOverScreen game_Over;
  
    private bool isDead;
  

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
     
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <=0 && !isDead)
        {
            isDead = true;
            game_Over.gameOver();
            Debug.Log("Dead");
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

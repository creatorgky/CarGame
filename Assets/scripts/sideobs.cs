using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sideobs : MonoBehaviour
{
   public  GameOverScreen gameOverScreen;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            gameOverScreen.gameOver();
            Debug.Log("Dead");
        }
    }
}

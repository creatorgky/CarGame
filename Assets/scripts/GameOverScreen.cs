using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
   
    public GameObject gameOverUI;

    void Start()
    {
       //scoreManager = GetComponent<ScoreManager>();
      // scoreManager.scoreText = currentScore;

    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }


    public void RestardButton()
    {
        SceneManager.LoadScene("Runner");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Main Garage");
    }



}

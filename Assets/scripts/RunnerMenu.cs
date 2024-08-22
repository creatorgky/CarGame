using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunnerMenu : MonoBehaviour
{
  public void PlayGame()
    {
        SceneManager.LoadScene("Runner");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Garage");
    }
}

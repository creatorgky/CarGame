using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;
    public static float scoreCount;
    public static float hiScoreCount;
    public float pointIncreasedPerSecond = 0.5f;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetInt("HighScore");
           // scoreText = scoreText.GetComponent<Text>();
         //   PlayerPrefs.SetString("currentScore", "0");
        }
    }

    void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
           
           // PlayerPrefs.SetString("currentScore", scoreText.text);

        }

        scoreText.text = "score:" + Mathf.Round(scoreCount);
        hiScoreText.text = "Hi-Score:" + hiScoreCount;
        ScoreManager.scoreCount += 1;
        ScoreManager.hiScoreCount += 1;
        scoreCount += pointIncreasedPerSecond * Time.fixedDeltaTime;


            
    }
}

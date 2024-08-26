using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GasolineTimer : MonoBehaviour
{
    public static float time_remaining;
    public static float max_time = 50f;
    public Image fuelbar;

    public GameOverScreen game_Over;
    private bool isDead;


    // Start is called before the first frame update
    void Start()
    {
        time_remaining = max_time;
    }

    // Update is called once per frame
    void Update()
    {
        if (time_remaining >0)
        {
            time_remaining -= Time.deltaTime;
            fuelbar.fillAmount = time_remaining / max_time;
        }

        if (time_remaining <0 && !isDead)
        {
            isDead = true;
            game_Over.gameOver();
            Debug.Log("Dead");
        }

    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBar : MonoBehaviour
{
    Image healtbar;
    float maxHealt = 500f;
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
        healtbar = GetComponent<Image>();
        health = maxHealt;
    }

    // Update is called once per frame
    void Update()
    {
        healtbar.fillAmount = health / maxHealt;
    }
}

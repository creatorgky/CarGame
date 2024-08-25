using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarManager : MonoBehaviour
{
    public static int numberOfCoins;
    public static int numberOfWhells;
    public static int numberOfBucket;
    public static int numberOfWrench;

    public Text coinsText;
    public Text whellsText;
    public Text bucketText;
    public Text wrenchText;

    // Start is called before the first frame update
    void Start()
    {
        numberOfCoins = 0;  
        numberOfWhells = 0;
        numberOfBucket = 0;
        numberOfWrench = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins:" + numberOfCoins;
        whellsText.text = "Whells:" + numberOfWhells;
        bucketText.text = "Buckets:" + numberOfBucket;
        wrenchText.text = "Wrenchs:" + numberOfWrench;
    }
}

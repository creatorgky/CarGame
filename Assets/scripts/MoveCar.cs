using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;

    public float horizVel = 0;
    public int laneNum = 2;
    public string ControlLocked = "n";


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, +4);

        if ((Input.GetKeyDown (moveL))&& ((laneNum>1)&& (ControlLocked == "n"))
 )
        {
            horizVel = 7;
            StartCoroutine (StopSlide());
            laneNum -= 1;
            ControlLocked = "y";
              
        }

        if ((Input.GetKeyDown(moveR))&& ((laneNum<3)) && (ControlLocked == "n"))
        {
            horizVel = -7;
            StartCoroutine(StopSlide());
            laneNum += 1;
            ControlLocked = "y";

        }

    }

    IEnumerator StopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        ControlLocked = "n";


    }
}

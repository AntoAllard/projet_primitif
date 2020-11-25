using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 30;
    public bool takingAway = false;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = "" + secondsLeft;
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10 && secondsLeft >= 1)
        {
            textDisplay.GetComponent<Text>().text = "0" + secondsLeft;
        }

        else if (secondsLeft == 0)
        {
            textDisplay.GetComponent<Text>().text = "Trouve le lingot";
        }

        else
        {
            textDisplay.GetComponent<Text>().text = "" + secondsLeft;
        }
        takingAway = false;
    }
}

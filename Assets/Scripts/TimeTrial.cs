using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeTrial : MonoBehaviour
{
    public static TimeTrial instance { get; private set; }
    public int duration = 60;
    public int timeRemaining;
    public bool isCountingDown = false;
    public TMP_Text TimeTrialText;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        TimeTrialText.text = "Timer Available";
    }
    public void startTimer()
    {
        if (!isCountingDown)
        {
            isCountingDown = true;
            timeRemaining = duration;
            Invoke("_tick", 1f);
        }
    }

    private void _tick()
    {
        timeRemaining--;
        if (timeRemaining > 0 &&isCountingDown==true)
        {
            //Update Text
            TimeTrialText.text = "Time Left: " +  timeRemaining.ToString();
            Debug.Log(timeRemaining.ToString());
            Invoke("_tick", 1f);
        }
        else
        {
            GameOver.instance.loseGame();
            isCountingDown = false;
        }
    }
    public void stopTimer()
    {
        Debug.Log("Timer Stopped");
        isCountingDown=false;
    }
}

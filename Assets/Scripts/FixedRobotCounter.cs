using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FixedRobotCounter : MonoBehaviour
{
    public static FixedRobotCounter instance { get; private set; }
    public int fixedRobots = 0;
    public int theMaxRobots = 2;

    public TMP_Text fixedRobotText;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        fixedRobotText.text = "Fixed Robots: " + fixedRobots.ToString();
    }
    public void IncreaseRobotCounter()
    {
        fixedRobots++;
        fixedRobotText.text = "Fixed Robots: " + fixedRobots.ToString();
        Debug.Log("Fixed Robots: " + fixedRobots);
        Debug.Log("Max Robots: " + theMaxRobots);
        if (fixedRobots == theMaxRobots)
        {
            GameOver.instance.winGame();
        }
    }
}

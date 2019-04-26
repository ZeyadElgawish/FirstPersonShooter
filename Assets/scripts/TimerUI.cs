using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerUI : MonoBehaviour
{
    float TimeLeft = 10f;
    GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeLeft -= Time.deltaTime;

        if (TimeLeft < 0)
        {
            GameOver();

        }
    }

    private void GameOver()
    {
        GUI.Label(new Rect(10, 10, 100, 20), " Game Over");
    }
}

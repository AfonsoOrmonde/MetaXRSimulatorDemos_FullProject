using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    float elapsedTime;
    public TextMeshProUGUI timerText;
    void Start()
    {
        elapsedTime = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        int hours = Mathf.FloorToInt(elapsedTime / 3600);
        int minutes = Mathf.FloorToInt((elapsedTime % 3600) / 60);
        int seconds = Mathf.FloorToInt( elapsedTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    public int daysLeft = 0;
    public int hoursLeft = 0;
    public int minutesLeft = 0;

    public TextMeshProUGUI countdownText;

    private float totalTimeInSeconds;
    private string filePath;

    private void Start()
    {
       
        filePath = Application.persistentDataPath + "/countdown.txt";


        if (File.Exists(filePath))
        {
            string[] data = File.ReadAllLines(filePath);
            if (data.Length > 0)
            {
                if (float.TryParse(data[0], out float savedTotalTime))
                {
                    totalTimeInSeconds = savedTotalTime;
                }
                else
                {
                    totalTimeInSeconds = daysLeft * 86400 + hoursLeft * 3600 + minutesLeft * 60;
                }
            }
            else
            {
                totalTimeInSeconds = daysLeft * 86400 + hoursLeft * 3600 + minutesLeft * 60;
            }
        }
        else
        {
            totalTimeInSeconds = daysLeft * 86400 + hoursLeft * 3600 + minutesLeft * 60;
        }
    }

    private void Update()
    {
        if (totalTimeInSeconds > 0)
        {
           
            int remainingDays = Mathf.FloorToInt(totalTimeInSeconds / 86400f);
            int remainingHours = Mathf.FloorToInt((totalTimeInSeconds - remainingDays * 86400f) / 3600f);
            int remainingMinutes = Mathf.FloorToInt((totalTimeInSeconds - remainingDays * 86400f - remainingHours * 3600f) / 60f);

            countdownText.text = "Time Left: " + remainingDays.ToString("00") + "d " + remainingHours.ToString("00") + "h " + remainingMinutes.ToString("00") + "m";

          
            totalTimeInSeconds -= Time.deltaTime;
        }
        else
        {
            countdownText.text = "Time's Up!";
        }
    }


private void OnApplicationQuit()
    {
      
        string[] data = new string[1];
        data[0] = totalTimeInSeconds.ToString();
        File.WriteAllLines(filePath, data);
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        
        string[] data = new string[1];
        data[0] = totalTimeInSeconds.ToString();
        File.WriteAllLines(filePath, data);
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        
        string[] data = new string[1];
        data[0] = totalTimeInSeconds.ToString();
        File.WriteAllLines(filePath, data);
    }
}

using System;
using System.Collections;
using UnityEngine;

public class DayTime : MonoBehaviour
{
    DateTime currentTime = DateTime.Today.AddHours(9);
    
    public float timeMultiplier = 5f;
    void Start()
    {
        StartCoroutine(StartTimerCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator StartTimerCoroutine()
    {
        while (true)
        {
            currentTime = currentTime.AddMinutes(timeMultiplier);
            Debug.Log(currentTime.ToString("HH:mm"));
            yield return new WaitForSeconds(timeMultiplier);
        }
    }
}

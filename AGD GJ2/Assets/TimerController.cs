using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    public static TimerController instance;
    public float timer;
    GameObject[] timerObjects;

    void Awake()
    {
        instance = this;
        timerObjects = GameObject.FindGameObjectsWithTag("timerObject");
    }

    // Use this for initialization
    void Start () {
        timer = 10f;
	}
	
	// Update is called once per frame
	void Update () {
        Timer();
    }

    private void Timer()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            foreach (GameObject o in timerObjects)
            {
                o.GetComponentInChildren<Text>().text = Math.Round(timer).ToString();
            }
        }
        else
        {
            // Player Died
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public FloatVar timer;

    // Use this for initialization
    void Start ()
    {
        timer._floatVar = 10f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Timer();
    }

    private void Timer()
    {
        if (timer._floatVar >= 0)
        {
            timer._floatVar -= Time.deltaTime;
        }
    }
}

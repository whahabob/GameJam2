using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{
    public FloatVar timeLeft;
    public Text text;
	
	// Update is called once per frame
	void Update ()
    {
        text.text = Mathf.Round(timeLeft._floatVar).ToString();
    }
}

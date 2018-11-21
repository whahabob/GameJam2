using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public FloatVar timer;
    public Color color;
    private Light light;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(timer._floatVar <= 5f)
        {
            light.color = color;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public FloatVar timer;
    public Color color;
    private Color originalColor;
    private Light light;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        originalColor = light.color;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(timer._floatVar <= 5f)
        {
            light.color = color;
        } else if(timer._floatVar > 5f)
        {
            light.color = originalColor;
        }
	}
}

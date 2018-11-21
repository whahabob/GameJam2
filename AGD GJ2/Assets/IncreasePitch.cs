using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasePitch : MonoBehaviour {

    public FloatVar timer;
    private AudioSource audioSource;
    public float maxPitch;
    public float minPitch;
    public float increasePitch;
    public float decreasePitch;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(timer._floatVar <= 5f && audioSource.pitch <= maxPitch)
        {
            audioSource.pitch += increasePitch;
        } else if(timer._floatVar > 5f && audioSource.pitch >= minPitch)
        {
            audioSource.pitch -= decreasePitch;
        }
	}
}

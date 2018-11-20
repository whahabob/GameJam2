using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour {

    public FloatVar timer;
    private AudioSource audioSource;
    private bool hasPlayed;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        hasPlayed = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(timer._floatVar <= 5f && !hasPlayed)
        {
            audioSource.Play(0);
            hasPlayed = true;
        }
	}
}

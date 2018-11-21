using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowDeath : MonoBehaviour {
    public FloatVar death;
    public Text deathText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        deathText.text = death._floatVar.ToString();
	}
}

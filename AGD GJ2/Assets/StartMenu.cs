using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class StartMenu : MonoBehaviour {

    public GameObject player;
    private Button button;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        player.GetComponent<FirstPersonController>().enabled = false;
        button = GetComponentInChildren<Button>();
        button.onClick.AddListener(startGame);
    }
	
	// Update is called once per frame
	void Update () {

	}

    void startGame()
    {
        Time.timeScale = 1;
        player.GetComponent<FirstPersonController>().enabled = true;
        gameObject.SetActive(false);
    }
}

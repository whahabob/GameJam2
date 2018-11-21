using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Transform respawnPoint;
    [SerializeField]
    private ActiveDoors activeDoors;
    [SerializeField]
    private FloatVar time;
    [SerializeField]
    private float startTime;
    [SerializeField]
    private GameObject deathEffect;
    [SerializeField]
    private AudioClip audioClip;

    private GameObject deathInstanceEffect;

    private bool respawning;

    private void Start()
    {
        respawning = false;
        time._floatVar = startTime;
    }

    private void Update()
    {
        if (time._floatVar <= 0 && !respawning)
        {
            respawning = true;
            RespawnPlayer(gameObject.GetComponent<Collider>());
        }
    }

    public void RespawnPlayer(Collider other)
    {
        StartCoroutine(RespawnPlayerDelay(other));

        GetComponent<AudioSource>().PlayOneShot(audioClip);
        deathInstanceEffect = Instantiate(deathEffect, player);
    }

    IEnumerator RespawnPlayerDelay(Collider other)
    {
        yield return new WaitForSeconds(1);
       
        other.transform.position = respawnPoint.position;
        player.GetComponent<FirstPersonController>().m_MouseLook.respawn = true;

        /*
        other.GetComponentInChildren<FirstPersonController>().enabled = false;
        other.transform.rotation = respawnPoint.rotation;
        other.GetComponentInChildren<Transform>().rotation = respawnPoint.rotation;
        other.GetComponentInChildren<FirstPersonController>().enabled = true;
        */

        activeDoors.resetDoors();
        time._floatVar = startTime;
        respawning = false;
        Destroy(deathInstanceEffect);
    }
}

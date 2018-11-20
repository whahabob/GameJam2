using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void Start()
    {
        time._floatVar = startTime;
    }

    public void RespawnPlayer(Collider other)
    {
        StartCoroutine(RespawnPlayerDelay(other));
        Debug.Log("Death");
        Instantiate(deathEffect, player.position);
    }

    IEnumerator RespawnPlayerDelay(Collider other)
    {
        yield return new WaitForSeconds(2);

        other.transform.position = respawnPoint.position;
        activeDoors.resetDoors();
        time._floatVar = startTime;
    }
}

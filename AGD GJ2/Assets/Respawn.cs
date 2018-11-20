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

    private void Start()
    {
        time._floatVar = startTime;
    }

    public void RespawnPlayer(Collider other)
    {
        StartCoroutine(RespawnPlayerDelay(other));
    }

    IEnumerator RespawnPlayerDelay(Collider other)
    {
        yield return new WaitForSeconds(2);

        other.transform.position = respawnPoint.position;
        activeDoors.resetDoors();
        time._floatVar = startTime;
    }
}

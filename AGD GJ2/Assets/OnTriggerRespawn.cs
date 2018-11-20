using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerRespawn : MonoBehaviour
{
    [SerializeField]
    private Transform respawnPoint;

    [SerializeField]
    private Transform door;

    [SerializeField]
    private ActiveDoors activeDoors;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            RespawnEffect();
            StartCoroutine(respawn(other));
            activeDoors.openDoors.Add(door.gameObject);
        }
    }

    private void RespawnEffect()
    {

    }

    IEnumerator respawn(Collider other)
    {
        yield return new WaitForSeconds(2);

        other.transform.position = respawnPoint.position;
        activeDoors.resetDoors();
    }
}

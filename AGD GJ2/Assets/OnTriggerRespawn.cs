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

    [SerializeField]
    private FloatVar time;

    [SerializeField]
    private DoorData doorData;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !doorData.doorActivated)
        {
            doorData.doorActivated = true;
            other.GetComponent<Respawn>().RespawnPlayer(other);
            activeDoors.openDoors.Add(door.gameObject);
        }
    }
}

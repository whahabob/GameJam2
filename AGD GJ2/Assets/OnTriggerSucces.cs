using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerSucces : MonoBehaviour
{
    [SerializeField]
    private Transform door;

    [SerializeField]
    private ActiveDoors activeDoors;

    [SerializeField]
    private FloatVar time;

    [SerializeField]
    private float timeToIncrease;

    [SerializeField]
    private DoorData doorData;

    [SerializeField]
    private AudioClip audioClip;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !doorData.doorActivated)
        {
            GetComponent<AudioSource>().PlayOneShot(audioClip);
            doorData.doorActivated = true;
            SuccesEffect();
            activeDoors.openDoors.Add(door.gameObject);
            time._floatVar += timeToIncrease;
            //activeDoors.resetDoors();
        }
    }

    private void SuccesEffect()
    {

    }
}

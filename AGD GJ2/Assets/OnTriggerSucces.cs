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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
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

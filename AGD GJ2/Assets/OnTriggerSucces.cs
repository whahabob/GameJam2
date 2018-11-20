using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerSucces : MonoBehaviour
{
    [SerializeField]
    private Transform door;

    [SerializeField]
    private ActiveDoors activeDoors;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SuccesEffect();
            activeDoors.openDoors.Add(door.gameObject);
            //activeDoors.resetDoors();
        }
    }

    private void SuccesEffect()
    {

    }
}

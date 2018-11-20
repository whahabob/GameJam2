using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ActiveDoors")]
public class ActiveDoors : ScriptableObject
{
    public List<GameObject> openDoors = new List<GameObject>();

    public void resetDoors()
    {
        foreach (var item in openDoors)
        {
            item.GetComponent<Rigidbody>().isKinematic = true;
            item.transform.localRotation = new Quaternion(0, 0, 0, 0);
            item.transform.localPosition = new Vector3(0, -0.04806042f, -0.2174854f);
            item.GetComponent<Rigidbody>().isKinematic = false;
        }

        openDoors = new List<GameObject>();
    }
}

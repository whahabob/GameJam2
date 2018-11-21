using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

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
    private FloatVar deathCount;
    [SerializeField]
    private float startTime;
    [SerializeField]
    private AudioClip audioClip;
    [SerializeField]
    private string mainSceneName;

    private bool respawning;

    private void Start()
    {
        respawning = false;
        time._floatVar = startTime;
        activeDoors.openDoors = new List<GameObject>();
    }

    private void Update()
    {
        if (time._floatVar <= 0 && !respawning)
        {
            Debug.Log("Time Up");
            respawning = true;
            RespawnPlayer(gameObject.GetComponent<Collider>());
        }
    }

    public void RespawnPlayer(Collider other)
    {
        StartCoroutine(RespawnPlayerDelay(other));
        GetComponent<AudioSource>().PlayOneShot(audioClip);
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

        deathCount._floatVar = 0;
        deathCount._floatVar++;

        activeDoors.resetDoors();
        time._floatVar = startTime;

        UnloadAllScenesExcept(mainSceneName);
        respawning = false;
    }

    void UnloadAllScenesExcept(string sceneName)
    {
        int c = SceneManager.sceneCount;
        for (int i = 0; i < c; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.name != sceneName)
            {
                SceneManager.UnloadSceneAsync(scene);
            }
        }
    }
}

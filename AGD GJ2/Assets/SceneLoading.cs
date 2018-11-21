using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public string sceneToLoad;
    public string sceneToUnload;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            LoadScene();
            //UnLoadScene();
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Additive);
    }

    public void UnLoadScene()
    {
        SceneManager.UnloadSceneAsync(sceneToUnload);
    }
}

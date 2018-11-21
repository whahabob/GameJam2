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
            UnLoadScene();
        }
    }

    public void LoadScene()
    {
        int c = SceneManager.sceneCount;
        for (int i = 0; i < c; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.name == sceneToLoad)
            {
                return;
            }
        }
        SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Additive);
    }

    public void UnLoadScene()
    {
        SceneManager.UnloadSceneAsync(sceneToUnload);
    }
}

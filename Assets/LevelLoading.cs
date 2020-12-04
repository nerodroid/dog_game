using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    public GameObject loadingScreen ;
    public Slider slider;



    public void LoadLevel(int sceneIndex){
        
        loadingScreen.SetActive(true);
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }
    

    IEnumerator LoadAsynchronously(int sceneIndex){
              
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        


        while (!operation.isDone){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(operation.progress);

            slider.value = progress;

            yield return null;

        }
    }


}



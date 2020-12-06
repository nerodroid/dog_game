using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
   
    public GameObject loadingScreen ;
    public Slider slider;
    //public string gotoScene;
    public void LoadLevel(int sceneIndex){
        
        
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }
    

    IEnumerator LoadAsynchronously(int sceneIndex){
              
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        slider.value = 0.4f;
        while (!operation.isDone){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);

            slider.value = progress;

            yield return null;

        }
    }



    public void ExitGame(){
        Application.Quit();
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loadScene2 : MonoBehaviour
{
    
    public GameObject lm;
 
    


    public int sceneIndex ;
    //private LevelManager lm;
    
    void OnTriggerEnter(Collider player){
        if (player.gameObject.tag == "Player"){
            //textMesh = GetComponent<TMP_Text>();

            //lm.LoadLevel(sceneIndex);

            StartCoroutine(waiter());
            
           /// SceneManager.LoadScene(3);
           

        }



    }


    IEnumerator waiter()
    {
        
        yield return new WaitForSeconds(4);
        lm.transform.GetComponent<LevelManager> ().LoadLevel (sceneIndex);
       
    }









}

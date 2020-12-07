using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectManger : MonoBehaviour
{

    public TMP_Text textMesh ;
    public string objectPointText;

    public GameObject[] activables;


    public bool deactive ;
    //public GameObject textCanves ;





     void OnTriggerEnter(Collider player){

        if (player.gameObject.tag == "Player"){
            //textMesh = GetComponent<TMP_Text>();

            foreach (GameObject obj in activables){
                obj.SetActive(true);
            }


            Debug.Log(objectPointText);
            textMesh.text = objectPointText;



            if (deactive)
                this.gameObject.SetActive(false);


           

        }

        


    }
    
    

}

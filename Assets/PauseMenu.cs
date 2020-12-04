using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    bool CursorLockedVar;
    public GameObject pauseMenu;
    public GameObject guiMenu;
    public bool isPauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        isPauseMenu =false;
    }

    public void Resume(){

        Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		CursorLockedVar = (true);

        Time.timeScale =1;
        pauseMenu.SetActive(false);
      

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace)){

            if (!isPauseMenu){
                Time.timeScale =0;
                pauseMenu.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
			    Cursor.visible = (true);
			    CursorLockedVar = (false);
            }else{
               Resume();
            }
            
        }

         if (Input.GetKeyDown("I")){

             Cursor.lockState = CursorLockMode.None;
			    Cursor.visible = (true);
			    CursorLockedVar = (false);
         }
    }
}

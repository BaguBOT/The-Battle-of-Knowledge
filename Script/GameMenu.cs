using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.IO;

public class GameMenu : MonoBehaviour
{
  
    public GameObject panalSettings;


    void Start()
    {
        if (panalSettings != null)
            panalSettings.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("PlayGame");
        // SceneManager.LoadScene(1);
    }
       public void Setting()
    {
        if (panalSettings.activeSelf == false)
        {
            panalSettings.SetActive(true);
        }
        else
        {
            panalSettings.SetActive(false);
        }
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }

}
   


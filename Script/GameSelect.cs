using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
        // SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelect : MonoBehaviour
{


    void Start()
    {
        
    }
    public void GameHistory()
    {
        SceneManager.LoadScene("History");
    }
    public void GameMath ()
    {
        SceneManager.LoadScene("Math");
    }
    public void GameLiterature ()
    {
        SceneManager.LoadScene("Literature");
    }
    public void GameBiology ()
    {
        SceneManager.LoadScene("Biology");
    }
    public void GameGeography()
    {
        SceneManager.LoadScene("Geography");
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
        }
}

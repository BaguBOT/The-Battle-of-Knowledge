using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Reflection;
using static Games;
using System.Collections;
using static Unity.Burst.Intrinsics.X86;
using System.Drawing;

public class Games : MonoBehaviour
{
    // панель с меню
    public GameObject panelPause;
    public GameObject gamesSelectType;
    public GameObject SelectGameWorld;
    public GameObject SelectGameRus;
    public GameObject SelectTask;

    // панель для векторины
    public int Qcount;
    public int Attempts;
    private int count = 0;
    public Text QcountText;
    public Text AttemptsText;
    public QuestionList[] questions;
    public Text[] optionText;
    public Text questionsText;
    List<object> questionsList;
    QuestionList crntQ;
    int randQuestions;
    //
    //карта 
    public Image North_America1;
    public Image North_America2;
    public Image North_America3;
    public Image South_America1;
    public Image South_America2;
    public Image South_America3;
    public Image Africa1;
    public Image Africa2;
    public Image Africa3;
    public Image Europe1;
    public Image Europe2;
    public Image Europe3;
    public Image Asia1;
    public Image Asia2;
    public Image Asia3;
    public Image Oceania1;
    public Image Oceania2;
    public Image Oceania3;

    public UnityEngine.Color colorRed;
    public UnityEngine.Color colorBlue;
    public UnityEngine.Color colorGreen;
    public UnityEngine.Color colorYellow;
    public UnityEngine.Color colorWhite;

    private int TerritoryNorth_America1 = 0;
    private int TerritoryNorth_America2 = 0;
    private int TerritoryNorth_America3 = 0;
    private int TerritorySouth_America1 = 0;
    private int TerritorySouth_America2 = 0;
    private int TerritorySouth_America3 = 0;
    private int TerritoryAfrica1 = 0;
    private int TerritoryAfrica2 = 0;
    private int TerritoryAfrica3 = 0;
    private int TerritoryEurope = 0;
    private int TerritoryEurope2 = 0;
    private int TerritoryEurope3 = 0;
    private int TerritoryAsia1 = 0;
    private int TerritoryAsia2 = 0;
    private int TerritoryAsia3 = 0;
    private int TerritoryOceania1 = 0;
    private int TerritoryOceania2 = 0;
    private int TerritoryOceania3 = 0;

    private int PlayerPoint;
    private int Opponent1Point;
    private int Opponent2Point;
    private int Opponent3Point;


    void Start()
    {
        if (panelPause != null)
            panelPause.SetActive(false);
        if (SelectTask != null)
            SelectTask.SetActive(false);
        if (gamesSelectType != null)
            gamesSelectType.SetActive(true);
            }
    //викторина
         void questionGenerate()
    {
            randQuestions = UnityEngine.Random.Range(0, questionsList.Count);
            crntQ = questionsList[randQuestions] as QuestionList;
            questionsText.text = crntQ.question;
            List<string> answers = new List<string>(crntQ.option);
            for (int i = 0; i < crntQ.option.Length; i++)
            {
                int rand = UnityEngine.Random.Range(0, answers.Count);
                optionText[i].text = answers[rand];
                answers.RemoveAt(rand);
            }
        }       
     public void OptionBtns(int index)
    {
        if (optionText[index].text.ToString() == crntQ.option[0])
        {
            count++;
            QcountText.text = "Вопроса "+ count + " / 5";
            if (count != Qcount) 
            {
                print("Правильный ответ");
                questionsList.RemoveAt(randQuestions);
                questionGenerate();
            }
            else
            {
                print("Победа");
                SelectTask.SetActive(false);
            }
        }
        else
        {
            Attempts--;
            AttemptsText.text = "Попыток " + Attempts;
            if ( Attempts < 0)
            {
               print("Неудача");
               SelectTask.SetActive(false);
            }
            else
            print("Неправильный ответ");
            questionsList.RemoveAt(randQuestions);
            questionGenerate();
        }
    }
    [System.Serializable]
public class QuestionList
{
    public string question;
    public string[] option = new string[3];
}
public void Taskgame()
    {
        gamesSelectType.SetActive(false);
        SelectTask.SetActive(true);
        questionsList = new List<object>(questions);
        questionGenerate();
    }
    //
    public void PlayerNorth_America()
    {
     PlayerPoint = 1;
        North_America1.color = colorBlue;
        TerritoryNorth_America1 = 1;
      Opponent1Point =1;
        South_America2.color = colorRed;
        TerritorySouth_America2 = 2;
      Opponent2Point = 1;
       
        Oceania2.color = colorGreen;
        TerritoryOceania2 = 3;
        Opponent3Point = 1;
       
        Asia2.color = colorYellow;
        TerritoryAsia2 = 4;
        SelectGameWorld.SetActive(false);
     }
    public void PlayerSouth_America()
    {
        PlayerPoint = 1;
        South_America2.color = colorBlue;
        Opponent1Point = 1;
        Europe2.color = colorRed;
        Opponent2Point = 1;
        Oceania2.color = colorYellow;
        Opponent3Point = 1;
        Asia2.color= colorGreen;
        SelectGameWorld.SetActive(false);
    }
    public void PlayerAfrica()
    {
        PlayerPoint = 1;
        Africa2.color = colorBlue;
        Opponent1Point = 1;
        Asia2.color = colorRed;
        Opponent2Point = 1;
        Oceania2.color= colorGreen;
        Opponent3Point = 1;
        North_America1.color= colorYellow;
        SelectGameWorld.SetActive(false);
    }
    public void PlayerOceania()
    {
        PlayerPoint = 1;
        Oceania2.color = colorBlue;
        Opponent1Point = 1;
        South_America2.color= colorRed;
        Opponent2Point = 1;
        North_America1.color = colorGreen;
        Opponent3Point = 1;
        Europe2.color = colorYellow;
        SelectGameWorld.SetActive(false);
    }
    public void PlayerAsia()
    {
        PlayerPoint = 1;
        Asia2.color = colorBlue;
        Opponent1Point = 1;
        Oceania2.color = colorYellow;
        Opponent2Point = 1;
        North_America1.color = colorGreen;
        Opponent3Point = 1;
        South_America2.color = colorRed;
        SelectGameWorld.SetActive(false);
    }
    public void PlayerEurope()
    {
        PlayerPoint = 1;
        Europe2.color = colorBlue;
        Opponent1Point = 1;
        South_America2.color = colorRed;
        Opponent2Point = 1;
        Africa2.color = colorGreen;
        Opponent3Point = 1;
        Oceania2.color = colorYellow;
        SelectGameWorld.SetActive(false);
    }
    public void SelectRus()
    {
       gamesSelectType.SetActive(false);
        SelectGameRus.SetActive(true);
    }
    public void SelectWorld()
    {
        gamesSelectType.SetActive(false);
        SelectGameWorld.SetActive(true);
    }

    public void North_America1_Play()
    {
       
        if (TerritoryNorth_America1 == 0) 
        {
        
        }
    }
    public void North_America2_Play()
    {

    }
    public void North_America3_Play()
    {

    }
    public void South_America1_Play()
    {

    }
    public void South_America2_Play()
    {

    }
    public void South_America3_Play()
    {

    }
    public void Africa1_Play()
    {

    }
    public void Africa2_Play()
    {

    }
    public void Africa3_Play()
    {

    }
    public void Europe1_Play()
    {

    }
    public void Europe2_Play()
    {

    }
    public void Europe3_Play()
    {

    }
    public void Asia1_Play()
    {

    }
    public void Asia2_Play()
    {

    }
    public void Asia3_Play()
    {

    }
    public void Oceania1_Play()
    {

    }
    public void Oceania2_Play()
    {

    }
    public void Oceania3_Play()
    {

    }
    public void ResetWorld()
    {
        SelectGameWorld.SetActive(true);
        SelectTask.SetActive(false);
        panelPause.SetActive(false);
        North_America1.color = colorWhite;
        North_America2.color = colorWhite;
        North_America3.color = colorWhite;
        South_America1.color = colorWhite;
        South_America2.color = colorWhite;
        South_America3.color = colorWhite;
        Africa1.color = colorWhite;
        Africa2.color = colorWhite;
        Africa3.color = colorWhite;
        Europe1.color = colorWhite;
        Europe2.color = colorWhite;
        Europe3.color = colorWhite;
        Asia1.color = colorWhite;
        Asia2.color = colorWhite;
        Asia3.color = colorWhite;
        Oceania1.color = colorWhite;
        Oceania2.color = colorWhite;
        Oceania3.color = colorWhite;
    }
    public void SelectPause()
    {
        if (panelPause.activeSelf == false)
        {
            panelPause.SetActive(true);
        }
        else
        {
            panelPause.SetActive(false);
        }
    }
    public void exit()
    {
        SceneManager.LoadScene("PlayGame");
    }
}

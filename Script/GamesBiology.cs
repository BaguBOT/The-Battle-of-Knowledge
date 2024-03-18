using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using static Games;

public class GamesBiology : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject SelectTypeGames;
    public GameObject geneticGame;
    public GameObject taskGame;


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
    void Start()
    {
        
        if (panelPause != null)
            panelPause.SetActive(false);
       if (SelectTypeGames != null)
            SelectTypeGames.SetActive(true);
    }

   
    void questionGenerate()
    {
        randQuestions = UnityEngine.Random.Range(0, questionsList.Count);
        crntQ = questionsList[randQuestions] as QuestionList;
        questionsText.text = crntQ.question;
        List<string> answers = new List<string>(crntQ.option);
        for (int i = 0; i < crntQ.option.Length; i++)
        {
            int rand = Random.Range(0, answers.Count);
            optionText[i].text = answers[rand];
            answers.RemoveAt(rand);
        }
    }
        public void GeneticGame()
    {
        SelectTypeGames.SetActive(false);
        geneticGame.SetActive(true);
    }
    public void OptionBtns(int index)
    {
        if (optionText[index].text.ToString() == crntQ.option[0])
        {
            count++;
            QcountText.text = "Вопроса " + count + " / 5";
            if (count != Qcount)
            {
                print("Правильный ответ");
                questionsList.RemoveAt(randQuestions);
                questionGenerate();
            }
            else
            {
                print("Победа");
                SelectTypeGames.SetActive(false);
            }
        }
        else
        {
            Attempts--;
            AttemptsText.text = "Попыток " + Attempts;
            if (Attempts < 0)
            {
                print("Неудача");
                SelectTypeGames.SetActive(false);
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
        SelectTypeGames.SetActive(false);
        taskGame.SetActive(true);
        geneticGame.SetActive(false) ;
        questionsList = new List<object>(questions);
        questionGenerate();
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



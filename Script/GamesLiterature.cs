using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamesLiterature : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject selectAuthorGames;
    public GameObject authorGame1;
    public GameObject authorGame2;
    public GameObject authorGame3;
    public GameObject PomeGame;
    public GameObject Pome8Game;
    public GameObject taskGame;

    //
    public int Qcount;
    public int Attempts;
    private int count = 0;
    public Text QcountText;
    public Text AttemptsText;
    //
    public Text[] optionText;
    public Text questionsText;

    public QuestionList1[] questions1;
    List<object> questionsList1;
    QuestionList1 crntQ1;

    public QuestionList2[] questions2;
    List<object> questionsList2;
    QuestionList2 crntQ2;

    public QuestionList3[] questions3;
    List<object> questionsList3;
    QuestionList3 crntQ3;
    
    int randQuestions;
    //

    public Text[] poemTextBlocks4; // Массив текстовых блоков для строчек стихотворения
    public Text[] poemTextBlocks8; // Массив текстовых блоков для строчек стихотворения
    public Button checkButton; // Кнопка для проверки правильности расположения стихотворения

    private string[] poem8Lines = new string[8]; // Массив строк стихотворения
    private string[] poem4Lines = new string[4]; // Массив строк стихотворения
    private int[] correctPoemOrder = new int[] { 0, 1, 2, 3,4,5,6,7,8}; // Правильный порядок строк стихотворения
    public void FyodorDostoevsky()
    {
        authorGame1.SetActive(true);
    }
    public void AlexanderPushkin()
    {
        authorGame2.SetActive(true);
    }
    public void AntonChekhov()
    {
        authorGame3.SetActive(true);
            }

    public void PomeFyodorDostoevsky4()
    {
        PomeGame.SetActive(true); 
        Pome8Game.SetActive(false);
        selectAuthorGames.SetActive(false);
        authorGame3.SetActive(false); 
        GenerateRandomPoemFyodorDostoevsky4();
        UpdatePoem4TextBlocks();
    }
    public void PomeFyodorDostoevsky8()
    {
        PomeGame.SetActive(true);
        Pome8Game.SetActive(true);
        authorGame3.SetActive(false);
        selectAuthorGames.SetActive(false);
        GenerateRandomPoemFyodorDostoevsky8();
        UpdatePoem8TextBlocks();
    }
    public void PomeAntonChekhov4()
    {
        PomeGame.SetActive(true);
        Pome8Game.SetActive(false);
        authorGame2.SetActive(false);
        selectAuthorGames.SetActive(false);
        GenerateRandomPoemAlexanderPushkin4();
        UpdatePoem4TextBlocks();
    }
    public void PomeAntonChekhov8()
    {
        PomeGame.SetActive(true);
        Pome8Game.SetActive(true);
        authorGame2.SetActive(false);
        selectAuthorGames.SetActive(false);
        GenerateRandomPoemAlexanderPushkin8();
        UpdatePoem8TextBlocks();
    }
    public void PomeAlexanderPushkin4()
    {
        PomeGame.SetActive(true);
        Pome8Game.SetActive(false);
        authorGame1.SetActive(false);
        selectAuthorGames.SetActive(false);
        GenerateRandomPoemAntonChekhov4();
        UpdatePoem4TextBlocks();
    }
    public void PomeAlexanderPushkin8()
    {
        PomeGame.SetActive(true);
        Pome8Game.SetActive(true);
        authorGame1.SetActive(false);
        selectAuthorGames.SetActive(false);
        GenerateRandomPoemAntonChekhov8();
        UpdatePoem8TextBlocks();
    }
    private void GenerateRandomPoemFyodorDostoevsky8()
    {
        // Здесь ваш список строк стихотворения
        poem8Lines[0] = "Первая строка стихотворения";
        poem8Lines[1] = "Вторая строка стихотворения";
        poem8Lines[2] = "Третья строка стихотворения";
        poem8Lines[3] = "Четвертая строка стихотворения";
        poem8Lines[4] = "Пятая строка стихотворения";
        poem8Lines[5] = "Шестая строка стихотворения";
        poem8Lines[6] = "Седьмая строка стихотворения";
        poem8Lines[7] = "Восьмая строка стихотворения";
        // Перемешиваем строки стихотворения
        for (int i = 0; i < poem8Lines.Length; i++)
        {
            string temp = poem8Lines[i];
            int randomIndex = UnityEngine.Random.Range(i, poem8Lines.Length);
            poem8Lines[i] = poem8Lines[randomIndex];
            poem8Lines[randomIndex] = temp;
        }
    }
    private void GenerateRandomPoemFyodorDostoevsky4()
    {
        // Здесь ваш список строк стихотворения
        poem4Lines[0] = "Первая строка стихотворения";
        poem4Lines[1] = "Вторая строка стихотворения";
        poem4Lines[2] = "Третья строка стихотворения";
        poem4Lines[3] = "Четвертая строка стихотворения";
        // Перемешиваем строки стихотворения
        for (int i = 0; i < poem4Lines.Length; i++)
        {
            string temp = poem4Lines[i];
            int randomIndex = UnityEngine.Random.Range(i, poem4Lines.Length);
            poem4Lines[i] = poem4Lines[randomIndex];
            poem4Lines[randomIndex] = temp;
        }
    }
    private void GenerateRandomPoemAlexanderPushkin8()
    {
        // Здесь ваш список строк стихотворения
        poem8Lines[0] = "Первая строка стихотворения";
        poem8Lines[1] = "Вторая строка стихотворения";
        poem8Lines[2] = "Третья строка стихотворения";
        poem8Lines[3] = "Четвертая строка стихотворения";
        poem8Lines[4] = "Пятая строка стихотворения";
        poem8Lines[5] = "Шестая строка стихотворения";
        poem8Lines[6] = "Седьмая строка стихотворения";
        poem8Lines[7] = "Восьмая строка стихотворения";
        // Перемешиваем строки стихотворения
        for (int i = 0; i < poem8Lines.Length; i++)
        {
            string temp = poem8Lines[i];
            int randomIndex = UnityEngine.Random.Range(i, poem8Lines.Length);
            poem8Lines[i] = poem8Lines[randomIndex];
            poem8Lines[randomIndex] = temp;
        }
    }
    private void GenerateRandomPoemAlexanderPushkin4()
    {
        // Здесь ваш список строк стихотворения
        poem4Lines[0] = "Первая строка стихотворения";
        poem4Lines[1] = "Вторая строка стихотворения";
        poem4Lines[2] = "Третья строка стихотворения";
        poem4Lines[3] = "Четвертая строка стихотворения";
        // Перемешиваем строки стихотворения
        for (int i = 0; i < poem4Lines.Length; i++)
        {
            string temp = poem4Lines[i];
            int randomIndex = UnityEngine.Random.Range(i, poem4Lines.Length);
            poem4Lines[i] = poem4Lines[randomIndex];
            poem4Lines[randomIndex] = temp;
        }
    }
    private void GenerateRandomPoemAntonChekhov8()
    {
        // Здесь ваш список строк стихотворения
        poem8Lines[0] = "Первая строка стихотворения";
        poem8Lines[1] = "Вторая строка стихотворения";
        poem8Lines[2] = "Третья строка стихотворения";
        poem8Lines[3] = "Четвертая строка стихотворения";
        poem8Lines[4] = "Пятая строка стихотворения";
        poem8Lines[5] = "Шестая строка стихотворения";
        poem8Lines[6] = "Седьмая строка стихотворения";
        poem8Lines[7] = "Восьмая строка стихотворения";
        // Перемешиваем строки стихотворения
        for (int i = 0; i < poem8Lines.Length; i++)
        {
            string temp = poem8Lines[i];
            int randomIndex = UnityEngine.Random.Range(i, poem8Lines.Length);
            poem8Lines[i] = poem8Lines[randomIndex];
            poem8Lines[randomIndex] = temp;
        }
    }
    private void GenerateRandomPoemAntonChekhov4()
    {
        // Здесь ваш список строк стихотворения
        poem4Lines[0] = "Первая строка стихотворения";
        poem4Lines[1] = "Вторая строка стихотворения";
        poem4Lines[2] = "Третья строка стихотворения";
        poem4Lines[3] = "Четвертая строка стихотворения";
        // Перемешиваем строки стихотворения
        for (int i = 0; i < poem4Lines.Length; i++)
        {
            string temp = poem4Lines[i];
            int randomIndex = UnityEngine.Random.Range(i, poem4Lines.Length);
            poem4Lines[i] = poem4Lines[randomIndex];
            poem4Lines[randomIndex] = temp;
        }
    }
    private void Reset4TextBlocks()
    {
        for (int i = 0; i < poem4Lines.Length; i++)
        {
            poem4Lines[i] = ""; // Очищаем текстовые блоки
            if (i < poem4Lines.Length)
            {
                poem4Lines[i]= poem4Lines[i]; // Устанавливаем текст в блок только если есть строка стихотворения для данного блока
            }
        }
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
    public void ResetGame()
    {
        selectAuthorGames.SetActive(true);
        panelPause.SetActive(false);
        Reset4TextBlocks();
    }
    public void exit()
    {
        SceneManager.LoadScene("PlayGame");
    }
    void Start()
    {
      if (panelPause != null)
            panelPause.SetActive(false);
       if (selectAuthorGames != null)
            selectAuthorGames.SetActive(true);
    }

     void UpdatePoem4TextBlocks()
    {
        for (int i = 0; i < poemTextBlocks4.Length; i++)
        {
            poemTextBlocks4[i].text = poem4Lines[i];
        }
    }
     void UpdatePoem8TextBlocks()
    {
        for (int i = 0; i < poemTextBlocks8.Length; i++)
        {
            poemTextBlocks8[i].text = poem8Lines[i];
        }
    }
    //ЧТО ТО НЕ ТАК С ПРОВЕРКОЙ НЕ ЗАБУДЬ ПЕРЕСМОТРЕТЬ 
    public void CheckPoem4()
    {
        bool correct = true;
        for (int i = 0; i < poemTextBlocks4.Length; i++)
        {
            if (poemTextBlocks4[i].text != poem4Lines[correctPoemOrder[i]])
            {
                correct = true;
                break;
            }
        }
         if (correct)
        {
            Debug.Log("Строки стихотворения расположены правильно!");
        }
        else
        {
            Debug.Log("Строки стихотворения расположены не правильно.");
        }
    }
    // Метод для перемещения строки текста вверх
    public void MoveTextBlockUp4(int index)
    {
        if (index > 0)
        {
            string temp = poem4Lines[index];
            poem4Lines[index] = poem4Lines[index - 1];
            poem4Lines[index - 1] = temp;
            UpdatePoem4TextBlocks();
        }
    }
    // Метод для перемещения строки текста вниз
    public void MoveTextBlockDown4(int index)
    {
        if (index < poem4Lines.Length - 1)
        {
            string temp = poem4Lines[index];
            poem4Lines[index] = poem4Lines[index + 1];
            poem4Lines[index + 1] = temp;
            UpdatePoem4TextBlocks();
        }
    }
    public void MoveTextBlockUp8(int index)
    {
        if (index > 0)
        {
            string temp = poem8Lines[index];
            poem8Lines[index] = poem8Lines[index - 1];
            poem8Lines[index - 1] = temp;
            UpdatePoem8TextBlocks();
        }
    }
    public void MoveTextBlockDown8(int index)
    {
        if (index < poem8Lines.Length - 1)
        {
            string temp = poem8Lines[index];
            poem8Lines[index] = poem8Lines[index + 1];
            poem8Lines[index + 1] = temp;
            UpdatePoem8TextBlocks();
        }
    }
    // События запуска викторины
    public void Taskgame1()
    {
      taskGame.SetActive(true);
      questionsList1 = new List<object>(questions1);
      questionGenerate1();
    }
    public void Taskgame2()
    {
        taskGame.SetActive(true);
        questionsList2 = new List<object>(questions2);
        questionGenerate2();
    }
    public void Taskgame3()
    {
        taskGame.SetActive(true);
        questionsList3 = new List<object>(questions3);
        questionGenerate3();
    }
    // Генерация вопросов
    void questionGenerate1()
    {
        randQuestions = UnityEngine.Random.Range(0, questionsList1.Count);
        crntQ1 = questionsList1[randQuestions] as QuestionList1;
        questionsText.text = crntQ1.question;
        List<string> answers = new List<string>(crntQ1.option);
        for (int i = 0; i < crntQ1.option.Length; i++)
        {
            int rand = UnityEngine.Random.Range(0, answers.Count);
            optionText[i].text = answers[rand];
            answers.RemoveAt(rand);
        }
    }
    void questionGenerate2()
    {
        randQuestions = UnityEngine.Random.Range(0, questionsList2.Count);
        crntQ2 = questionsList2[randQuestions] as QuestionList2;
        questionsText.text = crntQ2.question;
        List<string> answers = new List<string>(crntQ2.option);
        for (int i = 0; i < crntQ2.option.Length; i++)
        {
            int rand = UnityEngine.Random.Range(0, answers.Count);
            optionText[i].text = answers[rand];
            answers.RemoveAt(rand);
        }
    }
   void questionGenerate3()
    {
        randQuestions = UnityEngine.Random.Range(0, questionsList3.Count);
        crntQ3 = questionsList3[randQuestions] as QuestionList3;
        questionsText.text = crntQ2.question;
        List<string> answers = new List<string>(crntQ3.option);
        for (int i = 0; i < crntQ3.option.Length; i++)
        {
            int rand = UnityEngine.Random.Range(0, answers.Count);
            optionText[i].text = answers[rand];
            answers.RemoveAt(rand);
        }
    }
    public void OptionBtns1(int index)
    {
        if (optionText[index].text.ToString() == crntQ1.option[0])
        {
            count++;
            QcountText.text = "Вопроса " + count + " / 5";
            if (count != Qcount)
            {
                print("Правильный ответ");
                questionsList1.RemoveAt(randQuestions);
                questionGenerate1();
            }
            else
            {
                print("Победа");
                taskGame.SetActive(false);
            }
        }
        else
        {
            Attempts--;
            AttemptsText.text = "Попыток " + Attempts;
            if (Attempts < 0)
            {
                print("Неудача");
                taskGame.SetActive(false);
            }
            else
                print("Неправильный ответ");
            questionsList1.RemoveAt(randQuestions);
            questionGenerate1();
        }
    }
    public void OptionBtns2(int index)
    {
        if (optionText[index].text.ToString() == crntQ2.option[0])
        {
            count++;
            QcountText.text = "Вопроса " + count + " / 5";
            if (count != Qcount)
            {
                print("Правильный ответ");
                questionsList2.RemoveAt(randQuestions);
                questionGenerate2();
            }
            else
            {
                print("Победа");
                taskGame.SetActive(false);
            }
        }
        else
        {
            Attempts--;
            AttemptsText.text = "Попыток " + Attempts;
            if (Attempts < 0)
            {
                print("Неудача");
                taskGame.SetActive(false);
            }
            else
                print("Неправильный ответ");
            questionsList2.RemoveAt(randQuestions);
            questionGenerate2();
        }
    }
    public void OptionBtns3(int index)
    {
        if (optionText[index].text.ToString() == crntQ3.option[0])
        {
            count++;
            QcountText.text = "Вопроса " + count + " / 5";
            if (count != Qcount)
            {
                print("Правильный ответ");
                questionsList3.RemoveAt(randQuestions);
                questionGenerate3();
            }
            else
            {
                print("Победа");
                taskGame.SetActive(false);
            }
        }
        else
        {
            Attempts--;
            AttemptsText.text = "Попыток " + Attempts;
            if (Attempts < 0)
            {
                print("Неудача");
                taskGame.SetActive(false);
            }
            else
                print("Неправильный ответ");
            questionsList3.RemoveAt(randQuestions);
            questionGenerate3();
        }
    }

    [System.Serializable]
    public class QuestionList1
    {
        public string question;
        public string[] option = new string[3];
    }
    [System.Serializable]
    public class QuestionList2
    {
        public string question;
        public string[] option = new string[3];
    }
    [System.Serializable]
    public class QuestionList3
    {
        public string question;
        public string[] option = new string[3];
    }


}

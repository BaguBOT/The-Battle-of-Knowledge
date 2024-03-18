using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;


public class GamesMath : MonoBehaviour
{
     public GameObject panelPause;
    public GameObject SelectAnuterGames;
    public GameObject geneticGame;
    public GameObject taskGame;
    void Start()
    {
          if (panelPause != null)
            panelPause.SetActive(false);
    }



public class MathGame : MonoBehaviour
{
    public Text problemText;
    public InputField answerInput;
    public Text scoreText;
    public Text timerText;
    public Text resultText;

    private int score = 0;
    private int baseTime = 30; // Базовое время для решения примера в секундах
    private int timeLeft;
    private bool isGameActive = false;

    private int minNumber = 1;
    private int maxNumber = 10;
    private int operand1;
    private int operand2;
    private char operation;
    private int correctAnswer;

    private void Start()
    {
        answerInput.text = ""; // Очищаем поле ввода ответа
        scoreText.text = "Score: " + score;
        timerText.text = "Time: " + baseTime + "s";
        resultText.text = "";

        StartGame();
    }

    private void StartGame()
    {
        isGameActive = true;
        UpdateProblem();
        timeLeft = baseTime;
        StartCoroutine(Countdown());
    }

    private void UpdateProblem()
    {
        // Генерируем случайные операнды и операцию
        operand1 = UnityEngine.Random.Range(minNumber, maxNumber + 1);
        operand2 = UnityEngine.Random.Range(minNumber, maxNumber + 1);
        int operationIndex = UnityEngine.Random.Range(0, 4);
        switch (operationIndex)
        {
            case 0:
                operation = '+';
                correctAnswer = operand1 + operand2;
                break;
            case 1:
                operation = '-';
                correctAnswer = operand1 - operand2;
                break;
            case 2:
                operation = '*';
                correctAnswer = operand1 * operand2;
                break;
            case 3:
                operation = '/';
                operand1 = correctAnswer * operand2; // чтобы результат деления был целым числом
                break;
        }

        // Формируем текст задачи
        problemText.text = operand1 + " " + operation + " " + operand2 + " = ?";
    }

    public void SubmitAnswer()
    {
        if (!isGameActive)
            return;

        int userAnswer;
        if (int.TryParse(answerInput.text, out userAnswer))
        {
            if (userAnswer == correctAnswer)
            {
                score *= 2; // Удваиваем очки
                resultText.text = "Correct! Score x2";
            }
            else
            {
                score /= 2; // Делим очки на два
                resultText.text = "Incorrect! Score /2";
            }

            scoreText.text = "Score: " + score;
            UpdateProblem();
        }
        else
        {
            resultText.text = "Please enter a valid number!";
        }

        answerInput.text = "";
    }

    private System.Collections.IEnumerator Countdown()
    {
        while (timeLeft > 0)
        {
            yield return new WaitForSeconds(1f);
            timeLeft--;
            timerText.text = "Time: " + timeLeft + "s";
        }

        // Если время вышло
        resultText.text = "Time's up!";
        isGameActive = false;
    }

    public void AttackEnemy()
    {
        int damage = UnityEngine.Random.Range(1, 10); // Генерируем случайный урон
        // Здесь код для нанесения урона противнику
        resultText.text = "You attacked enemy with " + damage + " damage!";
    }

    public void TakeDamage()
    {
        int damage = UnityEngine.Random.Range(1, 10); // Генерируем случайный урон
        // Здесь код для получения урона
        resultText.text = "You took " + damage + " damage!";
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
    public void exit()
    {
        SceneManager.LoadScene("PlayGame");
    }

    ///
/// b-a+b*c-a
/// b-c/a-b
///b*a/b*c
///Корень 121 и тд
/// !5
/// b^2
/// a-b-c
///a+b+a
/// 2^3
/// 2^4
///b-c
///
}

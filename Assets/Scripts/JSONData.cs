using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONData : MonoBehaviour
{
    public static JSONData instance;
    public List<QuizJSONData> quizData = new List<QuizJSONData>();
    public List<MateriJSONData> materiData = new List<MateriJSONData>();
    private string[] tempArray;
    public QUIZ quizEnum;

    public void AddQuizData(QuizJSONData data)
    {
        quizData.Clear();
        quizData.Add(data);
        Debug.Log("Add Quiz Data");
    }

    public string GetQuestion(QUIZ quizEnum, int index)
    {
        string outputData = "kosong";

        switch (quizEnum)
        {
            case QUIZ.MAIN:
                outputData = quizData[0].QUESTION_MAIN[index];
                break;

            case QUIZ.OTHER:
                outputData = quizData[0].QUESTION_OTHER[index];
                break;
        }

        return outputData;
    }

    public string GetAnswer(QUIZ quizEnum, int index)
    {
        string outputData = "kosong";

        switch (quizEnum)
        {
            case QUIZ.MAIN:
                outputData = quizData[0].ANSWER_MAIN[index];
                break;

            case QUIZ.OTHER:
                outputData = quizData[0].ANSWER_OTHER[index];
                break;
        }

        return outputData;
    }
    
    public string[] GetChoice(QUIZ quizEnum, int index)
    {
        switch (index)
        {
            case 0:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_1;
                else tempArray = quizData[0].CHOICE_OTHER_1;
                break;

            case 1:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_2;
                else tempArray = quizData[0].CHOICE_OTHER_2;
                break;

            case 2:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_3;
                else tempArray = quizData[0].CHOICE_OTHER_3;
                break;

            case 3:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_4;
                else tempArray = quizData[0].CHOICE_OTHER_4;
                break;

            case 4:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_5;
                else tempArray = quizData[0].CHOICE_OTHER_5;
                break;

            case 5:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_6;
                else tempArray = quizData[0].CHOICE_OTHER_6;
                break;

            case 6:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_7;
                else tempArray = quizData[0].CHOICE_OTHER_7;
                break;

            case 7:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_8;
                else tempArray = quizData[0].CHOICE_OTHER_8;
                break;

            case 8:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_9;
                else tempArray = quizData[0].CHOICE_OTHER_9;
                break;

            case 9:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_10;
                else tempArray = quizData[0].CHOICE_OTHER_10;
                break;

            case 10:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_11;
                break;

            case 11:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_12;
                break;

            case 12:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_13;
                break;

            case 13:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_14;
                break;

            case 14:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_15;
                break;

            case 15:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_16;
                break;

            case 16:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_17;
                break;

            case 18:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_19;
                break;

            case 19:
                if (quizEnum == QUIZ.MAIN) tempArray = quizData[0].CHOICE_MAIN_20;
                break;
        }

        return tempArray;
    }

    public void AddMateriData(MateriJSONData data)
    {
        materiData.Clear();
        materiData.Add(data);
        Debug.Log("Add Materi Data");
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
            instance = this;
    }

}


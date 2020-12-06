using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizController : MonoBehaviour
{
    public static QuizController instance;
    [HideInInspector] public string choosenAnswer;
    [HideInInspector] public bool isAnswerCorrect;
    [HideInInspector] public bool hasAnswered;
    [HideInInspector] public int numOfCorrectAnswer = 0;
    [SerializeField] private List<int> usedQuestion = new List<int>();
    [SerializeField] private List<int> usedChoice = new List<int>();
    [SerializeField] private List<int> tempChoice = new List<int>();
    [SerializeField] private List<int> tempQuestion = new List<int>();
    private float timeRemaining = Config.timerValue;
    private int numOfQuestion = 0;
    public int maxQuestion;
    [SerializeField] private int questionIndex;
    private bool isQuizStarting;
    public string[] questionArray;
    public string[] answerArray;

    public void OnSubmitButtonClicked()
    {
        NextQuestion();
    }

    public void OnUlangiQuizButtonClicked()
    {
        ResetQuiz();
    }

    public void OnKeMenuAwalButtonCLicked()
    {
        JSONData.instance.quizEnum = QUIZ.MAIN;
        SceneLoader.instance.LoadScene(SCENE.MENU);
    }

    private void TimeStart(bool setActive)
    {
        if (setActive == false)
        {
            ResetTimer();
            isQuizStarting = false;
            return;
        }


        timeRemaining -= Time.deltaTime;
        QuizUIController.instance.SetTimerText(timeRemaining.ToString("F0"));

        if (timeRemaining <= 0)
        {
            Debug.Log("Time is up");
            NextQuestion();
            isQuizStarting = false;
        }
    }

    private void NextQuestion()
    {
        if (hasAnswered == true)
        {
            numOfQuestion += 1;

            if (numOfQuestion > maxQuestion)
            {
                Debug.Log("Quiz Selesai...");
                QuizUIController.instance.SetActivePopUpPanel(true);
                QuizUIController.instance.SetPopUpText(numOfCorrectAnswer);

                HighScoreManager.instance.currentName = LoginController.instance.profileName;
                HighScoreManager.instance.currentScore = numOfCorrectAnswer;
                HighScoreManager.instance.ResetHighScores();
                HighScoreManager.instance.SaveHighScoreToJSON();
                return;
            }

            QuizUIController.instance.SetTitleText("Pertanyaan " + numOfQuestion + "/" + questionArray.Length);
            QuizUIController.instance.SetSubmitText("Kirim Jawaban");

            string question = GetRandomQuestion(JSONData.instance.quizEnum);
            QuizUIController.instance.CheckQuestionImage(question);
            QuizUIController.instance.SetQuestionText(question);
            SetMultipleChoice(JSONData.instance.quizEnum, questionIndex);
            Prepare();
            QuizUIController.instance.SetChoiceButtonInterractable(true);
            QuizUIController.instance.ResetAllButtonColor();
            //SoundController.instance.PlaySound(SOUND.SELECT);
        }
        else
        {
            Debug.Log(choosenAnswer);
            isAnswerCorrect = CheckAnswer(choosenAnswer);
            hasAnswered = true;
            QuizUIController.instance.SetSubmitText("Lanjutkan");
            QuizUIController.instance.SetChoiceButtonInterractable(false);
        }
    }

    private bool CheckAnswer(string inputAnswer)
    {
        string answer = JSONData.instance.GetAnswer(JSONData.instance.quizEnum, questionIndex);
        Debug.Log("Get answer " + questionIndex);
        bool isCorrect;

        if (inputAnswer == answer)
        {
            isCorrect = true;
            numOfCorrectAnswer += 1;
            QuizUIController.instance.SetSelectedButtonColor(BUTTON_COLOR.GREEN);
            QuizUIController.instance.SetTitleText("Jawaban Benar!");
            //SoundController.instance.PlaySound(SOUND.CORRECT);
            Debug.Log("BENAR!");
        }
        else
        {
            isCorrect = false;
            QuizUIController.instance.SetSelectedButtonColor(BUTTON_COLOR.RED);

            for (int i = 0; i < QuizUIController.instance.multipleChoice.Count; i++)
            {
                if (QuizUIController.instance.multipleChoice[i].text == answer)
                {
                    QuizUIController.instance.SetImageColor(QuizUIController.instance.multipleChoiceImage[i], BUTTON_COLOR.GREEN);
                }
            }

            QuizUIController.instance.SetTitleText("Jawaban Salah!");
            //SoundController.instance.PlaySound(SOUND.WRONG);
            Debug.Log("SALAH!");
        }

        Debug.Log("jawabanmu: " + inputAnswer + ", jawaban yang benar: " + answer);
        return isCorrect;
    }

    private string GetRandomQuestion(QUIZ quizEnum)
    {
        questionIndex = MathUtility.RandomizeInt(questionArray.Length, tempQuestion);

        while (usedQuestion.Contains(questionIndex))
        {
            questionIndex = MathUtility.RandomizeInt(questionArray.Length, tempQuestion);
        }

        usedQuestion.Add(questionIndex);
        tempQuestion.Clear();
        string outputString = JSONData.instance.GetQuestion(quizEnum, questionIndex);
        Debug.Log("Get question " + questionIndex);
        return outputString;
    }

    private void SetMultipleChoice(QUIZ quizEnum, int index)
    {
        string[] choiceArray = JSONData.instance.GetChoice(quizEnum, index);

        for (int i = 0; i < choiceArray.Length; i++)
        {
            int random = MathUtility.RandomizeInt(QuizUIController.instance.multipleChoice.Count, tempChoice);

            while (usedChoice.Contains(random))
            {
                random = MathUtility.RandomizeInt(QuizUIController.instance.multipleChoice.Count, tempChoice);
            }

            QuizUIController.instance.SetChoiceText(random, choiceArray[i]);
            usedChoice.Add(random);
        }

        tempChoice.Clear();
        usedChoice.Clear();
    }

    private void ResetTimer()
    {
        timeRemaining = Config.timerValue;
    }

    private void ResetQuiz()
    {
        usedQuestion.Clear();
        Prepare();
        hasAnswered = true;
        numOfQuestion = 0;
        numOfCorrectAnswer = 0;
        NextQuestion();
    }

    private void Prepare()
    {
        isQuizStarting = true;
        hasAnswered = false;
        isAnswerCorrect = false;
        choosenAnswer = null;
        QuizUIController.instance.SetActivePopUpPanel(false);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        if (JSONData.instance.quizEnum == QUIZ.MAIN)
        {
            questionArray = JSONData.instance.quizData[0].QUESTION_MAIN;
            answerArray = JSONData.instance.quizData[0].ANSWER_MAIN;
            maxQuestion = 20;
        }
        else
        {
            questionArray = JSONData.instance.quizData[0].QUESTION_OTHER;
            answerArray = JSONData.instance.quizData[0].ANSWER_OTHER;
            maxQuestion = 10;
        }
    }

    private void Start()
    {
        Prepare();
        hasAnswered = true;
        NextQuestion();
    }

    private void Update()
    {
        if (isQuizStarting == true && hasAnswered == false)
        {
            TimeStart(true);
        }
        else
        {
            TimeStart(false);
        }
    }
}

public enum QUIZ
{
    MAIN,
    OTHER
}

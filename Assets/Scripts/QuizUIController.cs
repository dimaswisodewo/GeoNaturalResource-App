using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizUIController : MonoBehaviour
{
    public static QuizUIController instance;
    [Header("Question")]
    public Text questionText;
    [Header("Multiple Choice")]
    public List<Text> multipleChoice = new List<Text>();
    [Header("Image")]
    public List<Image> multipleChoiceImage = new List<Image>();
    public Image questionImage;
    [HideInInspector] public Image selectedButtonImage;
    [Header("Other")]
    public Text timerText;
    public Text titleText;
    public Text submitText;
    public CanvasGroup choiceGroup;
    [Header("Pop Up Panel")]
    public GameObject popUpPanel;
    public Text popUpText;
    public GameObject questionImagePanel;
    public List<Sprite> questionImageLibrary = new List<Sprite>();
    [Header("Button")]
    public GameObject viewQuestionImageButton;

    public void SetQuestionText(string inputString)
    {
        questionText.text = inputString;
    }

    public void SetTitleText(string inputString)
    {
        titleText.text = inputString;
    }

    public void SetPopUpText(int correctAnswer)
    {
        popUpText.text = "Berhasil Menyelesaikan Quiz dengan\nMenjawab " + correctAnswer + " Benar dari " + QuizController.instance.maxQuestion + " Pertanyaan";
    }

    public void SetTimerText(string inputString)
    {
        timerText.text = inputString;
    }

    public void SetSubmitText(string inputString)
    {
        submitText.text = inputString;
    }

    public void SetChoiceText(int index, string inputString)
    {
        SetText(multipleChoice[index], inputString);
    }

    public void SetChoiceButtonInterractable(bool setActive)
    {
        choiceGroup.interactable = setActive;
    }

    public void ResetAllButtonColor()
    {
        for (int i = 0; i < multipleChoiceImage.Count; i++)
        {
            SetImageColor(multipleChoiceImage[i], BUTTON_COLOR.WHITE);
        }

        selectedButtonImage = null;
    }

    public void SetSelectedButtonColor(BUTTON_COLOR inputColor)
    {
        if (selectedButtonImage != null)
        {
            SetImageColor(selectedButtonImage, inputColor);
        }
    }

    public void SetImageColor(Image inputImage, BUTTON_COLOR buttonColor)
    {
        switch (buttonColor)
        {
            case BUTTON_COLOR.GREEN:
                inputImage.color = new Color32(195, 245, 132, 255);
                break;

            case BUTTON_COLOR.RED:
                inputImage.color = new Color32(246, 92, 120, 255);
                break;

            case BUTTON_COLOR.YELLOW:
                inputImage.color = new Color32(255, 243, 175, 255);
                break;

            case BUTTON_COLOR.WHITE:
                inputImage.color = Color.white;
                break;
        }
    }

    public void SetActivePopUpPanel(bool setActive)
    {
        popUpPanel.SetActive(setActive);
    }

    public void CheckQuestionImage(string inputString)
    {
        if (inputString.Contains("bertanda A"))
        {
            SetQuestionImage(questionImageLibrary[0]);
        }
        else if (inputString.Contains("tanda X"))
        {
            SetQuestionImage(questionImageLibrary[1]);
        }
        else
        {
            SetActiveViewQuestionImageButton(false);
            SetActiveQuestionImagePanel(false);
            return;
        }

        SetActiveViewQuestionImageButton(true);
    }

    public void SetActiveQuestionImagePanel(bool setActive)
    {
        questionImagePanel.SetActive(setActive);
    }

    private void SetQuestionImage(Sprite inputSprite)
    {
        questionImage.sprite = inputSprite;
    }

    private void SetActiveViewQuestionImageButton(bool setActive)
    {
        viewQuestionImageButton.SetActive(setActive);
    }

    private void SetText(Text inputText, string inputString)
    {
        inputText.text = inputString;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        SetActiveViewQuestionImageButton(false);
        SetActiveQuestionImagePanel(false);
    }

}

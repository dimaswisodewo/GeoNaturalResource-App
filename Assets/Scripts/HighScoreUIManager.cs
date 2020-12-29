using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUIManager : MonoBehaviour
{
    public List<Text> nameTexts = new List<Text>();
    public List<Text> scoreTexts = new List<Text>();

    private void Awake()
    {
        ResetHighScoresUI();
    }

    public void ResetHighScoresUI()
    {
        for (int i = 0; i < nameTexts.Count; i++)
        {
            SetNameText(i, HighScoreManager.instance.highScoreTable.names[i]);
            SetScoreText(i, HighScoreManager.instance.highScoreTable.scores[i].ToString());
        }
    }

    public void DeleteHighScoresRecords()
    {
        HighScoreManager.instance.DeleteHighScore();
        HighScoreManager.instance.SaveHighScoreToJSON();
        ResetHighScoresUI();
    }

    public void SetNameText(int index, string inputString)
    {
        nameTexts[index].text = inputString;
    }

    public void SetScoreText(int index, string inputString)
    {
        scoreTexts[index].text = inputString;
    }
}

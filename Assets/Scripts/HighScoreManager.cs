using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager instance;
    public HighScoreTable highScoreTable;
    private int currentPos = -1;
    public int currentScore;
    public string currentName;
    private string fileName = "HighScoreTable.json";
    
    public IEnumerator LoadHighScoreJSONFile()
    {
        string path = Application.streamingAssetsPath;
        string fullPath = System.IO.Path.Combine("file:///", path, fileName);

        UnityWebRequest request = UnityWebRequest.Get(fullPath);

        yield return request.SendWebRequest();

        if (request.isHttpError || request.isNetworkError)
        {
            Debug.Log("Request Error : " + request.error);
            yield break;
        }

        string downloadedText = request.downloadHandler.text;
        Debug.Log(downloadedText);

        highScoreTable = JsonUtility.FromJson<HighScoreTable>(downloadedText);
    }

    public void DeleteHighScore()
    {
        for (int i = 0; i < highScoreTable.scores.Length; i++)
        {
            highScoreTable.scores[i] = 0;
            highScoreTable.names[i] = "None";
        }
    }

    public void ResetHighScores()
    {
        CheckHighScorePosition();

        if (currentPos > -1)
        {
            SortHighScore();

            highScoreTable.scores[currentPos] = currentScore;
            highScoreTable.names[currentPos] = currentName;

            currentPos = -1;
        }
    }

    private void CheckHighScorePosition()
    {
        for (int i = highScoreTable.scores.Length - 1; i >= 0; i--)
        {
            if (currentScore >= highScoreTable.scores[i])
            {
                currentPos = i;
            }
            else
            {
                break;
            }
        }
    }

    private void SortHighScore()
    {
        for (int i = highScoreTable.scores.Length - 1; i > currentPos; i--)
        {
            highScoreTable.scores[i] = highScoreTable.scores[i - 1];
            highScoreTable.names[i] = highScoreTable.names[i - 1];
        }
    }

    public void SaveHighScoreToJSON()
    {
        string path = Application.streamingAssetsPath;
        string fullPath = System.IO.Path.Combine(path, fileName);

        string highScores = JsonUtility.ToJson(highScoreTable, true);
        System.IO.File.WriteAllText(fullPath, highScores);
    }
    
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this);
    }
}

[System.Serializable]
public class HighScoreTable
{
    public string[] names;
    public int[] scores;
}
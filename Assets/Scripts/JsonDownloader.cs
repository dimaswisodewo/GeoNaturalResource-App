using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class JsonDownloader : MonoBehaviour
{
    public JSONData jsonData;
    public HighScoreTable highScoreTable;
    private string quizDataFileName = "QuizData";
    private string materiDataFileName = "MateriData";
    private string highScoreDataFileName = "HighScoreTable";

    public IEnumerator LoadJSONData(string fileName, JSON_TYPE jsonType)
    {
        string path = Application.streamingAssetsPath;
        string fullPath;
        fullPath = PathCorrection(path, fileName);
        Debug.Log("Full Path : " + fullPath);

        UnityWebRequest request = UnityWebRequest.Get(fullPath);

        yield return request.SendWebRequest();

        if (request.isHttpError || request.isNetworkError)
        {
            Debug.Log("Request Error : " + request.error);
            yield break;
        }

        string downloadedText = request.downloadHandler.text;
        Debug.Log(downloadedText);

        if (jsonType == JSON_TYPE.QUIZ)
        {
            QuizJSONData jsonData = TryParseQuizJSONData(downloadedText);
            this.jsonData.AddQuizData(jsonData);
        }
        else if (jsonType == JSON_TYPE.MATERI)
        {
            MateriJSONData jsonData = TryParseMateriJSONData(downloadedText);
            this.jsonData.AddMateriData(jsonData);
        }

        //SceneLoader.instance.LoadScene(SCENE.MENU);
    }

    public QuizJSONData TryParseQuizJSONData(string downloadedText)
    {
        QuizJSONData data = JsonUtility.FromJson<QuizJSONData>(downloadedText);
        return data;
    }

    public MateriJSONData TryParseMateriJSONData(string downloadedText)
    {
        MateriJSONData data = JsonUtility.FromJson<MateriJSONData>(downloadedText);
        return data;
    }

    private string PathCorrection(string _fullPath, string _fileName)
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            _fullPath = System.IO.Path.Combine(_fullPath, _fileName + ".json");
            Debug.Log("Run in Android");
        }
        else
        {
            Debug.Log("Run in Editor");
            _fullPath = System.IO.Path.Combine("file:///" + _fullPath, _fileName + ".json");
        }

        return _fullPath;
    }

    private IEnumerator LoadDataAtStart()
    {
        yield return StartCoroutine(LoadJSONData(quizDataFileName, JSON_TYPE.QUIZ));
        yield return StartCoroutine(LoadJSONData(materiDataFileName, JSON_TYPE.MATERI));
        yield return StartCoroutine(HighScoreManager.instance.LoadHighScoreJSONFile());
        yield return StartCoroutine(MapDataManager.instance.LoadJsonData());
        //yield return StartCoroutine(SceneLoader.instance.LoadSceneCoroutine(SCENE.MENU));
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        StartCoroutine(LoadDataAtStart());

        if (LoginController.instance.CheckKeyPlayerPref("Profile") == false)
        {
            StartCoroutine(SceneLoader.instance.LoadSceneCoroutine(SCENE.LOGIN));
        }
        else
        {
            StartCoroutine(SceneLoader.instance.LoadSceneCoroutine(SCENE.MENU));
        }
    }

}

[System.Serializable]
public class QuizJSONData
{
    public string[] QUESTION_MAIN; 
    public string[] QUESTION_OTHER; 
    public string[] ANSWER_MAIN; 
    public string[] ANSWER_OTHER;
    public string[] CHOICE_MAIN_1;
    public string[] CHOICE_MAIN_2;
    public string[] CHOICE_MAIN_3;
    public string[] CHOICE_MAIN_4;
    public string[] CHOICE_MAIN_5;
    public string[] CHOICE_MAIN_6;
    public string[] CHOICE_MAIN_7;
    public string[] CHOICE_MAIN_8;
    public string[] CHOICE_MAIN_9;
    public string[] CHOICE_MAIN_10;
    public string[] CHOICE_MAIN_11;
    public string[] CHOICE_MAIN_12;
    public string[] CHOICE_MAIN_13;
    public string[] CHOICE_MAIN_14;
    public string[] CHOICE_MAIN_15;
    public string[] CHOICE_MAIN_16;
    public string[] CHOICE_MAIN_17;
    public string[] CHOICE_MAIN_18;
    public string[] CHOICE_MAIN_19;
    public string[] CHOICE_MAIN_20;
    public string[] CHOICE_OTHER_1;
    public string[] CHOICE_OTHER_2;
    public string[] CHOICE_OTHER_3;
    public string[] CHOICE_OTHER_4;
    public string[] CHOICE_OTHER_5;
    public string[] CHOICE_OTHER_6;
    public string[] CHOICE_OTHER_7;
    public string[] CHOICE_OTHER_8;
    public string[] CHOICE_OTHER_9;
    public string[] CHOICE_OTHER_10;
}

[System.Serializable]
public class MateriJSONData
{
    public string[] ACEH;
    public string[] SUMATERA_UTARA;
    public string[] SUMATERA_BARAT;
    public string[] RIAU;
    public string[] KEPULAUAN_RIAU;
    public string[] JAMBI;
    public string[] BENGKULU;
    public string[] SUMATERA_SELATAN;
    public string[] BANGKA_BELITUNG;
    public string[] LAMPUNG;
    public string[] BANTEN;
    public string[] JAWA_BARAT;
    public string[] DKI_JAKARTA;
    public string[] JAWA_TENGAH;
    public string[] DI_YOGYAKARTA;
    public string[] JAWA_TIMUR;
    public string[] BALI;
    public string[] NTB;
    public string[] NTT;
    public string[] KALIMANTAN_UTARA;
    public string[] KALIMANTAN_BARAT;
    public string[] KALIMANTAN_TENGAH;
    public string[] KALIMANTAN_SELATAN;
    public string[] KALIMANTAN_TIMUR;
    public string[] GORONTALO;
    public string[] SULAWESI_UTARA;
    public string[] SULAWESI_BARAT;
    public string[] SULAWESI_TENGAH;
    public string[] SULAWESI_SELATAN;
    public string[] SULAWESI_TENGGARA;
    public string[] MALUKU_UTARA;
    public string[] MALUKU;
    public string[] PAPUA_BARAT;
    public string[] PAPUA;
}

public enum JSON_TYPE
{
    QUIZ,
    MATERI
}
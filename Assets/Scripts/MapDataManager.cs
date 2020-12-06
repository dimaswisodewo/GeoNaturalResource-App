using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MapDataManager : MonoBehaviour
{
    public static MapDataManager instance;
    private string fileName = "MapData.json";
    public MapData mapData;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    public IEnumerator LoadJsonData()
    {
        string path = Application.streamingAssetsPath;
        string fullPath = System.IO.Path.Combine("file:///", path, fileName);

        UnityWebRequest request = UnityWebRequest.Get(fullPath);

        yield return request.SendWebRequest();

        if (request.isHttpError || request.isNetworkError)
        {
            Debug.Log("Request Error " + request.error);
            yield break;
        }

        string downloadedText = request.downloadHandler.text;
        MapData data = JsonUtility.FromJson<MapData>(downloadedText);
        mapData = data;
    }

    private void SaveToJSON()
    {
        string path = Application.streamingAssetsPath;
        string fullPath = System.IO.Path.Combine(path, fileName);

        string data = JsonUtility.ToJson(mapData, true);
        System.IO.File.WriteAllText(fullPath, data);
    }

}

[System.Serializable]
public class MapData {
    public List<Provinsi> provinsiData = new List<Provinsi>();
}

[System.Serializable]
public class Provinsi
{
    public string nama;
    public string ibuKota;
    public string sumberDayaHayati;
    public string sumberDayaNonHayati;
}

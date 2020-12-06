using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Config
{
    public const float timerValue = 30f;

    public const string SCENE_MENU = "MenuScene_2";
    public const string SCENE_SUBMENU_MATERI = "SubMenuMateriScene";
    public const string SCENE_MATERI = "MateriScene_2";
    public const string SCENE_ABOUT = "AboutScene";
    public const string SCENE_QUIZ = "QuizScene_2";
    public const string SCENE_HIGHSCORE = "HighScoreScene";
    public const string SCENE_MAP = "MapScene_2";
    public const string SCENE_LOGIN = "LoginScene";
    public const string SCENE_OTHER = "OtherScene";
    public const string SCENE_OTHER_MEDIA = "OtherMediaScene";
    public const string SCENE_ECOREGION = "EcoregionScene";
    public const string SCENE_REFERENCE = "ReferenceScene";
    public const string SCENE_PANDUAN = "PanduanScene";

    public const string CORRECT_ANSWER = "Kamu Benar!!!";
    public const string WRONG_ANSWER = "Jawaban Salah...";

    public const string URL_VIDEO_VLOG = "https://drive.google.com/file/d/1pltmRXK3kS_4l1HbKay0FsN3JyL2D-ee/view?usp=drivesdk";
    public const string URL_DIGITAL_BOOK = "https://drive.google.com/file/d/1wBmU4ZE52ANF90UaWhNniV_b73MrUfol/view";
    public const string URL_BAHAN_AJAR = "https://drive.google.com/file/d/1BN2KF--J1EbhNXv4r5g-iDDOEbswCxWO/view";
    public const string URL_BAHAN_AJAR_2 = "https://drive.google.com/file/d/1RqXAXqDtaHaLEgprEofxYOtdTw8BekKm/view?usp=sharing";
}

public class MathUtility
{
    public static int RandomizeInt(int count, List<int> listUsedValues)
    {
        int index = Random.Range(0, count);

        while (listUsedValues.Contains(index))
        {
            index = Random.Range(0, count);
        }

        listUsedValues.Add(index);
        return index;
    }

    public static int ToInteger(float inputFloat)
    {
        int outputInt = Mathf.RoundToInt(inputFloat);
        return outputInt;
    }
}

public enum DIFICULTY
{
    EASY,
    MEDIUM,
    HARD
}

public enum MATERI
{
    MATERI_1,
    MATERI_2,
    MATERI_3,
    MATERI_4,
    KOMPETENSI_DASAR
}

public enum ISLAND
{
    JAWA,
    SUMATERA,
    KALIMANTAN,
    SULAWESI,
    PAPUA,
    MALUKU,
    NUSATENGGARA
}

public enum BUTTON_COLOR
{
    WHITE,
    GREEN,
    RED,
    YELLOW
}

public enum SOUND
{
    SELECT,
    CORRECT,
    WRONG
}

public enum DAERAH
{
    ACEH,
    SUMATERA_UTARA,
    SUMATERA_BARAT,
    RIAU,
    KEPULAUAN_RIAU,
    JAMBI,
    BENGKULU,
    SUMATERA_SELATAN,
    BANGKA_BELITUNG,
    LAMPUNG,
    BANTEN,
    JAWA_BARAT,
    DKI_JAKARTA,
    JAWA_TENGAH,
    DI_YOGYAKARTA,
    JAWA_TIMUR,
    BALI,
    NTB,
    NTT,
    KALIMANTAN_UTARA,
    KALIMANTAN_BARAT,
    KALIMANTAN_TENGAH,
    KALIMANTAN_SELATAN,
    KALIMANTAN_TIMUR,
    GORONTALO,
    SULAWESI_UTARA,
    SULAWESI_BARAT,
    SULAWESI_TENGAH,
    SULAWESI_SELATAN,
    SULAWESI_TENGGARA,
    MALUKU_UTARA,
    MALUKU,
    PAPUA_BARAT,
    PAPUA
}
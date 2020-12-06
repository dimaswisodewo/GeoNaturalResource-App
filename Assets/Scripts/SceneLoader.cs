using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    public MATERI materiEnum;
    private string sceneToLoad;

    public IEnumerator LoadSceneCoroutine(SCENE inputScene)
    {
        LoadScene(inputScene);
        yield return null;
    }

    public void LoadScene(SCENE inputSCENE)
    {
        sceneToLoad = null;

        switch (inputSCENE)
        {
            case SCENE.MENU:
                sceneToLoad = Config.SCENE_MENU;
                break;

            case SCENE.MATERI:
                sceneToLoad = Config.SCENE_MATERI;
                break;

            case SCENE.ABOUT:
                sceneToLoad = Config.SCENE_ABOUT;
                break;

            case SCENE.QUIZ:
                sceneToLoad = Config.SCENE_QUIZ;
                break;

            case SCENE.HIGHSCORE:
                sceneToLoad = Config.SCENE_HIGHSCORE;
                break;

            case SCENE.MAP:
                sceneToLoad = Config.SCENE_MAP;
                break;

            case SCENE.LOGIN:
                sceneToLoad = Config.SCENE_LOGIN;
                break;

            case SCENE.OTHER:
                sceneToLoad = Config.SCENE_OTHER;
                break;

            case SCENE.OTHER_MEDIA:
                sceneToLoad = Config.SCENE_OTHER_MEDIA;
                break;

            case SCENE.SUBMENU_MATERI:
                sceneToLoad = Config.SCENE_SUBMENU_MATERI;
                break;

            case SCENE.ECOREGION:
                sceneToLoad = Config.SCENE_ECOREGION;
                break;

            case SCENE.REFERENCE:
                sceneToLoad = Config.SCENE_REFERENCE;
                break;

            case SCENE.PANDUAN:
                sceneToLoad = Config.SCENE_PANDUAN;
                break;
        }

        if (sceneToLoad == null)
        {
            Debug.Log("Scene " + inputSCENE + " not found!");
            return;
        }

        SceneManager.LoadScene(sceneToLoad);
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;

        DontDestroyOnLoad(gameObject);
    }

}

public enum SCENE
{
    MENU,
    MATERI,
    SUBMENU_MATERI,   
    MATERI_1,
    ABOUT,
    QUIZ,
    HIGHSCORE,
    MAP,
    LOGIN,
    OTHER,
    OTHER_MEDIA,
    ECOREGION,
    REFERENCE,
    SPLASH_SCREEN,
    PANDUAN
}

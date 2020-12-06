using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : MonoBehaviour
{
    public void OnMenuButtonClicked()
    {
        if (JSONData.instance.quizEnum == QUIZ.MAIN)
        {
            SceneLoader.instance.LoadScene(SCENE.MENU);
        }
        else
        {
            JSONData.instance.quizEnum = QUIZ.MAIN;
            SceneLoader.instance.LoadScene(SCENE.OTHER);
        }
    }

    public void OnMateri1ButtonClicked()
    {
        SceneLoader.instance.materiEnum = MATERI.MATERI_1;
        SceneLoader.instance.LoadScene(SCENE.MATERI);
    }

    public void OnMateri2ButtonClicked()
    {
        SceneLoader.instance.materiEnum = MATERI.MATERI_2;
        SceneLoader.instance.LoadScene(SCENE.MATERI);
    }

    public void OnMateri3ButtonClicked()
    {
        SceneLoader.instance.materiEnum = MATERI.MATERI_3;
        SceneLoader.instance.LoadScene(SCENE.MATERI);
    }

    public void OnMateri4ButtonClicked()
    {
        SceneLoader.instance.materiEnum = MATERI.KOMPETENSI_DASAR;
        SceneLoader.instance.LoadScene(SCENE.MATERI);
    }

    public void OnMateriButtonClicked()
    {
        if (SceneLoader.instance.materiEnum == MATERI.MATERI_4)
        {
            SceneLoader.instance.LoadScene(SCENE.OTHER);
            SceneLoader.instance.materiEnum = MATERI.MATERI_1;
        }
        else
        {
            SceneLoader.instance.LoadScene(SCENE.SUBMENU_MATERI);
        }
    }

    public void OnMapButtonCLicked()
    {
        SceneLoader.instance.LoadScene(SCENE.MAP);
    }

    public void OnQuizButtonClicked()
    {
        JSONData.instance.quizEnum = QUIZ.MAIN;
        SceneLoader.instance.LoadScene(SCENE.QUIZ);
    }

    public void OnHighScoreButtonCLicked()
    {
        SceneLoader.instance.LoadScene(SCENE.HIGHSCORE);
    }

    public void OnAboutButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.ABOUT);
    }

    public void OnQuitButtonClicked()
    {
        Debug.Log("Quit Application");
        Application.Quit();
    }

    public void OnOtherButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.OTHER);
    }

    public void OnOtherQuizButtonClicked()
    {
        JSONData.instance.quizEnum = QUIZ.OTHER;
        SceneLoader.instance.LoadScene(SCENE.QUIZ);
    }

    public void OnOtherGeografikaButtonClicked()
    {
        SceneLoader.instance.materiEnum = MATERI.MATERI_4;
        SceneLoader.instance.LoadScene(SCENE.MATERI);
    }

    public void OnOtherEkoregionButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.ECOREGION);
    }

    public void OnOtherMediaButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.OTHER_MEDIA);
    }

    public void OnReferenceButtonClicked()
    {
        JSONData.instance.quizEnum = QUIZ.OTHER;
        SceneLoader.instance.LoadScene(SCENE.REFERENCE);
    }

    public void OnChangeProfileButtonClicked()
    {
        LoginController.instance.DeleteKeyPlayerPref("Profile");
        SceneLoader.instance.LoadScene(SCENE.LOGIN);
    }

    public void OnVideoVlogButtonClicked()
    {
        Application.OpenURL(Config.URL_VIDEO_VLOG);
    }

    public void OnDigitalBookButtonClicked()
    {
        Application.OpenURL(Config.URL_DIGITAL_BOOK);
    }

    public void OnBahanAjarButtonClicked()
    {
        Application.OpenURL(Config.URL_BAHAN_AJAR);
    }

    public void OnBahanAjar2ButtonClicked()
    {
        Application.OpenURL(Config.URL_BAHAN_AJAR_2);
    }
}

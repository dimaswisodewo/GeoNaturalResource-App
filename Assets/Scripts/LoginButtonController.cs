using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginButtonController : MonoBehaviour
{
    public void OnLoginButtonClicked()
    {
        string profileName = LoginUIController.instance.GetInputFieldText();

        if (profileName != "")
        {
            LoginController.instance.profileName = profileName;
            LoginController.instance.SetStringPlayerPref("Profile", profileName);
            OnNameIsRightButtonClicked();
        }
        else
        {
            Debug.Log("nama tidak valid");
        }
    }

    public void OnNameIsRightButtonClicked()
    {
        SceneLoader.instance.LoadScene(SCENE.PANDUAN);
    }

    public void OnNameIsWrongButtonClicked()
    {
        LoginUIController.instance.SetActivePopUp(false);
    }
}

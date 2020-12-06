using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableURL : MonoBehaviour
{
    public string URL;

    public void OnURLClicked()
    {
        Application.OpenURL(URL);
    }
}

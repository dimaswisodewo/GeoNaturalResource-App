using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EkoregionButton : MonoBehaviour
{
    public GameObject popUpPanel;

    public void OnCloseButtonClicked()
    {
        SetActivePopUpPanel(false);
    }

    public void OnEkoregionButtonClicked()
    {
        SetActivePopUpPanel(true);
    }

    private void SetActivePopUpPanel(bool setActive)
    {
        popUpPanel.SetActive(setActive);
    }
}

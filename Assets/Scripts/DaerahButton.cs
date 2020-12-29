using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaerahButton : MonoBehaviour
{
    public DAERAH daerah;
    public GameObject daerahButton;
    
    public void OnButtonClicked()
    {
        MapUIController.instance.DeactivateAllButtonGroup();
        SetActiveDaerahButton(true);
    }

    private void SetActiveDaerahButton(bool setActive)
    {
        daerahButton.SetActive(setActive);
    }

    private void DeactivateDaerahButton()
    {
        SetActiveDaerahButton(false);
    }

    // Subscribing delegate;
    private void Awake()
    {
        MapUIController.onBGClicked += DeactivateDaerahButton;
    }

    public void UnsubscribeDelegate()
    {
        MapUIController.onBGClicked -= DeactivateDaerahButton;
    }
}

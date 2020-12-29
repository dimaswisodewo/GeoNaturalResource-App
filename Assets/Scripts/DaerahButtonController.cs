using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaerahButtonController : MonoBehaviour
{
    public DAERAH enumDaerah;

    public void OnDaerahButtonClicked()
    {
        MapUIController.instance.SetActivePopUpPanel(true);
        MapController.instance.SetDetailDaerah(enumDaerah);
    }
}

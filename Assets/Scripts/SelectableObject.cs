using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    public ISLAND island;

    public void OnObjectClicked()
    {
        MapUIController.instance.DeactivateAllButtonGroup();
        MapUIController.instance.SetActiveButtonGroup(island, true);
    }

}

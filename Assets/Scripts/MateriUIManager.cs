using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MateriUIManager : MonoBehaviour
{
    public List<GameObject> materiCanvasLibrary = new List<GameObject>();

    private void Awake()
    {
        SetActiveMateriCanvasLibrary(SceneLoader.instance.materiEnum);
    }

    private void SetActiveMateriCanvasLibrary(MATERI materiEnum)
    {
        foreach(GameObject materiCanvas in materiCanvasLibrary)
        {
            materiCanvas.SetActive(false);
        }

        switch (materiEnum)
        {
            case MATERI.MATERI_1:
                materiCanvasLibrary[0].SetActive(true);
                break;

            case MATERI.MATERI_2:
                materiCanvasLibrary[1].SetActive(true);
                break;

            case MATERI.MATERI_3:
                materiCanvasLibrary[2].SetActive(true);
                break;

            case MATERI.MATERI_4:
                materiCanvasLibrary[3].SetActive(true);
                break;

            case MATERI.KOMPETENSI_DASAR:
                materiCanvasLibrary[4].SetActive(true);
                break;
        }
    }

}

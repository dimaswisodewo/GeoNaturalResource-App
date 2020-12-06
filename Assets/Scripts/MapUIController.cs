using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapUIController : MonoBehaviour
{
    public static MapUIController instance;
    [Header("Button Group")]
    public GameObject jawaButtonGroup;
    public GameObject sumateraButtonGroup;
    public GameObject kalimantanButtonGroup;
    public GameObject sulawesiButtonGroup;
    public GameObject nusaTenggaraButtonGroup;
    public GameObject malukuButtonGroup;
    public GameObject papuaButtonGroup;
    [Header("Pop Up Panel")]
    public GameObject popUpPanel;
    public Text namaDaerahText;
    public Text SDAHayatiText;
    public Text SDANonHayatiText;
    public Image detailDaerahImage;
    public Image logoDaerahImage;
    public ScrollRect scrollRect;
    [Header("Library Sprite Daerah")]
    public List<Sprite> librarySpriteDaerah = new List<Sprite>();
    [Header("Library Logo Daerah")]
    public List<Sprite> libraryLogoDaerah = new List<Sprite>();

    public void ResetScrollRectPosition()
    {
        scrollRect.normalizedPosition = new Vector2(1f, 1f);
    }

    public void SetActivePopUpPanel(bool setActive)
    {
        SetActive(popUpPanel, setActive);
    }

    public void SetTitleText(string inputString)
    {
        SetText(namaDaerahText, inputString);
    }

    public void SetSDAHayatiText(string inputString)
    {
        SetText(SDAHayatiText, inputString);
    }

    public void SetSDANonHayatiText(string inputString)
    {
        SetText(SDANonHayatiText, inputString);
    }

    public void SetDetailDaerahImage(DAERAH inputDaerah)
    {
        switch (inputDaerah)
        {
            case DAERAH.ACEH:
                SetImage(detailDaerahImage, librarySpriteDaerah[0]);
                SetImage(logoDaerahImage, libraryLogoDaerah[0]);
                break;

            case DAERAH.SUMATERA_UTARA:
                SetImage(detailDaerahImage, librarySpriteDaerah[1]);
                SetImage(logoDaerahImage, libraryLogoDaerah[1]);
                break;

            case DAERAH.SUMATERA_BARAT:
                SetImage(detailDaerahImage, librarySpriteDaerah[2]);
                SetImage(logoDaerahImage, libraryLogoDaerah[2]);
                break;

            case DAERAH.RIAU:
                SetImage(detailDaerahImage, librarySpriteDaerah[3]);
                SetImage(logoDaerahImage, libraryLogoDaerah[3]);
                break;

            case DAERAH.KEPULAUAN_RIAU:
                SetImage(detailDaerahImage, librarySpriteDaerah[4]);
                SetImage(logoDaerahImage, libraryLogoDaerah[4]);
                break;

            case DAERAH.JAMBI:
                SetImage(detailDaerahImage, librarySpriteDaerah[5]);
                SetImage(logoDaerahImage, libraryLogoDaerah[5]);
                break;

            case DAERAH.BENGKULU:
                SetImage(detailDaerahImage, librarySpriteDaerah[6]);
                SetImage(logoDaerahImage, libraryLogoDaerah[6]);
                break;

            case DAERAH.SUMATERA_SELATAN:
                SetImage(detailDaerahImage, librarySpriteDaerah[7]);
                SetImage(logoDaerahImage, libraryLogoDaerah[7]);
                break;

            case DAERAH.BANGKA_BELITUNG:
                SetImage(detailDaerahImage, librarySpriteDaerah[8]);
                SetImage(logoDaerahImage, libraryLogoDaerah[8]);
                break;

            case DAERAH.LAMPUNG:
                SetImage(detailDaerahImage, librarySpriteDaerah[9]);
                SetImage(logoDaerahImage, libraryLogoDaerah[9]);
                break;

            case DAERAH.BANTEN:
                SetImage(detailDaerahImage, librarySpriteDaerah[10]);
                SetImage(logoDaerahImage, libraryLogoDaerah[10]);
                break;

            case DAERAH.JAWA_BARAT:
                SetImage(detailDaerahImage, librarySpriteDaerah[11]);
                SetImage(logoDaerahImage, libraryLogoDaerah[11]);
                break;

            case DAERAH.DKI_JAKARTA:
                SetImage(detailDaerahImage, librarySpriteDaerah[12]);
                SetImage(logoDaerahImage, libraryLogoDaerah[12]);
                break;

            case DAERAH.JAWA_TENGAH:
                SetImage(detailDaerahImage, librarySpriteDaerah[13]);
                SetImage(logoDaerahImage, libraryLogoDaerah[13]);
                break;

            case DAERAH.DI_YOGYAKARTA:
                SetImage(detailDaerahImage, librarySpriteDaerah[14]);
                SetImage(logoDaerahImage, libraryLogoDaerah[14]);
                break;

            case DAERAH.JAWA_TIMUR:
                SetImage(detailDaerahImage, librarySpriteDaerah[15]);
                SetImage(logoDaerahImage, libraryLogoDaerah[15]);
                break;

            case DAERAH.BALI:
                SetImage(detailDaerahImage, librarySpriteDaerah[16]);
                SetImage(logoDaerahImage, libraryLogoDaerah[16]);
                break;

            case DAERAH.NTB:
                SetImage(detailDaerahImage, librarySpriteDaerah[17]);
                SetImage(logoDaerahImage, libraryLogoDaerah[17]);
                break;

            case DAERAH.NTT:
                SetImage(detailDaerahImage, librarySpriteDaerah[18]);
                SetImage(logoDaerahImage, libraryLogoDaerah[18]);
                break;

            case DAERAH.KALIMANTAN_UTARA:
                SetImage(detailDaerahImage, librarySpriteDaerah[19]);
                SetImage(logoDaerahImage, libraryLogoDaerah[19]);
                break;

            case DAERAH.KALIMANTAN_BARAT:
                SetImage(detailDaerahImage, librarySpriteDaerah[20]);
                SetImage(logoDaerahImage, libraryLogoDaerah[20]);
                break;

            case DAERAH.KALIMANTAN_TENGAH:
                SetImage(detailDaerahImage, librarySpriteDaerah[21]);
                SetImage(logoDaerahImage, libraryLogoDaerah[21]);
                break;

            case DAERAH.KALIMANTAN_SELATAN:
                SetImage(detailDaerahImage, librarySpriteDaerah[22]);
                SetImage(logoDaerahImage, libraryLogoDaerah[22]);
                break;

            case DAERAH.KALIMANTAN_TIMUR:
                SetImage(detailDaerahImage, librarySpriteDaerah[23]);
                SetImage(logoDaerahImage, libraryLogoDaerah[23]);
                break;

            case DAERAH.GORONTALO:
                SetImage(detailDaerahImage, librarySpriteDaerah[24]);
                SetImage(logoDaerahImage, libraryLogoDaerah[24]);
                break;

            case DAERAH.SULAWESI_UTARA:
                SetImage(detailDaerahImage, librarySpriteDaerah[25]);
                SetImage(logoDaerahImage, libraryLogoDaerah[25]);
                break;

            case DAERAH.SULAWESI_BARAT:
                SetImage(detailDaerahImage, librarySpriteDaerah[26]);
                SetImage(logoDaerahImage, libraryLogoDaerah[26]);
                break;

            case DAERAH.SULAWESI_TENGAH:
                SetImage(detailDaerahImage, librarySpriteDaerah[27]);
                SetImage(logoDaerahImage, libraryLogoDaerah[27]);
                break;

            case DAERAH.SULAWESI_SELATAN:
                SetImage(detailDaerahImage, librarySpriteDaerah[28]);
                SetImage(logoDaerahImage, libraryLogoDaerah[28]);
                break;

            case DAERAH.SULAWESI_TENGGARA:
                SetImage(detailDaerahImage, librarySpriteDaerah[29]);
                SetImage(logoDaerahImage, libraryLogoDaerah[29]);
                break;

            case DAERAH.MALUKU_UTARA:
                SetImage(detailDaerahImage, librarySpriteDaerah[30]);
                SetImage(logoDaerahImage, libraryLogoDaerah[30]);
                break;

            case DAERAH.MALUKU:
                SetImage(detailDaerahImage, librarySpriteDaerah[31]);
                SetImage(logoDaerahImage, libraryLogoDaerah[31]);
                break;

            case DAERAH.PAPUA_BARAT:
                SetImage(detailDaerahImage, librarySpriteDaerah[32]);
                SetImage(logoDaerahImage, libraryLogoDaerah[32]);
                break;

            case DAERAH.PAPUA:
                SetImage(detailDaerahImage, librarySpriteDaerah[33]);
                SetImage(logoDaerahImage, libraryLogoDaerah[33]);
                break;
        }
    }

    public void SetActiveButtonGroup(ISLAND island, bool setActive)
    {
        switch (island)
        {
            case ISLAND.JAWA:
                SetActive(jawaButtonGroup, setActive);
                break;

            case ISLAND.SUMATERA:
                SetActive(sumateraButtonGroup, setActive);
                break;

            case ISLAND.KALIMANTAN:
                SetActive(kalimantanButtonGroup, setActive);
                break;

            case ISLAND.SULAWESI:
                SetActive(sulawesiButtonGroup, setActive);
                break;

            case ISLAND.NUSATENGGARA:
                SetActive(nusaTenggaraButtonGroup, setActive);
                break;

            case ISLAND.MALUKU:
                SetActive(malukuButtonGroup, setActive);
                break;

            case ISLAND.PAPUA:
                SetActive(papuaButtonGroup, setActive);
                break;
        }
    }

    public void DeactivateAllButtonGroup()
    {
        SetActiveButtonGroup(ISLAND.JAWA, false);
        SetActiveButtonGroup(ISLAND.SUMATERA, false);
        SetActiveButtonGroup(ISLAND.KALIMANTAN, false);
        SetActiveButtonGroup(ISLAND.SULAWESI, false);
        SetActiveButtonGroup(ISLAND.NUSATENGGARA, false);
        SetActiveButtonGroup(ISLAND.MALUKU, false);
        SetActiveButtonGroup(ISLAND.PAPUA, false);
    }

    private void SetImage(Image inputImage, Sprite inputSprite)
    {
        inputImage.sprite = inputSprite;
    }

    private void SetActive(GameObject inputObject, bool setActive)
    {
        inputObject.SetActive(setActive);
    }

    private void SetText(Text inputText, string inputString)
    {
        inputString = inputString.Replace("\\n", "\n");
        inputText.text = inputString;
    }

    private void Prepare()
    {
        SetActivePopUpPanel(false);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        Prepare();
    }
}

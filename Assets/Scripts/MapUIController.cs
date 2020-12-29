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
    public GameObject largeImagePanel;
    public GameObject largeImagePrefab;
    public Transform largeImageParent;
    public GameObject popUpPanel;
    public Text namaDaerahText;
    public Text SDAHayatiText;
    public Text SDANonHayatiText;
    public Image detailDaerahImage;
    public Image logoDaerahImage;
    public ScrollRect scrollRect;
    [Header("Library Sprite Daerah")]
    public List<ProvinsiSprite> libraryProvinsiSprite = new List<ProvinsiSprite>();

    // Deactivate all daerah button
    public delegate void OnBGClicked ();
    public static OnBGClicked onBGClicked;

    public void SetActivePopUpPanel(bool setActive)
    {
        SetActive(popUpPanel, setActive);
    }

    public void SetLargeImage(List<Sprite> librarySprite)
    {
        foreach (Sprite sprite in librarySprite)
        {
            GameObject largeImage = Instantiate(largeImagePrefab, new Vector3(0, 0, 0), Quaternion.identity);
            largeImage.GetComponent<Image>().sprite = sprite;
            largeImage.transform.SetParent(largeImageParent);
            largeImage.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    public void DestroyLargeImage()
    {
        if (largeImageParent.childCount > 0)
        {
            for (int i = 0; i < largeImageParent.childCount; i++)
            {
                Destroy(largeImageParent.GetChild(i).gameObject);
            }
        }
    }

    public void SetActiveLargeImagePanel(bool setActive)
    {
        SetActive(largeImagePanel, setActive);
        scrollRect.horizontalNormalizedPosition = 0f;
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
                SetImage(detailDaerahImage, libraryProvinsiSprite[0].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[0].GetLogo());
                SetLargeImage(libraryProvinsiSprite[0].librarySprite);
                break;

            case DAERAH.SUMATERA_UTARA:
                SetImage(detailDaerahImage, libraryProvinsiSprite[1].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[1].GetLogo());
                SetLargeImage(libraryProvinsiSprite[1].librarySprite);
                break;

            case DAERAH.SUMATERA_BARAT:
                SetImage(detailDaerahImage, libraryProvinsiSprite[2].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[2].GetLogo());
                SetLargeImage(libraryProvinsiSprite[2].librarySprite);
                break;

            case DAERAH.RIAU:
                SetImage(detailDaerahImage, libraryProvinsiSprite[3].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[3].GetLogo());
                SetLargeImage(libraryProvinsiSprite[3].librarySprite);
                break;

            case DAERAH.KEPULAUAN_RIAU:
                SetImage(detailDaerahImage, libraryProvinsiSprite[4].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[4].GetLogo());
                SetLargeImage(libraryProvinsiSprite[4].librarySprite);
                break;

            case DAERAH.JAMBI:
                SetImage(detailDaerahImage, libraryProvinsiSprite[5].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[5].GetLogo());
                SetLargeImage(libraryProvinsiSprite[5].librarySprite);
                break;

            case DAERAH.BENGKULU:
                SetImage(detailDaerahImage, libraryProvinsiSprite[6].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[6].GetLogo());
                SetLargeImage(libraryProvinsiSprite[6].librarySprite);
                break;

            case DAERAH.SUMATERA_SELATAN:
                SetImage(detailDaerahImage, libraryProvinsiSprite[7].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[7].GetLogo());
                SetLargeImage(libraryProvinsiSprite[7].librarySprite);
                break;

            case DAERAH.BANGKA_BELITUNG:
                SetImage(detailDaerahImage, libraryProvinsiSprite[8].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[8].GetLogo());
                SetLargeImage(libraryProvinsiSprite[8].librarySprite);
                break;

            case DAERAH.LAMPUNG:
                SetImage(detailDaerahImage, libraryProvinsiSprite[9].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[9].GetLogo());
                SetLargeImage(libraryProvinsiSprite[9].librarySprite);
                break;

            case DAERAH.BANTEN:
                SetImage(detailDaerahImage, libraryProvinsiSprite[10].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[10].GetLogo());
                SetLargeImage(libraryProvinsiSprite[10].librarySprite);
                break;

            case DAERAH.JAWA_BARAT:
                SetImage(detailDaerahImage, libraryProvinsiSprite[11].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[11].GetLogo());
                SetLargeImage(libraryProvinsiSprite[11].librarySprite);
                break;

            case DAERAH.DKI_JAKARTA:
                SetImage(detailDaerahImage, libraryProvinsiSprite[12].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[12].GetLogo());
                SetLargeImage(libraryProvinsiSprite[12].librarySprite);
                break;

            case DAERAH.JAWA_TENGAH:
                SetImage(detailDaerahImage, libraryProvinsiSprite[13].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[13].GetLogo());
                SetLargeImage(libraryProvinsiSprite[13].librarySprite);
                break;

            case DAERAH.DI_YOGYAKARTA:
                SetImage(detailDaerahImage, libraryProvinsiSprite[14].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[14].GetLogo());
                SetLargeImage(libraryProvinsiSprite[14].librarySprite);
                break;

            case DAERAH.JAWA_TIMUR:
                SetImage(detailDaerahImage, libraryProvinsiSprite[15].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[15].GetLogo());
                SetLargeImage(libraryProvinsiSprite[15].librarySprite);
                break;

            case DAERAH.BALI:
                SetImage(detailDaerahImage, libraryProvinsiSprite[16].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[16].GetLogo());
                SetLargeImage(libraryProvinsiSprite[16].librarySprite);
                break;

            case DAERAH.NTB:
                SetImage(detailDaerahImage, libraryProvinsiSprite[17].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[17].GetLogo());
                SetLargeImage(libraryProvinsiSprite[17].librarySprite);
                break;

            case DAERAH.NTT:
                SetImage(detailDaerahImage, libraryProvinsiSprite[18].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[18].GetLogo());
                SetLargeImage(libraryProvinsiSprite[18].librarySprite);
                break;

            case DAERAH.KALIMANTAN_UTARA:
                SetImage(detailDaerahImage, libraryProvinsiSprite[19].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[19].GetLogo());
                SetLargeImage(libraryProvinsiSprite[19].librarySprite);
                break;

            case DAERAH.KALIMANTAN_BARAT:
                SetImage(detailDaerahImage, libraryProvinsiSprite[20].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[20].GetLogo());
                SetLargeImage(libraryProvinsiSprite[20].librarySprite);
                break;

            case DAERAH.KALIMANTAN_TENGAH:
                SetImage(detailDaerahImage, libraryProvinsiSprite[21].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[21].GetLogo());
                SetLargeImage(libraryProvinsiSprite[21].librarySprite);
                break;

            case DAERAH.KALIMANTAN_SELATAN:
                SetImage(detailDaerahImage, libraryProvinsiSprite[22].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[22].GetLogo());
                SetLargeImage(libraryProvinsiSprite[22].librarySprite);
                break;

            case DAERAH.KALIMANTAN_TIMUR:
                SetImage(detailDaerahImage, libraryProvinsiSprite[23].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[23].GetLogo());
                SetLargeImage(libraryProvinsiSprite[23].librarySprite);
                break;

            case DAERAH.GORONTALO:
                SetImage(detailDaerahImage, libraryProvinsiSprite[24].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[24].GetLogo());
                SetLargeImage(libraryProvinsiSprite[24].librarySprite);
                break;

            case DAERAH.SULAWESI_UTARA:
                SetImage(detailDaerahImage, libraryProvinsiSprite[25].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[25].GetLogo());
                SetLargeImage(libraryProvinsiSprite[25].librarySprite);
                break;

            case DAERAH.SULAWESI_BARAT:
                SetImage(detailDaerahImage, libraryProvinsiSprite[26].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[26].GetLogo());
                SetLargeImage(libraryProvinsiSprite[26].librarySprite);
                break;

            case DAERAH.SULAWESI_TENGAH:
                SetImage(detailDaerahImage, libraryProvinsiSprite[27].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[27].GetLogo());
                SetLargeImage(libraryProvinsiSprite[27].librarySprite);
                break;

            case DAERAH.SULAWESI_SELATAN:
                SetImage(detailDaerahImage, libraryProvinsiSprite[28].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[28].GetLogo());
                SetLargeImage(libraryProvinsiSprite[28].librarySprite);
                break;

            case DAERAH.SULAWESI_TENGGARA:
                SetImage(detailDaerahImage, libraryProvinsiSprite[29].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[29].GetLogo());
                SetLargeImage(libraryProvinsiSprite[29].librarySprite);
                break;

            case DAERAH.MALUKU_UTARA:
                SetImage(detailDaerahImage, libraryProvinsiSprite[30].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[30].GetLogo());
                SetLargeImage(libraryProvinsiSprite[30].librarySprite);
                break;

            case DAERAH.MALUKU:
                SetImage(detailDaerahImage, libraryProvinsiSprite[31].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[31].GetLogo());
                SetLargeImage(libraryProvinsiSprite[31].librarySprite);
                break;

            case DAERAH.PAPUA_BARAT:
                SetImage(detailDaerahImage, libraryProvinsiSprite[32].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[32].GetLogo());
                SetLargeImage(libraryProvinsiSprite[32].librarySprite);
                break;

            case DAERAH.PAPUA:
                SetImage(detailDaerahImage, libraryProvinsiSprite[33].GetFirstImage());
                SetImage(logoDaerahImage, libraryProvinsiSprite[33].GetLogo());
                SetLargeImage(libraryProvinsiSprite[33].librarySprite);
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
        //SetActiveButtonGroup(ISLAND.JAWA, false);
        //SetActiveButtonGroup(ISLAND.SUMATERA, false);
        //SetActiveButtonGroup(ISLAND.KALIMANTAN, false);
        //SetActiveButtonGroup(ISLAND.SULAWESI, false);
        //SetActiveButtonGroup(ISLAND.NUSATENGGARA, false);
        //SetActiveButtonGroup(ISLAND.MALUKU, false);
        //SetActiveButtonGroup(ISLAND.PAPUA, false);

        onBGClicked ();
    }

    public void ClearDelegateSubscription()
    {
        onBGClicked = null;
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

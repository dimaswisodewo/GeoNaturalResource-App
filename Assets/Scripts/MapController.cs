using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public static MapController instance;

    public void OnCloseButtonClicked()
    {
        MapUIController.instance.SetActivePopUpPanel(false);
        MapUIController.instance.DestroyLargeImage();
    }

    public void SetDetailDaerah(DAERAH inputDaerah)
    {
        switch (inputDaerah)
        {
            case DAERAH.ACEH:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[0].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.ACEH);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[0].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[0].sumberDayaNonHayati);
                break;

            case DAERAH.SUMATERA_UTARA:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[1].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.SUMATERA_UTARA);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[1].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[1].sumberDayaNonHayati);
                break;

            case DAERAH.SUMATERA_BARAT:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[2].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.SUMATERA_BARAT);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[2].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[2].sumberDayaNonHayati);
                break;

            case DAERAH.RIAU:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[3].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.RIAU);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[3].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[3].sumberDayaNonHayati);
                break;

            case DAERAH.KEPULAUAN_RIAU:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[4].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.KEPULAUAN_RIAU);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[4].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[4].sumberDayaNonHayati);
                break;

            case DAERAH.JAMBI:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[5].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.JAMBI);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[5].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[5].sumberDayaNonHayati);
                break;

            case DAERAH.BENGKULU:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[6].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.BENGKULU);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[6].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[6].sumberDayaNonHayati);
                break;

            case DAERAH.SUMATERA_SELATAN:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[7].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.SUMATERA_SELATAN);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[7].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[7].sumberDayaNonHayati);
                break;

            case DAERAH.BANGKA_BELITUNG:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[8].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.BANGKA_BELITUNG);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[8].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[8].sumberDayaNonHayati);
                break;

            case DAERAH.LAMPUNG:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[9].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.LAMPUNG);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[9].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[9].sumberDayaNonHayati);
                break;

            case DAERAH.BANTEN:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[10].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.BANTEN);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[10].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[10].sumberDayaNonHayati);
                break;

            case DAERAH.JAWA_BARAT:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[11].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.JAWA_BARAT);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[11].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[11].sumberDayaNonHayati);
                break;

            case DAERAH.DKI_JAKARTA:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[12].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.DKI_JAKARTA);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[12].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[12].sumberDayaNonHayati);
                break;

            case DAERAH.JAWA_TENGAH:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[13].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.JAWA_TENGAH);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[13].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[13].sumberDayaNonHayati);
                break;

            case DAERAH.DI_YOGYAKARTA:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[14].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.DI_YOGYAKARTA);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[14].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[14].sumberDayaNonHayati);
                break;

            case DAERAH.JAWA_TIMUR:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[15].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.JAWA_TIMUR);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[15].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[15].sumberDayaNonHayati);
                break;

            case DAERAH.BALI:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[16].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.BALI);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[16].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[16].sumberDayaNonHayati);
                break;

            case DAERAH.NTB:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[17].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.NTB);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[17].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[17].sumberDayaNonHayati);
                break;

            case DAERAH.NTT:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[18].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.NTT);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[18].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[18].sumberDayaNonHayati);
                break;

            case DAERAH.KALIMANTAN_UTARA:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[19].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.KALIMANTAN_UTARA);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[19].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[19].sumberDayaNonHayati);
                break;

            case DAERAH.KALIMANTAN_BARAT:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[20].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.KALIMANTAN_BARAT);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[20].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[20].sumberDayaNonHayati);
                break;

            case DAERAH.KALIMANTAN_TENGAH:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[21].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.KALIMANTAN_TENGAH);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[21].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[21].sumberDayaNonHayati);
                break;

            case DAERAH.KALIMANTAN_SELATAN:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[22].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.KALIMANTAN_SELATAN);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[22].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[22].sumberDayaNonHayati);
                break;

            case DAERAH.KALIMANTAN_TIMUR:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[23].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.KALIMANTAN_TIMUR);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[23].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[23].sumberDayaNonHayati);
                break;

            case DAERAH.GORONTALO:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[24].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.GORONTALO);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[24].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[24].sumberDayaNonHayati);
                break;

            case DAERAH.SULAWESI_UTARA:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[25].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.SULAWESI_UTARA);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[25].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[25].sumberDayaNonHayati);
                break;

            case DAERAH.SULAWESI_BARAT:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[26].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.SULAWESI_BARAT);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[26].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[26].sumberDayaNonHayati);
                break;

            case DAERAH.SULAWESI_TENGAH:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[27].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.SULAWESI_TENGAH);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[27].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[27].sumberDayaNonHayati);
                break;

            case DAERAH.SULAWESI_SELATAN:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[28].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.SULAWESI_SELATAN);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[28].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[28].sumberDayaNonHayati);
                break;

            case DAERAH.SULAWESI_TENGGARA:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[29].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.SULAWESI_TENGGARA);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[29].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[29].sumberDayaNonHayati);
                break;

            case DAERAH.MALUKU_UTARA:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[30].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.MALUKU_UTARA);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[30].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[30].sumberDayaNonHayati);
                break;

            case DAERAH.MALUKU:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[31].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.MALUKU);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[31].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[31].sumberDayaNonHayati);
                break;

            case DAERAH.PAPUA_BARAT:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[32].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.PAPUA_BARAT);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[32].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[32].sumberDayaNonHayati);
                break;

            case DAERAH.PAPUA:
                MapUIController.instance.SetTitleText(MapDataManager.instance.mapData.provinsiData[33].nama);
                MapUIController.instance.SetDetailDaerahImage(DAERAH.PAPUA);
                MapUIController.instance.SetSDAHayatiText(MapDataManager.instance.mapData.provinsiData[33].sumberDayaHayati);
                MapUIController.instance.SetSDANonHayatiText(MapDataManager.instance.mapData.provinsiData[33].sumberDayaNonHayati);
                break;
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}

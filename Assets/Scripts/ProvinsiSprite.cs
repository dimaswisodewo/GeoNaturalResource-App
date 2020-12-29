using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProvinsiSprite : MonoBehaviour
{
    public DAERAH enumDaerah;
    public Sprite logo;
    public List<Sprite> librarySprite = new List<Sprite>();

    public Sprite GetFirstImage()
    {
        return librarySprite[0];
    }

    public Sprite GetLogo()
    {
        return logo;
    }
}

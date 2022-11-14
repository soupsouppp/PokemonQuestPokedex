using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Viewer : MonoBehaviour
{
    public TMPro.TextMeshProUGUI number;
    public Image Pokemonimage;
    public TMPro.TextMeshProUGUI PokemonName;
    public TMPro.TextMeshProUGUI PokemonType;




    [System.Serializable]
    public class PageInfo
    {
        public Sprite showcase;
    }

    public List<PageInfo> allPages = new List<PageInfo>();
    private int currentPageIndex;


    public void goPrevious()
    {
        currentPageIndex--;

        if (currentPageIndex < 0)
        {
            currentPageIndex = allPages.Count - 1;
        }
        PageInfo info = allPages[currentPageIndex];
        showPage(info.showcase);
    }


    public void goNext()
    {
        currentPageIndex++;

        if(currentPageIndex >= allPages.Count)
        {
            currentPageIndex = 0;
        }
        PageInfo info = allPages[currentPageIndex];
        showPage(info.showcase);


    }


    // Start is called before the first frame update
    void Start()
    {
        PageInfo info = allPages[currentPageIndex];
        showPage(info.showcase);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void showPage(Sprite image)
    {
        Pokemonimage.sprite = image;
    }

   
}

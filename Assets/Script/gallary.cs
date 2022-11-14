using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class gallary : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Number;
    public Image Pokemonimage;
    public TMPro.TextMeshProUGUI Name;
    public TMPro.TextMeshProUGUI Type;



    public List<pokemon> allPages = new List<pokemon>();
    private int currentPageIndex;


    public void goPrevious()
    {
        currentPageIndex--;

        if (currentPageIndex < 0)
        {
            currentPageIndex = allPages.Count - 1;
        }
        pokemon info = allPages[currentPageIndex];

        if (info.seenPokemon == true)
        {
            showPage(info.Title, info.Image, info.Number, info.Type);
        }
        if (info.seenPokemon == false)
        {
            showPage("???", info.UnseenImage, "No.???", "???");

        }
    }


    public void goNext()
    {
        currentPageIndex++;

        if (currentPageIndex >= allPages.Count)
        {
            currentPageIndex = 0;
        }
        pokemon info = allPages[currentPageIndex];

        if (info.seenPokemon == true)
        {
            showPage(info.Title, info.Image, info.Number, info.Type);
        }
        if (info.seenPokemon == false)
        {
            showPage("???", info.UnseenImage, "No.???", "???");

        }

    }


    // Start is called before the first frame update
    void Start()
    {
        pokemon info = allPages[currentPageIndex];
        showPage(info.Title, info.Image, info.Number, info.Type);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void showPage(string name, Sprite image, string number, string type)
    {
        Pokemonimage.sprite = image;
        Number.text = number;
        Name.text = name;
        Type.text = type;
    }

    public void seePokemon()
    {
        pokemon info = allPages[currentPageIndex];
        info.seenPokemon = true;
        showPage(info.Title, info.Image, info.Number, info.Type);
    }

}

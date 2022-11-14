using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "pokemons", menuName = "pokemonSlot")]
public class pokemon : ScriptableObject
{
    public bool seenPokemon;

    public string Title;
    public Sprite Image;
    public Sprite UnseenImage;
    public string Type;
    public string Number;

}

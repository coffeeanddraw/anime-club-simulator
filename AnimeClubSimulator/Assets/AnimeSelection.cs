using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeSelection : MonoBehaviour
{
    private static string selectedAnime = "";

    public static string SelectedAnime
    {
        get { return selectedAnime; }
        set { selectedAnime = value; }
    }

    public void Naturo()
    {
        selectedAnime = "Naturo";
        Debug.Log("Next Week's Anime: Naturo");
    }

    public void SailorSun()
    {
        selectedAnime = "Sailor Sun";
        Debug.Log("Next Week's Anime: Sailor Sun");
    }

    public void NoMetalAlchemists()
    {
        selectedAnime = "No Metal Alchemists";
        Debug.Log("Next Week's Anime: No Metal Alchemists");
    }

    public void TwoPiece()
    {
        selectedAnime = "Two Piece";
        Debug.Log("Next Week's Anime: Two Piece");
    }

    public void LifeNote()
    {
        selectedAnime = "Life Note";
        Debug.Log("Next Week's Anime: Life Note");
    }

    public void DragonsBalls()
    {
        selectedAnime = "Dragon's Balls";
        Debug.Log("Next Week's Anime: Dragon's Balls");
    }
}

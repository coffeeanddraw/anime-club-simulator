using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimeSelection : MonoBehaviour
{
    Dropdown m_Dropdown;

    private static string selectedAnime = "";

    public static string SelectedAnime
    {
        get { return selectedAnime; }
        set { selectedAnime = value; }
    }

    private void Start()
    {
        // Fetch the Dropdown GameObject
        m_Dropdown = GetComponent<Dropdown>();
        // Add listner for when the value of the Dropdown changes, to take action 
        m_Dropdown.onValueChanged.AddListener(delegate {
            DropdownValueChanged(m_Dropdown);
        });
    }

    void DropdownValueChanged(Dropdown change)
    {

        // set selectedAnime value to selected dropdown value
        switch(m_Dropdown.value)
        {
            case 0:
                selectedAnime = "Naturo";
                break;
            case 1:
                selectedAnime = "Sailor Sun";
                break;
            case 2:
                selectedAnime = "No Metal Alchemists";
                break;
            case 3:
                selectedAnime = "Two Piece";
                break;
            case 4:
                selectedAnime = "Life Note";
                break;
            case 5:
                selectedAnime = "Dragon's Balls";
                break;
        }

        Debug.Log(selectedAnime);
    }
}

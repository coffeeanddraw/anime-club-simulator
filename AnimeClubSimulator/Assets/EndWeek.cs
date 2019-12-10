using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWeek : MonoBehaviour
{
    public void EndWeekClick()
    {
        ClubManager.ThisWeeksAnime = AnimeSelection.SelectedAnime;
        Debug.Log("End week");
    }
}

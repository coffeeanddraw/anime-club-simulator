using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndWeek : MonoBehaviour
{
    public void EndWeekClick()
    {
        ClubManager.ThisWeeksAnime = AnimeSelection.SelectedAnime;
        ClubManager.Funds -= ClubUpdates.SelectedFunds;
        ClubManager.Reputation += ClubUpdates.SelectedReputation;
        ClubManager.Problems += ClubUpdates.SelectedProblems;

        Debug.Log("End week");
    }
}

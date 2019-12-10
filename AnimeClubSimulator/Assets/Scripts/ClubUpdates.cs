using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubUpdates : MonoBehaviour
{
    private string thisWeeksAnime = "";
    public void buySnack()
    {
        ClubManager.Funds -= 30;
        ClubManager.Reputation += 10;

        if (chanceOfProblem() > 30)
        {
            Debug.Log("Club members did not like the snack.");
            ClubManager.Problems += 1; 
        }
    }

    public void improveProjector()
    {
        ClubManager.Funds -= 150;
        ClubManager.Reputation += 50;

        if (chanceOfProblem() > 30)
        {
            Debug.Log("The projector is faulty.");
            ClubManager.Problems += 1;
        }
    }

    public void distributePosters()
    {
        ClubManager.Funds -= 50;
        ClubManager.Reputation += 30; 

        if (chanceOfProblem() > 30)
        {
            Debug.Log("There was a paper jam.");
            ClubManager.Problems += 1; 
        }
    }

    public void chooseAnime()
    {
        // Add new anime here //
        switch (thisWeeksAnime)
        {
            case "Naturo":
                ClubManager.ThisWeeksAnime = "Naturo";
                break;
            case "Sailor Sun":
                ClubManager.ThisWeeksAnime = "Sailor Sun";
                break;
            case "No Metal Alchemists":
                ClubManager.ThisWeeksAnime = "No Metal Alchemists";
                break;
            case "Two Piece":
                ClubManager.ThisWeeksAnime = "Two Piece";
                break;
            case "Life Note":
                ClubManager.ThisWeeksAnime = "Life Note";
                break;
            case "Dragon's Balls":
                ClubManager.ThisWeeksAnime = "Dragon's Balls";
                break;
        }

        ClubManager.Funds -= 10; 
    }
    
    private int chanceOfProblem()
    {
        System.Random rand = new System.Random();
        int chance = rand.Next(1, 100);

        return chance;
    }

    private bool tryToSolveProblem()
    {
        ClubManager.Funds -= 50;

        if (ClubManager.Problems != 0)
        {
            if (chanceOfSolvingProblem() > 50)
            {
                ClubManager.Problems -= 1;
                ClubManager.Reputation += 55;
                return true;
            }
            else
            {
                ClubManager.Problems -= 1;
                ClubManager.Reputation -= 22;
                return false;
            }
        }
        else 
        {
            return false;
        }
    }

    private int chanceOfSolvingProblem()
    {
        System.Random rand = new System.Random();
        int chance = rand.Next(1, 100);

        return chance; 
    }


}

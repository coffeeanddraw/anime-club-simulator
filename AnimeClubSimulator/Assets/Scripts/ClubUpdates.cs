using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubUpdates : MonoBehaviour
{

    private static int selectedFunds = 0;
    private static int selectedReputation = 0;
    private static int selectedProblems = 0;

    public static int SelectedFunds
    {
        get { return selectedFunds; }
        set { selectedFunds = value; }
    }

    public static int SelectedReputation
    {
        get { return selectedReputation; }
        set { selectedReputation = value; }
    }

    public static int SelectedProblems
    {
        get { return selectedProblems; }
        set { selectedProblems = value; }
    }

    private bool snackSelected = false;
    private bool snackProblem = false;
    private bool projectorSelected = false;
    private bool projectorProblem = false;
    private bool posterSelected = false;
    private bool posterProblem = false;
    private bool clubOutingSelected = false;
    private bool clubOutingProblem = false; 

    public void buySnack()
    {
        if (snackSelected == true) // gets called when the toggle box is unchecked 
        {
            selectedFunds -= 30;
            selectedReputation -= 10;

            if (snackProblem == true)
            {
                selectedProblems -= 1;
                snackProblem = false; 
            }

            snackSelected = false;
        }
        else // called when the toggle box is checked 
        {
            snackSelected = true;

            selectedFunds += 30;
            selectedReputation += 10; 

            if (chanceOfProblem() > 30)
            {
                Debug.Log("Club members did not like the snack.");
                selectedProblems += 1;
                snackProblem = true;
            }
        }
       
    }

    public void improveProjector()
    {
        if (projectorSelected == true) // gets called when the toggle box is unchecked  
        {
            selectedFunds -= 150;
            selectedReputation -= 50; 

            if (projectorProblem == true)
            {
                selectedProblems -= 1;
                projectorProblem = false; 
            }

            projectorSelected = false; 
        }
        else // called when the toggle box is checked 
        {
            projectorSelected = true;

            selectedFunds += 150;
            selectedReputation += 50; 

            if (chanceOfProblem() > 30)
            {
                Debug.Log("The projector is faulty.");
                selectedProblems += 1;
                projectorProblem = false; 
            }
        }
    }

    public void distributePosters()
    {
        if (posterSelected == true)
        {
            selectedFunds -= 50;
            selectedReputation -= 30; 

            if (posterProblem == true)
            {
                selectedProblems -= 1;
                posterProblem = false;
            }

            posterSelected = false; 
        }
        else
        {
            posterSelected = true;

            selectedFunds += 50;
            selectedReputation += 30;

            if (chanceOfProblem() > 30)
            {
                Debug.Log("There was a paper jam.");
                selectedProblems += 1;
                posterProblem = true;
            }
        }
    }

    public void clubOuting()
    {
        if (clubOutingSelected == true)
        {
            selectedFunds -= 80;
            selectedReputation -= 50; 

            if (clubOutingProblem == true)
            {
                selectedProblems -= 1;
                clubOutingProblem = false; 
            }

            clubOutingSelected = false; 
        }
        else
        {
            clubOutingSelected = true;

            selectedFunds += 80;
            selectedReputation += 50;

            if (chanceOfProblem() > 30)
            {
                Debug.Log("There was an issue with the outing.");
                selectedProblems += 1;
                clubOutingProblem = true;
            }
        }
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

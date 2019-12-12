using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubUpdates : MonoBehaviour
{

    private static int selectedFunds = 0;
    private static int selectedReputation = 0;
    private static int selectedProblems = 0;
    private static int selectedPrice = 0;

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

    public static int SelectedPrice
    {
        get { return selectedPrice; }
        set { selectedPrice = value; }
    }

    private bool snackSelected = false;
    private bool snackProblem = false;
    private bool snackBought = false; 
    private bool projectorSelected = false;
    private bool projectorProblem = false;
    private bool projectorBought = false;
    private bool posterSelected = false;
    private bool posterProblem = false;
    private bool posterBought = false;
    private bool clubOutingSelected = false;
    private bool clubOutingProblem = false;
    private bool clubOutingBought = false;

    private int snackPrice = 30;
    private int projectorPrice = 150;
    private int posterPrice = 50;
    private int clubOutingPrice = 80;
    private int troubleshootPrice = 20; 

    private int snackReputation = 10;
    private int projectorReputation = 50;
    private int posterReputation = 30;
    private int clubOutingReputation = 50;

    public void BuySnack()
    {
        if (snackSelected) // gets called when the toggle box is unchecked 
        {
            if (snackBought)
            {
                selectedFunds -= snackPrice;
                selectedReputation -= snackReputation;

                if (snackProblem)
                {
                    selectedProblems -= 1;
                    snackProblem = false;
                }
                snackBought = false;
            }
            snackSelected = false;
        }
        else // called when the toggle box is checked 
        {
            snackSelected = true;


            if (ClubManager.Funds >= snackPrice)
            {
                snackBought = true;
                selectedFunds += snackPrice;
                selectedReputation += snackReputation;

                if (ChanceOfProblem() > 30)
                {
                    Debug.Log("Club members did not like the snack.");
                    selectedProblems += 1;
                    snackProblem = true;
                }
            }
            else
            {
                ClubManager.NotificationText = "Anime Club cannot afford to buy snacks.\nThere will be more funds available next semester.";
            } 
        }  
    }

    public void ImproveProjector()
    {
        if (projectorSelected) // gets called when the toggle box is unchecked  
        {
            if (projectorBought)
            {
                selectedFunds -= projectorPrice;
                selectedReputation -= projectorReputation;

                if (projectorProblem)
                {
                    selectedProblems -= 1;
                    projectorProblem = false;
                }
                projectorBought = false;
            }
            projectorSelected = false; 
        }
        else // called when the toggle box is checked 
        {
            projectorSelected = true;

            if (ClubManager.Funds >= projectorPrice)
            {
                projectorBought = true;
                selectedFunds += projectorPrice;
                selectedReputation += projectorReputation;

                if (ChanceOfProblem() > 30)
                {
                    Debug.Log("The projector is faulty.");
                    selectedProblems += 1;
                    projectorProblem = false;
                }
            }
            else
            {
                ClubManager.NotificationText = "Anime Club cannot afford to upgrade the projector.\nThere will be more funds available next semester.";
            }
        }
    }

    public void DistributePosters()
    {
        if (posterSelected)
        {
            if (posterBought)
            {
                selectedFunds -= posterPrice;
                selectedReputation -= posterReputation;

                if (posterProblem)
                {
                    selectedProblems -= 1;
                    posterProblem = false;
                }
                posterBought = false;
            }
            posterSelected = false; 
        }
        else
        {
            posterSelected = true;

            if (ClubManager.Funds >= posterPrice)
            {
                posterBought = true;
                selectedFunds += posterPrice;
                selectedReputation += posterReputation;

                if (ChanceOfProblem() > 30)
                {
                    Debug.Log("There was a paper jam.");
                    selectedProblems += 1;
                    posterProblem = true;
                }
            }
            else
            {
                ClubManager.NotificationText = "Anime Club cannot afford to print posters.\nThere will be more funds available next semester.";
            }
        }
    }

    public void ClubOuting()
    {
        if (clubOutingSelected)
        {
            if (clubOutingBought)
            {
                selectedFunds -= clubOutingPrice;
                selectedReputation -= clubOutingReputation;

                if (clubOutingProblem)
                {
                    selectedProblems -= 1;
                    clubOutingProblem = false;
                }
                clubOutingBought = false;
            }
            clubOutingSelected = false; 
        }
        else
        {
            clubOutingSelected = true;

            if (ClubManager.Funds >= clubOutingPrice)
            {
                clubOutingBought = true;
                selectedFunds += clubOutingPrice;
                selectedReputation += clubOutingReputation;

                if (ChanceOfProblem() > 30)
                {
                    Debug.Log("There was an issue with the outing.");
                    selectedProblems += 1;
                    clubOutingProblem = true;
                }
            }
            else
            {
                ClubManager.NotificationText = "Anime Club cannot afford to go on a club outing.\nThere will be more funds available next semester.";
            }
        }
    }
    
    private int ChanceOfProblem()
    {
        System.Random rand = new System.Random();
        int chance = rand.Next(1, 100);

        return chance;
    }

    // used by Troubleshoot button 
    public void Troubleshoot()
    {
        ClubManager.Funds -= troubleshootPrice;

        if (ClubManager.Problems != 0)
        {
            if (ClubManager.Funds >= troubleshootPrice)
            {
                selectedFunds += troubleshootPrice;

                if (ChanceOfSolvingProblem() > 30)
                {
                    ClubManager.Problems -= 1;
                    ClubManager.Reputation += 55;
                    ClubManager.NotificationText = "Troubleshoot successful!";
                }
                else
                {
                    ClubManager.Problems += 1;
                    ClubManager.Reputation -= 22;
                    ClubManager.NotificationText = "Troubleshoot fail.";
                }
            }
            else if (ClubManager.Funds < troubleshootPrice )
            {
                ClubManager.NotificationText = "Anime Club cannot afford to troubleshoot.\nThere will be more funds available next semester.";
            }
        }
    }

    private int ChanceOfSolvingProblem()
    {
        System.Random rand = new System.Random();
        int chance = rand.Next(1, 100);

        return chance; 
    }


}

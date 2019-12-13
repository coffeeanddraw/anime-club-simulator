using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndWeek : MonoBehaviour
{
    [SerializeField]
    Toggle m_ToggleOne = null;
    [SerializeField]
    Toggle m_ToggleTwo = null;
    [SerializeField]
    Toggle m_ToggleThree = null;
    [SerializeField]
    Toggle m_ToggleFour = null;

    [SerializeField]
    GameObject winCanvas = null;
    [SerializeField]
    GameObject loseCanvas = null;

    public void EndWeekClick()
    {
        ClubManager.ThisWeeksAnime = AnimeSelection.SelectedAnime;

        ClubManager.Funds -= ClubUpdates.SelectedFunds;

        // Fundraiser

        if (Fundraiser.SelectedFundraiserIncome != 0)
        {
            ClubManager.Funds += Fundraiser.SelectedFundraiserIncome;
            Fundraiser.SelectedFundraiserIncome = 0;
            Fundraiser.CurrentFundraiser += 1; // count fundraiser number to check if the max fundraiser number has been met 
        }
        

        ClubManager.Reputation += ClubUpdates.SelectedReputation;
        ClubManager.Problems += ClubUpdates.SelectedProblems;

        ClubUpdates.SelectedPrice = 0;

        m_ToggleOne.isOn = false;
        m_ToggleTwo.isOn = false;
        m_ToggleThree.isOn = false;
        m_ToggleFour.isOn = false;

        AddNewMembers();

        ClubUpdates.SelectedFunds = 0;
        ClubUpdates.SelectedReputation = 0;
        ClubUpdates.SelectedProblems = 0;

        Debug.Log("End week");

        // Win State //
        if (ClubManager.MemberCount >= 52)
        {
            winCanvas.SetActive(true);
        }

        // Lose State // 
        if (ClubManager.Funds <= 0 && Fundraiser.FundraiserMaxReached || ClubManager.Problems == 10)
        {
            loseCanvas.SetActive(true);
        }
    }

    private void AddNewMembers()
    {
        if (ClubManager.Reputation >= 10)
        {
            if (ChanceOfNewMembers() > 85)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 3);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";

                IsClubFull(newMembers);
            }
        }
        else if (ClubManager.Reputation >= 30)
        {
            if (ChanceOfNewMembers() > 80)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 6);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";

                IsClubFull(newMembers);
            }
        } 
        else if (ClubManager.Reputation >= 50)
        {
            if (ChanceOfNewMembers() > 75)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 9);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";

                IsClubFull(newMembers);
            }
        }
        else if (ClubManager.Reputation >= 70)
        {
            if (ChanceOfNewMembers() > 70)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 12);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";

                IsClubFull(newMembers);
            }
        }
        else if (ClubManager.Reputation >= 90)
        {
            if (ChanceOfNewMembers() > 65)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 15);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";

                IsClubFull(newMembers);
            }
        }
        else if (ClubManager.Reputation >= 110)
        {
            if (ChanceOfNewMembers() > 60)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 18);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";

                IsClubFull(newMembers);
            }
        }
        else if (ClubManager.Reputation >= 130)
        {
            if (ChanceOfNewMembers() > 55)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 21);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";

                IsClubFull(newMembers);
            }
        }
        else if (ClubManager.Reputation >= 150)
        {
            if (ChanceOfNewMembers() > 50)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 24);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";

                IsClubFull(newMembers);
            }
        }
        else if (ClubManager.Reputation >= 170)
        {
            if (ChanceOfNewMembers() > 45)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 27);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";

                IsClubFull(newMembers);
            }
        }
        else if (ClubManager.Reputation >= 180)
        {
            if (ChanceOfNewMembers() > 40)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 30);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";
                IsClubFull(newMembers);
            }
        }
        else if (ClubManager.Reputation >= 200)
        {
            if (ChanceOfNewMembers() > 35)
            {
                System.Random rand = new System.Random();
                int newMembers = rand.Next(1, 33);
                ClubManager.MemberCount += newMembers;
                ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!";
                IsClubFull(newMembers);
            }
        }
    }

    private static void IsClubFull(int newMembers)
    {
        if (ClubManager.MemberCount == 52)
        {
            ClubManager.NotificationText = "Anime club has attracted " + newMembers + " new members!\nClub is now FULL!";
        }
    }

    private int ChanceOfNewMembers()
    {
        System.Random rand = new System.Random();
        int chance = rand.Next(1, 100);

        return chance;
    }
}

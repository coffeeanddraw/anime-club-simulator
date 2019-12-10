using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClubManager : MonoBehaviour
{
    // Initial Values //
    private static int memberCount = 5;
    private static int reputation = 500;
    private static int funds = 500;
    private static int problems = 0;
    private static string thisWeeksAnime = "";
    

    // Getters & Setters for Initial Values //
    public static int MemberCount
    {
        get { return memberCount; }
        set { memberCount = value; }
    }
    public static int Reputation
    {
        get { return reputation; }
        set { reputation = value; }
    }

    public static int Funds
    {
        get { return funds; }
        set { funds = value; }
    }

    public static int Problems
    {
        get { return problems; }
        set { problems = value; }
    }

    public static string ThisWeeksAnime
    {
        get { return thisWeeksAnime; }
        set { thisWeeksAnime = value; }
    }
}

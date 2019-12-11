using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlugIn : MonoBehaviour
{
    // Plug in UI elements // 

    [SerializeField]
    private Text thisWeeksAnime = null;

    [SerializeField]
    private Text memberCount = null;

    [SerializeField]
    private Text funds = null;

    [SerializeField]
    private Text problems = null;

    [SerializeField]
    private Text reputation = null;

    [SerializeField]
    private Text notificationText = null;

    void Awake()
    {
        notificationText.text = "";
    }

    void Update()
    {
        PrintHUD();
    }

    void PrintHUD()
    {
        thisWeeksAnime.text = "This Week's Anime: " + ClubManager.ThisWeeksAnime;
        memberCount.text = "Members: " + ClubManager.MemberCount.ToString();
        funds.text = "Funds: " + ClubManager.Funds.ToString();
        problems.text = "Problems: " + ClubManager.Problems.ToString();
        reputation.text = "Reputation: " + ClubManager.Reputation.ToString();
        notificationText.text = ClubManager.NotificationText;
    }

}

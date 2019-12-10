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

    void Update()
    {
        PrintHUD();
    }

    void PrintHUD()
    {
        thisWeeksAnime.text = ClubManager.ThisWeeksAnime;
        memberCount.text = ClubManager.MemberCount.ToString();
        funds.text = ClubManager.Funds.ToString();
        problems.text = ClubManager.Problems.ToString();
        reputation.text = ClubManager.Reputation.ToString();
    }

}

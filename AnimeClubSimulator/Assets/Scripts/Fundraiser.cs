using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fundraiser : MonoBehaviour
{
    [SerializeField]
    private Text fundraiserNotification = null;

    Dropdown m_Dropdown;

    private static int selectedFundraiserIncome = 0;

    public static int SelectedFundraiserIncome
    {
        get { return selectedFundraiserIncome ; }
        set { selectedFundraiserIncome = value; }
    }

    private static bool fundraiserMaxReached = false;

    public static bool FundraiserMaxReached
    {
        get { return fundraiserMaxReached; }
    }

    private static int currentFundraiser = 0; 

    public static int CurrentFundraiser
    {
        get { return currentFundraiser; }
        set { currentFundraiser = value; }
    }

    private int maxFundraiser = 4;
   

    private int bakeSaleIncome = 100;
    private int carWashIncome = 150;
    private int animeMerchIncome = 200;
    // Start is called before the first frame update
    void Start()
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
        CheckForMaxFundraiser();

        switch (m_Dropdown.value)
        {
            case 0:
                if (!fundraiserMaxReached)
                {
                    selectedFundraiserIncome = bakeSaleIncome;
                }
                break;
            case 1:
                if (!fundraiserMaxReached)
                {
                    selectedFundraiserIncome = carWashIncome;
                }
                break;
            case 2:
                if (!fundraiserMaxReached)
                {
                    selectedFundraiserIncome = animeMerchIncome;
                }
                break;
        }
    }

    void CheckForMaxFundraiser()
    {
        if (currentFundraiser == maxFundraiser)
        {
            fundraiserNotification.text = "You have reached the max fundraiser for this semester.";
            fundraiserMaxReached = true;
        }
    }
}

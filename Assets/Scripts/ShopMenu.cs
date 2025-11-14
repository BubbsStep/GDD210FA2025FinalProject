using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour
{
    [SerializeField] private Image swordFrame;
    [SerializeField] private Image maceFrame;
    [SerializeField] private Image pistolFrame;
    [SerializeField] private Image shotgunFrame;
    [SerializeField] private Image exitFrame;
    //Images to be highlighted when selected

    [SerializeField] private TextMeshProUGUI startDesc;
    [SerializeField] private TextMeshProUGUI shortswordDesc;
    [SerializeField] private TextMeshProUGUI maceDesc;
    [SerializeField] private TextMeshProUGUI pistolDesc;
    [SerializeField] private TextMeshProUGUI shotgunDesc;

    private bool exitSelected = true;
    private bool swordSelected = false;
    private bool maceSelected = false;
    private bool pistolSelected = false;
    private bool shotgunSelected = false;
    //Booleans to track selection states

    private bool swordPath = false;
    private bool macePath = false;
    private bool pistolPath = false;
    private bool shotgunPath = false;
    //Booleans to track selected abilities

    private void Start()
    {
        exitSelected = true;
        swordSelected = false;
        swordFrame.enabled = false;
        shortswordDesc.enabled = false;
        maceSelected = false;
        maceFrame.enabled = false;
        maceDesc.enabled = false;
        pistolSelected = false;
        pistolFrame.enabled = false;
        pistolDesc.enabled = false;
        shotgunSelected = false;
        shotgunFrame.enabled = false;
        shotgunDesc.enabled = false;
    }

    void Update()
    {
        if (swordPath == false || macePath == false || pistolPath == false || shotgunPath == false)
        {
            SelectFirstAbility();
        }

        
    }

    void SelectFirstAbility()
    {
        if (exitSelected)
        {
            exitFrame.enabled = true;
            startDesc.enabled = true;
            if (Input.GetKeyDown(KeyCode.S))
            {
                swordSelected = true;
                exitSelected = !exitSelected;
                exitFrame.enabled = false;
                startDesc.enabled = false;
            }
            //If Enter pressed, exit shop
        }
        else if (swordSelected)
        {
            swordFrame.enabled = true;
            shortswordDesc.enabled = true;
            if (Input.GetKeyDown(KeyCode.W))
            {
                exitSelected = true;
                swordSelected = !swordSelected;
                swordFrame.enabled = false;
                shortswordDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                maceSelected = true;
                swordSelected = !swordSelected;
                swordFrame.enabled = false;
                shortswordDesc.enabled = false;
            }
            //If Enter pressed, swordPath = true;
        }
        else if (maceSelected)
        {
            maceFrame.enabled = true;
            maceDesc.enabled = true;
            if (Input.GetKeyDown(KeyCode.W))
            {
                exitSelected = true;
                maceSelected = !maceSelected;
                maceFrame.enabled = false;
                maceDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                swordSelected = true;
                maceSelected = !maceSelected;
                maceFrame.enabled = false;
                maceDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                pistolSelected = true;
                maceSelected = !maceSelected;
                maceFrame.enabled = false;
                maceDesc.enabled = false;
            }
            //If Enter pressed, macePath = true;
        }
        else if (pistolSelected)
        {
            pistolFrame.enabled = true;
            pistolDesc.enabled = true;
            if (Input.GetKeyDown(KeyCode.W))
            {
                exitSelected = true;
                pistolSelected = !pistolSelected;
                pistolFrame.enabled = false;
                pistolDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                maceSelected = true;
                pistolSelected = !pistolSelected;
                pistolFrame.enabled = false;
                pistolDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                shotgunSelected = true;
                pistolSelected = !pistolSelected;
                pistolFrame.enabled = false;
                pistolDesc.enabled = false;
            }
            //If Enter pressed, pistolPath = true;
        }
        else if (shotgunSelected)
        {
            shotgunFrame.enabled = true;
            shotgunDesc.enabled = true;
            if (Input.GetKeyDown(KeyCode.W))
            {
                exitSelected = true;
                shotgunSelected = !shotgunSelected;
                shotgunFrame.enabled = false;
                shotgunDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                pistolSelected = true;
                shotgunSelected = !shotgunSelected;
                shotgunFrame.enabled = false;
                shotgunDesc.enabled = false;
            }
            //If Enter pressed, macePath = true;
        }
    }

}

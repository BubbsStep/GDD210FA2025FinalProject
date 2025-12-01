using TMPro;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ShopMenu : MonoBehaviour
{
    [SerializeField] private Image swordFrame;
    [SerializeField] private Image shortswordImage;
    [SerializeField] private Image estocImage;
    [SerializeField] private Image muramasaImage;
    [SerializeField] private Image excaliburImage;
    [SerializeField] private Image maceFrame;
    [SerializeField] private Image maceImage;
    [SerializeField] private Image flailImage;
    [SerializeField] private Image morningstarImage;
    [SerializeField] private Image holyWaterSprinklerImage;
    [SerializeField] private Image pistolFrame;
    [SerializeField] private Image pistolImage;
    [SerializeField] private Image silveredBulletsImage;
    [SerializeField] private Image blessedBulletsImage;
    [SerializeField] private Image aurumArgentumImage;
    [SerializeField] private Image shotgunFrame;
    [SerializeField] private Image shotgunImage;
    [SerializeField] private Image blessedShellsImage;
    [SerializeField] private Image demonDoubleBarrelImage;
    [SerializeField] private Image belzebubBreakActionImage;
    [SerializeField] private Image exitFrame;
    [SerializeField] private Image primaryFrame;
    [SerializeField] private Image primaryImage;
    [SerializeField] private Image magicFrame;
    [SerializeField] private Image magicImage;
    [SerializeField] private Image fireboltImage;
    [SerializeField] private Image elvenArrowImage;
    [SerializeField] private Image aresAmmoImage;
    [SerializeField] private Image hearthOfHadesImage;
    [SerializeField] private Image defenseFrame;
    [SerializeField] private Image defenseImage;
    [SerializeField] private Image armorImage;
    [SerializeField] private Image riotShieldImage;
    [SerializeField] private Image svalinShieldImage;
    [SerializeField] private Image aegisImage;
    //Images to be highlighted when selected and for ability icons

    [SerializeField] private TextMeshProUGUI startDesc;
    [SerializeField] private TextMeshProUGUI exitDesc;
    [SerializeField] private TextMeshProUGUI swordDesc;
    [SerializeField] private TextMeshProUGUI estocDesc;
    [SerializeField] private TextMeshProUGUI muramasaDesc;
    [SerializeField] private TextMeshProUGUI excaliburDesc;
    [SerializeField] private TextMeshProUGUI maceDesc;
    [SerializeField] private TextMeshProUGUI flailDesc;
    [SerializeField] private TextMeshProUGUI morningstarDesc;
    [SerializeField] private TextMeshProUGUI holyWaterSprinklerDesc;
    [SerializeField] private TextMeshProUGUI pistolDesc;
    [SerializeField] private TextMeshProUGUI silveredBulletsDesc;
    [SerializeField] private TextMeshProUGUI blessedBulletsDesc;
    [SerializeField] private TextMeshProUGUI aurumArgentumDesc;
    [SerializeField] private TextMeshProUGUI shotgunDesc;
    [SerializeField] private TextMeshProUGUI blessedShellsDesc;
    [SerializeField] private TextMeshProUGUI demonDoubleBarrelDesc;
    [SerializeField] private TextMeshProUGUI belzebubBreakActionDesc;
    [SerializeField] private TextMeshProUGUI primaryDesc;
    [SerializeField] private TextMeshProUGUI magicDesc;
    [SerializeField] private TextMeshProUGUI fireboltDesc;
    [SerializeField] private TextMeshProUGUI elvenArrowDesc;
    [SerializeField] private TextMeshProUGUI aresAmmoDesc;
    [SerializeField] private TextMeshProUGUI hearthOfHadesDesc;
    [SerializeField] private TextMeshProUGUI defenseDesc;
    [SerializeField] private TextMeshProUGUI armorDesc;
    [SerializeField] private TextMeshProUGUI riotShieldDesc;
    [SerializeField] private TextMeshProUGUI svalinShieldDesc;
    [SerializeField] private TextMeshProUGUI aegisDesc;
    //Descriptions

    private bool exitSelected = true;
    private bool swordSelected = false;
    private bool maceSelected = false;
    private bool pistolSelected = false;
    private bool shotgunSelected = false;
    private bool primarySelected = false;
    private bool magicSelected = false;
    private bool defenseSelected = false;
    private bool inStartingSelection = true;
    //Booleans to track selection states

    private bool swordPath = false;
    private bool macePath = false;
    private bool pistolPath = false;
    private bool shotgunPath = false;
    //Booleans to track selected abilities

    [SerializeField] private int primaryPrice = 10;
    [SerializeField] private int magicPrice = 10;
    [SerializeField] private int defensePrice = 10;

    static public List<string> Inventory = new List<string>();
    //Interacts with the Player Inventory across scenes

    static public int playerCurrency;

    private void Start()
    {
        exitSelected = true;
        exitDesc.enabled = false;
        startDesc.enabled = false;
        swordSelected = false;
        swordFrame.enabled = false;
        swordDesc.enabled = false;
        shortswordImage.enabled = false;
        estocDesc.enabled = false;
        estocImage.enabled = false;
        muramasaDesc.enabled = false;
        muramasaImage.enabled = false;
        excaliburDesc.enabled = false;
        excaliburImage.enabled = false;
        maceSelected = false;
        maceFrame.enabled = false;
        maceDesc.enabled = false;
        maceImage.enabled = false;
        flailDesc.enabled = false;
        flailImage.enabled = false;
        morningstarDesc.enabled = false;
        morningstarImage.enabled = false;
        holyWaterSprinklerDesc.enabled = false;
        holyWaterSprinklerImage.enabled = false;
        pistolSelected = false;
        pistolFrame.enabled = false;
        pistolDesc.enabled = false;
        pistolImage.enabled = false;
        silveredBulletsDesc.enabled = false;
        silveredBulletsImage.enabled = false;
        blessedBulletsDesc.enabled = false;
        blessedBulletsImage.enabled = false;
        aurumArgentumDesc.enabled = false;
        aurumArgentumImage.enabled = false;
        shotgunSelected = false;
        shotgunFrame.enabled = false;
        shotgunDesc.enabled = false;
        shotgunImage.enabled = false;
        blessedShellsDesc.enabled = false;
        blessedShellsImage.enabled = false;
        demonDoubleBarrelDesc.enabled = false;
        demonDoubleBarrelImage.enabled = false;
        belzebubBreakActionDesc.enabled = false;
        belzebubBreakActionImage.enabled = false;
        primarySelected = false;
        primaryFrame.enabled = false;
        primaryDesc.enabled = false;
        primaryImage.enabled = false;
        magicSelected = false;
        magicFrame.enabled = false;
        magicImage.enabled = false;
        magicDesc.enabled = false;
        fireboltDesc.enabled = false;
        fireboltImage.enabled = false;
        elvenArrowDesc.enabled = false;
        elvenArrowImage.enabled = false;
        aresAmmoDesc.enabled = false;
        aresAmmoImage.enabled = false;
        hearthOfHadesDesc.enabled = false;
        hearthOfHadesImage.enabled = false;
        defenseSelected = false;
        defenseFrame.enabled = false;
        defenseImage.enabled = false;
        defenseDesc.enabled = false;
        armorDesc.enabled = false;
        armorImage.enabled = false;
        riotShieldDesc.enabled = false;
        riotShieldImage.enabled = false;
        svalinShieldDesc.enabled = false;
        svalinShieldImage.enabled = false;
        aegisDesc.enabled = false;
        aegisImage.enabled = false;

        // Detect if player already chose a starting ability
        swordPath = PlayerInv.Inventory.Contains("Shortsword");
        macePath = PlayerInv.Inventory.Contains("Mace");
        pistolPath = PlayerInv.Inventory.Contains("Pistol");
        shotgunPath = PlayerInv.Inventory.Contains("Shotgun");

        // If starting weapon already chosen
        if (swordPath || macePath || pistolPath || shotgunPath)
        {
            inStartingSelection = false;
            InventoryCheck();
        }
    }

    void Update()
    {
        if (inStartingSelection)
        {
            shortswordImage.enabled = true;
            maceImage.enabled = true;
            pistolImage.enabled = true;
            shotgunImage.enabled = true;
            SelectFirstAbility();
        }
        else
        {
            shortswordImage.enabled = false;
            maceImage.enabled = false;
            pistolImage.enabled = false;
            shotgunImage.enabled = false;
            NormalShop();
        }
    }

    void InventoryCheck()
    {
        //Below is a series of checks to see what swords the player has already purchased
        if (PlayerInv.Inventory.Contains("Excalibur"))
        {
            primaryImage.sprite = excaliburImage.sprite;
            primaryDesc.text = excaliburDesc.text;
            primaryPrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("Muramasa"))
        {
            primaryImage.sprite = excaliburImage.sprite;
            primaryDesc.text = excaliburDesc.text;
            primaryPrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("Estoc"))
        {
            primaryImage.sprite = muramasaImage.sprite;
            primaryDesc.text = muramasaDesc.text;
            primaryPrice = 150;
        }
        else if (PlayerInv.Inventory.Contains("Shortsword"))
        {
            primaryImage.sprite = estocImage.sprite;
            primaryDesc.text = estocDesc.text;
            primaryPrice = 50;
        }

        //Below is a series of checks to see what maces the player has already purchased
        if (PlayerInv.Inventory.Contains("HolyWaterSprinkler"))
        {
            primaryImage.sprite = holyWaterSprinklerImage.sprite;
            primaryDesc.text = holyWaterSprinklerDesc.text;
            primaryPrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("Morningstar"))
        {
            primaryImage.sprite = holyWaterSprinklerImage.sprite;
            primaryDesc.text = holyWaterSprinklerDesc.text;
            primaryPrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("Flail"))
        {
            primaryImage.sprite = morningstarImage.sprite;
            primaryDesc.text = morningstarDesc.text;
            primaryPrice = 150;
        }
        else if (PlayerInv.Inventory.Contains("Mace"))
        {
            primaryImage.sprite = flailImage.sprite;
            primaryDesc.text = flailDesc.text;
            primaryPrice = 50;
        }

        //Below is a series of checks to see what pistols the player has already purchased
        if (PlayerInv.Inventory.Contains("AurumArgentum"))
        {
            primaryImage.sprite = aurumArgentumImage.sprite;
            primaryDesc.text = aurumArgentumDesc.text;
            primaryPrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("BlessedBullets"))
        {
            primaryImage.sprite = aurumArgentumImage.sprite;
            primaryDesc.text = aurumArgentumDesc.text;
            primaryPrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("SilveredBullets"))
        {
            primaryImage.sprite = blessedBulletsImage.sprite;
            primaryDesc.text = blessedBulletsDesc.text;
            primaryPrice = 150;
        }
        else if (PlayerInv.Inventory.Contains("Pistol"))
        {
            primaryImage.sprite = silveredBulletsImage.sprite;
            primaryDesc.text = silveredBulletsDesc.text;
            primaryPrice = 50;
        }

        //Below is a series of checks to see what shotguns the player has already purchased
        if (PlayerInv.Inventory.Contains("BelzebubBreakAction"))
        {
            primaryImage.sprite = belzebubBreakActionImage.sprite;
            primaryDesc.text = belzebubBreakActionDesc.text;
            primaryPrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("DemonDoubleBarrel"))
        {
            primaryImage.sprite = belzebubBreakActionImage.sprite;
            primaryDesc.text = belzebubBreakActionDesc.text;
            primaryPrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("BlessedShells"))
        {
            primaryImage.sprite = demonDoubleBarrelImage.sprite;
            primaryDesc.text = demonDoubleBarrelDesc.text;
            primaryPrice = 150;
        }
        else if (PlayerInv.Inventory.Contains("Shotgun"))
        {
            primaryImage.sprite = blessedShellsImage.sprite;
            primaryDesc.text = blessedShellsDesc.text;
            primaryPrice = 50;
        }

        //Below is a series of checks to see what magic the player has already purchased
        if (PlayerInv.Inventory.Contains("HearthOfHades"))
        {
            magicImage.sprite = hearthOfHadesImage.sprite;
            magicDesc.text = hearthOfHadesDesc.text;
            magicPrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("AresAmmoFrenzy"))
        {
            magicImage.sprite = hearthOfHadesImage.sprite;
            magicDesc.text = hearthOfHadesDesc.text;
            magicPrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("ElvenArrowEdge"))
        {
            magicImage.sprite = aresAmmoImage.sprite;
            magicDesc.text = aresAmmoDesc.text;
            magicPrice = 150;
        }
        else if (PlayerInv.Inventory.Contains("FaeFirebolt"))
        {
            magicImage.sprite = elvenArrowImage.sprite;
            magicDesc.text = elvenArrowDesc.text;
            magicPrice = 50;
        }
        else
        {
            magicImage.sprite = fireboltImage.sprite;
            magicDesc.text = fireboltDesc.text;
            magicPrice = 10;
        }

        //Below is a series of checks to see what defense the player has already purchased
        if (PlayerInv.Inventory.Contains("Aegis"))
        {
            defenseImage.sprite = aegisImage.sprite;
            defenseDesc.text = aegisDesc.text;
            defensePrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("SvalinShield"))
        {
            defenseImage.sprite = aegisImage.sprite;
            defenseDesc.text = aegisDesc.text;
            defensePrice = 300;
        }
        else if (PlayerInv.Inventory.Contains("RiotShield"))
        {
            defenseImage.sprite = svalinShieldImage.sprite;
            defenseDesc.text = svalinShieldDesc.text;
            defensePrice = 150;
        }
        else if (PlayerInv.Inventory.Contains("Armor"))
        {
            defenseImage.sprite = riotShieldImage.sprite;
            defenseDesc.text = riotShieldDesc.text;
            defensePrice = 50;
        }
        else
        {
            defenseImage.sprite = armorImage.sprite;
            defenseDesc.text = armorDesc.text;
            defensePrice = 10;
        }
    }

    void NormalShop()
    {

        primaryImage.enabled = true;
        magicImage.enabled = true;
        defenseImage.enabled = true;
        //Makes sure each image is displayed

        if (exitSelected)
        {
            exitFrame.enabled = true;
            exitDesc.enabled = true;
            if (Input.GetKeyDown(KeyCode.S))
            {
                primarySelected = true;
                exitSelected = !exitSelected;
                exitFrame.enabled = false;
                exitDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(0);
            }
            //If Enter pressed, exits shop
        }
        else if (primarySelected)
        {
            primaryFrame.enabled = true;
            primaryDesc.enabled = true;

            if (Input.GetKeyDown(KeyCode.W))
            {
                exitSelected = true;
                swordSelected = !swordSelected;
                primaryFrame.enabled = false;
                primaryDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                magicSelected = true;
                primarySelected = !primarySelected;
                primaryFrame.enabled = false;
                primaryDesc.enabled = false;
            }
            if (PlayerInv.playerCurrency >= primaryPrice && Input.GetKeyDown(KeyCode.E))
            {
                if (primaryImage.sprite == excaliburImage.sprite)
                {
                    PlayerInv.Inventory.Add("Excalibur");
                    //Adds excalibur to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (primaryImage.sprite == muramasaImage.sprite)
                {
                    PlayerInv.Inventory.Add("Muramasa");
                    //Adds muramasa to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (primaryImage.sprite == estocImage.sprite)
                {
                    PlayerInv.Inventory.Add("Estoc");
                    //Adds estoc to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }

                if (primaryImage.sprite == holyWaterSprinklerImage.sprite)
                {
                    PlayerInv.Inventory.Add("HolyWaterSprinkler");
                    //Adds holy water sprinkler to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (primaryImage.sprite == morningstarImage.sprite)
                {
                    PlayerInv.Inventory.Add("Morningstar");
                    //Adds morningstar to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (primaryImage.sprite == flailImage.sprite)
                {
                    PlayerInv.Inventory.Add("Flail");
                    //Adds flail to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }

                if (primaryImage.sprite == aurumArgentumImage.sprite)
                {
                    PlayerInv.Inventory.Add("AurumArgentum");
                    //Adds aurum and argentum to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (primaryImage.sprite == blessedBulletsImage.sprite)
                {
                    PlayerInv.Inventory.Add("BlessedBullets");
                    //Adds blessed bullets to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (primaryImage.sprite == silveredBulletsImage.sprite)
                {
                    PlayerInv.Inventory.Add("SilveredBullets");
                    //Adds silver bullets to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }

                if (primaryImage.sprite == belzebubBreakActionImage.sprite)
                {
                    PlayerInv.Inventory.Add("BelzebubBreakAction");
                    //Adds belzebub break action to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (primaryImage.sprite == demonDoubleBarrelImage.sprite)
                {
                    PlayerInv.Inventory.Add("DemonDoubleBarrel");
                    //Adds demon double barrel to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (primaryImage.sprite == blessedShellsImage.sprite)
                {
                    PlayerInv.Inventory.Add("BlessedShells");
                    //Adds blessed shells to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= primaryPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
            }
        }

        else if (magicSelected)
        {
            magicFrame.enabled = true;
            magicDesc.enabled = true;

            if (Input.GetKeyDown(KeyCode.W))
            {
                exitSelected = true;
                magicSelected = !magicSelected;
                magicFrame.enabled = false;
                magicDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                primarySelected = true;
                magicSelected = !magicSelected;
                magicFrame.enabled = false;
                magicDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                defenseSelected = true;
                magicSelected = !magicSelected;
                magicFrame.enabled = false;
                magicDesc.enabled = false;
            }
            if (PlayerInv.playerCurrency >= magicPrice && Input.GetKeyDown(KeyCode.E))
            {
                if (magicImage.sprite == hearthOfHadesImage.sprite)
                {
                    PlayerInv.Inventory.Add("HearthOfHades");
                    //Adds hearth of hades to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= magicPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (magicImage.sprite == aresAmmoImage.sprite)
                {
                    PlayerInv.Inventory.Add("AresAmmoFrenzy");
                    //Adds ares ammo frenzy to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= magicPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (magicImage.sprite == elvenArrowImage.sprite)
                {
                    PlayerInv.Inventory.Add("ElvenArrowEdge");
                    //Adds elven arrow edge to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= magicPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (magicImage.sprite == fireboltImage.sprite)
                {
                    PlayerInv.Inventory.Add("FaeFirebolt");
                    //Adds fae firebolt to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= magicPrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
            }
        }

        else if (defenseSelected)
        {
            defenseFrame.enabled = true;
            defenseDesc.enabled = true;

            if (Input.GetKeyDown(KeyCode.W))
            {
                exitSelected = true;
                defenseSelected = !defenseSelected;
                defenseFrame.enabled = false;
                defenseDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                magicSelected = true;
                defenseSelected = !defenseSelected;
                defenseFrame.enabled = false;
                defenseDesc.enabled = false;
            }
            if (PlayerInv.playerCurrency >= defensePrice && Input.GetKeyDown(KeyCode.E))
            {
                if (defenseImage.sprite == aegisImage.sprite)
                {
                    PlayerInv.Inventory.Add("Aegis");
                    //Adds aegis to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= defensePrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (defenseImage.sprite == svalinShieldImage.sprite)
                {
                    PlayerInv.Inventory.Add("SvalinShield");
                    //Adds svalin shield to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= defensePrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (defenseImage.sprite == riotShieldImage.sprite)
                {
                    PlayerInv.Inventory.Add("RiotShield");
                    //Adds riot shield to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= defensePrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
                else if (defenseImage.sprite == armorImage.sprite)
                {
                    PlayerInv.Inventory.Add("Armor");
                    //Adds armor to inventory if the player has enough currency and presses E
                    PlayerInv.playerCurrency -= defensePrice;
                    //Removes currency from player
                    ResetNormalShopState();
                    //Refreshes the shop to show the next available item
                }
            }
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(0);
            }
            //If Enter pressed, exits shop
        }
        else if (swordSelected)
        {
            swordFrame.enabled = true;
            swordDesc.enabled = true;
            if (Input.GetKeyDown(KeyCode.W))
            {
                exitSelected = true;
                swordSelected = !swordSelected;
                swordFrame.enabled = false;
                swordDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                maceSelected = true;
                swordSelected = !swordSelected;
                swordFrame.enabled = false;
                swordDesc.enabled = false;
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                swordDesc.enabled = false;
                swordFrame.enabled = false;
                PlayerInv.Inventory.Add("Shortsword");
                swordPath = true;
                inStartingSelection = false;
                ResetNormalShopState();
            }
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                maceDesc.enabled = false;
                maceFrame.enabled = false;
                PlayerInv.Inventory.Add("Mace");
                macePath = true;
                inStartingSelection = false;
                ResetNormalShopState();
            }
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                pistolDesc.enabled = false;
                pistolFrame.enabled = false;
                PlayerInv.Inventory.Add("Pistol");
                pistolPath = true;
                inStartingSelection = false;
                ResetNormalShopState();
            }
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                shotgunDesc.enabled = false;
                shotgunFrame.enabled = false;
                PlayerInv.Inventory.Add("Shotgun");
                shotgunPath = true;
                inStartingSelection = false;
                ResetNormalShopState();
            }
        }
    }

    void ResetNormalShopState()
    {
        exitSelected = true;
        primarySelected = false;
        magicSelected = false;
        defenseSelected = false;

        // Also reset UI:
        exitFrame.enabled = false;
        primaryFrame.enabled = false;
        magicFrame.enabled = false;
        defenseFrame.enabled = false;
        exitDesc.enabled = false;
        primaryDesc.enabled = false;
        magicDesc.enabled = false;
        defenseDesc.enabled = false;

        InventoryCheck();
    }

}

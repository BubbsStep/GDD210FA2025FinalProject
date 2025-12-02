using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Blake
{
    public class Shop : MonoBehaviour
    {
		[Header("UI")]
        [SerializeField] private TMP_Text primaryMoneyText;
		[SerializeField] private Image primaryImage;
		[SerializeField] private TMP_Text primaryCost;

		[Header("Items")]
		[SerializeField] static public List<Item> swords = new List<Item>();
        [SerializeField] static public List<Item> maces = new List<Item>();
        [SerializeField] static public List<Item> pistols = new List<Item>();
        [SerializeField] static public List<Item> shotguns = new List<Item>();
        [SerializeField] static public List<Item> magics = new List<Item>();
        [SerializeField] static public List<Item> defenses = new List<Item>();

		[Header("Player")]
		[SerializeField] private PlayerInv playerInventory;

		private void Start()
		{
			UpdateUI();
		}

		private void UpdateUI()
		{
			primaryMoneyText.text = $"Money: {PlayerInv.playerCurrency.ToString()}";

			//Differentiating between primaries
			if (PlayerInv.Inventory.Contains("Shortsword"))
			{
                primaryImage.sprite = swords[0].ItemSprite;
                primaryCost.text = "$" + swords[0].Cost.ToString();
            }
			else if (PlayerInv.Inventory.Contains("Mace"))
			{
				primaryImage.sprite = maces[0].ItemSprite;
				primaryCost.text = "$" + maces[0].Cost.ToString();
            }
            else if (PlayerInv.Inventory.Contains("Pistol"))
            {
                primaryImage.sprite = pistols[0].ItemSprite;
                primaryCost.text = "$" + pistols[0].Cost.ToString();
            }
            else if (PlayerInv.Inventory.Contains("Shotguns"))
            {
                primaryImage.sprite = shotguns[0].ItemSprite;
                primaryCost.text = "$" + shotguns[0].Cost.ToString();
            }

        }

		private void Update()
		{
			// Buy next sword
			if (Input.GetKeyDown(KeyCode.E))
			{
				BuySword();
			}
		}

		private void BuySword()
		{
			// If player buys sword, remove it from list. Next sword will always be at index 0
			if(PlayerInv.playerCurrency >= swords[0].Cost)
			{
				PlayerInv.Swords.Add(swords[0]);
				PlayerInv.playerCurrency -= swords[0].Cost;
				Debug.Log("Purchased " + swords[0].ItemName);
				swords.RemoveAt(0);
				UpdateUI();
			}
		}
	}
}
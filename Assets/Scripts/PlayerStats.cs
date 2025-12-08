using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private TMP_Text currencyText;
    [SerializeField] private TMP_Text cooldownText;

    void Update()
    {
        healthText.text = "Health: " + PlayerInv.playerHealth;
        currencyText.text = "Currency: $" + PlayerInv.playerCurrency;
        cooldownText.text = "Magic Cooldown: " + Mathf.Ceil(PlayerAttack.magicCooldown);
    }
}

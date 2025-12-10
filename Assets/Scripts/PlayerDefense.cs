using UnityEngine;

public class PlayerDefense : MonoBehaviour
{
    [SerializeField] private Collider svalinCollider;
    [SerializeField] private SpriteRenderer svalinSprite;

    private void Start()
    {
        svalinCollider.enabled = false;
        svalinSprite.enabled = false;
    }

    void Update()
    {
        if (PlayerInv.Inventory.Contains("Armor"))
        {
            PlayerInv.playerDefense = 1;
        }
        if (PlayerInv.Inventory.Contains("RiotShield"))
        {
            PlayerInv.playerDefense = 2;
        }
        if (PlayerInv.Inventory.Contains("SvalinShield"))
        {
            PlayerInv.playerDefense = 3;
            svalinCollider.enabled = true;
            svalinSprite.enabled = true;
        }
        if (PlayerInv.Inventory.Contains("Aegis"))
        {
            PlayerInv.playerDefense = 4;
        }
    }
}

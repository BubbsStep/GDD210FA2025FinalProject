using System.Collections.Generic;
using UnityEngine;

public class PlayerInv : MonoBehaviour
{
    static public List<string> Inventory = new List<string>();
    [SerializeField] private List<string> inventory = new List<string>();

    [SerializeField] static public int playerCurrency = 10000;
    //Change after making a drop that's possible to pick up

    static public int playerHealth = 50;

    static public List<Blake.Item> Swords => Blake.Shop.swords;
    [SerializeField] private List<Blake.Item> swords = new List<Blake.Item>();


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
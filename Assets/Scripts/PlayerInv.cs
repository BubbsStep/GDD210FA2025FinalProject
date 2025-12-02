using System.Collections.Generic;
using UnityEngine;

public class PlayerInv : MonoBehaviour
{
    static public List<string> Inventory = new List<string>();

    static public int playerCurrency;
    //Change after making a drop that's possible to pick up

    
    static public List<Blake.Item> Swords => Blake.Shop.swords;
    [SerializeField] private List<Blake.Item> swords = new List<Blake.Item>();


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
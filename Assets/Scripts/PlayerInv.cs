using System.Collections.Generic;
using UnityEngine;

public class PlayerInv : MonoBehaviour
{
    static public List<string> Inventory = new List<string>();

    static public int playerCurrency = 100000;
    //Change after making a drop that's possible to pick up

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
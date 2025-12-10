using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerInv.playerHealth = 50;
            PlayerInv.playerCurrency = 100;
            PlayerInv.Inventory.Add("Level1");
            SceneManager.LoadScene("Level1");
        }
    }
}

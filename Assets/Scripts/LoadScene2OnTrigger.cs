using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene2OnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInv.playerHealth = 50;
            //Maxes out health for new level
            PlayerInv.Inventory.Add("Level2");
            SceneManager.LoadScene("Level2");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelBossOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInv.playerHealth = 50;
            //Maxes out health for new level
            PlayerInv.Inventory.Add("LevelBoss");
            SceneManager.LoadScene("LevelBoss");
        }
    }
}

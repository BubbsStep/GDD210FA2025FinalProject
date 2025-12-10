using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInv.Inventory.Clear();
            SceneManager.LoadScene("End");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LoadShopOnTrigger : MonoBehaviour
{
    private bool playerInside = false;

    [SerializeField] private Image promptImage;
    [SerializeField] private TextMeshProUGUI promptText;
    //UI to appear when player is in trigger zone

    void Update()
    {
        if (playerInside)
        {
            promptImage.enabled = true;
            promptText.enabled = true;
        }
        else
        {
            promptImage.enabled = false;
            promptText.enabled = false;
        }
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(1);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }
}

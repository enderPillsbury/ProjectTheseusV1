using UnityEngine;
using UnityEngine.InputSystem;

public class ItemPickup : MonoBehaviour
{
    public GameObject Item, levelSwap, levelReplacement, interactUI;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            interactUI.SetActive(true);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {

                levelSwap.SetActive(false);
                Item.SetActive(false);
                levelReplacement.SetActive(true);
                interactUI.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        interactUI.SetActive(false);
    }
}

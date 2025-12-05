using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ButtonScripting : MonoBehaviour
{
    public GameObject interactUI, puzzleInteractible;
    private bool buttonActive = true;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
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
                if (buttonActive == true)
                {
                    buttonActive = false;
                    puzzleInteractible.SetActive(false);
                }
                else
                {
                    buttonActive = true;
                    puzzleInteractible.SetActive(true);
                }
            }
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        interactUI.SetActive(false);
    }
}

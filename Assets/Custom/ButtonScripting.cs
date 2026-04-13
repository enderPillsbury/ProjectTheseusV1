using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ButtonScripting : MonoBehaviour
{
    public GameObject interactUI, puzzleInteractible, puzzleInteractible2, temporaryInteractible, mouseOver;
    public int TimerAmount;
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
                if(temporaryInteractible!= null)
                {
                    StartCoroutine("TimedButton");
                }

                if (buttonActive == true)
                {
                    buttonActive = false;
                    if(puzzleInteractible!= null)
                    {
                        puzzleInteractible.SetActive(false);
                        if(mouseOver!= null)
                        {
                            mouseOver.SetActive(false);
                        }
                    }
                    if(puzzleInteractible2 != null)
                    {
                        puzzleInteractible2.SetActive(true);
                    }
                }
                else
                {
                    buttonActive = true;
                    if (puzzleInteractible != null)
                    {
                        puzzleInteractible.SetActive(true);
                    }
                    if(puzzleInteractible2 != null)
                    {
                        puzzleInteractible2.SetActive(false);
                    }
                }
            }
        }
        
    }
    private IEnumerator TimedButton()
    {
        Debug.LogError("StartingTimer");
        temporaryInteractible.SetActive(false);
        yield return new WaitForSeconds(TimerAmount);
        temporaryInteractible.SetActive(true);
        Debug.LogError("TimerOver");
    }
    void OnTriggerExit(Collider other)
    {
        interactUI.SetActive(false);
    }
}

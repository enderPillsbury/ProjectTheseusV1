using UnityEditor.UI;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwapping : MonoBehaviour
{
    public GameObject northCamera, westCamera, southCamera, eastCamera; //Create gameobject slots for all possible neighboring cameras
    public void Update()
    {
        triggerSwap();
    }
    public void triggerSwap()   //Check for inputs
    {
        if (Keyboard.current.upArrowKey.wasPressedThisFrame) 
        {
            if (northCamera != null)    //Make sure the direction has a possible camera to reach before activating
            {
                this.gameObject.SetActive(false);
                northCamera.SetActive(true);
            }
        }
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            if (eastCamera != null)
            {
                this.gameObject.SetActive(false);
                eastCamera.SetActive(true);
            }
        }
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            if (southCamera != null)
            {
                southCamera.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            if (westCamera != null)
            {
                this.gameObject.SetActive(false);
                westCamera.SetActive(true);

            }
        }
    }
}

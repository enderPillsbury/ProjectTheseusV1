using UnityEditor.UI;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwapping : MonoBehaviour
{
    public GameObject northCamera, westCamera, southCamera, eastCamera;
    public void Update()
    {
        triggerSwap();
    }
    public void triggerSwap()
    {
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            if (northCamera != null)
            {
                northCamera.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            if (eastCamera != null)
            {
                eastCamera.SetActive(true);
                this.gameObject.SetActive(false);
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
                westCamera.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool paused = false;

    void Start()
    {
        Continue();
        
    }
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Debug.Log("Paused");
            if(paused == false)
            {
                Pause();
            }
            else{if (paused == true)
            {
                Continue();
            }}
        }
        
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        paused = true;
    }

    public void Continue()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        paused = false;
    }
}

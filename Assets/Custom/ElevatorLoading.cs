using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ElevatorLoading : MonoBehaviour
{
    public GameObject menuUI;
    public bool level1, level2, level3, level4, level3b = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            menuUI.SetActive(true);   
        }
    }
    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                Debug.LogError("Finding Next Level");
                LoadNextLevel();
                
            }
        }
    }
    
    void LoadNextLevel()
    {
        if (level1== true)
        {
            Debug.LogError("LoadingLevel2");
            SceneManager.LoadScene("BasicLevel2");
        }
        if (level2==true)
        {
            Debug.LogError("LoadingLevel3");
            SceneManager.LoadScene("BasicLevel3");
        }
        if (level3==true)
        {
            Debug.LogError("LoadingLevel4");
            SceneManager.LoadScene("BasicLevel4");
        }
        if (level3b == true)
        {
            Debug.LogError("LoadingLevel4Fixed");
            SceneManager.LoadScene("BasicLevel4Fixed");
        }
        if (level4 == true)
        {
            Debug.LogError("Returning to level3");
            SceneManager.LoadScene("BasicLevel3Alt");
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        menuUI.SetActive(false);
    }
}

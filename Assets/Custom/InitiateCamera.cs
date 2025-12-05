using UnityEngine;

public class InitiateCamera : MonoBehaviour
{
    public GameObject firstCamera, currentCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        firstCamera.SetActive(true);
        currentCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

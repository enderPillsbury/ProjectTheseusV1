using Unity.VisualScripting;
using UnityEngine;


public class CameraRotation : MonoBehaviour
{
    public int farLeft, farRight, midPoint;
    private bool turningLeft, turningRight = false;
    public int rotationDuration;
    public int rotationPause;
    public GameObject thisCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Start()
    {
        turningLeft = true;
        rotateLeft();
    }
    void Update()
    {
        if(turningLeft == true)
        {
            rotateLeft();
        }
        if(turningRight == true)
        {
            rotateRight();
        }
    }
    void rotateLeft()
    {
        thisCamera.transform.Rotate(Vector3.up * Time.deltaTime *2);
        if(thisCamera.transform.rotation.eulerAngles.y >= farLeft)
        {
            Debug.LogError("Swapping direction");
            turningLeft = false;
            turningRight = true;
            
            return;
        }
        
    }
    void rotateRight()
    {
        thisCamera.transform.Rotate(-Vector3.up * Time.deltaTime * 5);
        if(thisCamera.transform.rotation.eulerAngles.y <= farRight)
        {
            Debug.LogError("Swapping Direction again");
            turningRight = false;
            turningLeft = true;
            return;
        }
        
    }
}

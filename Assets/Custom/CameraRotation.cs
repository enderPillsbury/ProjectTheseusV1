using Unity.VisualScripting;
using UnityEngine;


public class CameraRotation : MonoBehaviour
{
    public int farLeft, farRight, rotationSpeed;
    public bool turningLeft, turningRight = false;
    public int timer;

    public GameObject thisCamera;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Start()
    {
        

    }
    void Update()
    {
        if(turningLeft == true)
        {
            if(timer < farLeft)
            {
                InvokeRepeating(nameof(rotateLeft), 0, 0);
            }
            else
            {
                timer =0;
                turningRight = true;
                turningLeft = false;
                CancelInvoke();
            }
            
        }
        if(turningRight == true)
        {
            if(timer < farRight)
            {
                InvokeRepeating(nameof(rotateRight), 0, 0);                 
            }
            else
            {
                timer=0;
                turningLeft = true;
                turningRight = false;
                CancelInvoke();
            }

        }
    }
    void rotateLeft()
    {
        thisCamera.transform.Rotate(Vector3.up * Time.deltaTime *rotationSpeed);
        timer+=1;

        
    }
    void rotateRight()
    {
        thisCamera.transform.Rotate(-Vector3.up * Time.deltaTime * rotationSpeed);
        timer+=1;
        
    }
}

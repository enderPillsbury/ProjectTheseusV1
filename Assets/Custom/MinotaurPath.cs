using System.Xml.Serialization;
using UnityEngine;

public class MinotaurPath : MonoBehaviour
{
    public GameObject minotaur;
    public GameObject doorway;
    public bool movingEast1, movingSouth, movingEast2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (movingEast1)
        {
            walkingEast();
        }
        if (movingSouth)
        {
            walkingSouth();
        }
        if (movingEast2)
        {
            walkingEast();
        }
        
    }
    
    public void enterRoom1()
    {
        doorway.SetActive(false);
        minotaur.transform.position.Set(-53, 4, 25);
        new WaitForSeconds(5);
    
    }
    void walkingEast()
    {
        minotaur.transform.Translate(Vector3.forward * Time.deltaTime*4);
        if(minotaur.transform.position.x > -20 && movingEast1== true)
        {
            movingSouth = true;
            movingEast1 = false;
            minotaur.transform.Rotate(0, 90, 0);
        }
    }
    void walkingSouth()
    {
        minotaur.transform.Translate(Vector3.forward * Time.deltaTime*3);
        if(minotaur.transform.position.z < 14)
        {
            movingSouth = false;
            movingEast2 = true;
            minotaur.transform.Rotate(0, -90, 0);
        }
    }
}

using UnityEditor;
using UnityEngine;

public class EventStarting : MonoBehaviour
{
    public GameObject minotaur;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            minotaur.GetComponent<MinotaurPath>().enterRoom1();
            Debug.LogError("Player Entered");
            new WaitForSeconds(5);
            minotaur.GetComponent<MinotaurPath>().movingEast1= true;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

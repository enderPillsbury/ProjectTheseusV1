using UnityEngine;

public class LoseEffect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject deathScreen;

    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            deathScreen.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
        }
    }
}

using UnityEngine;

public class TimedEvent : MonoBehaviour
{
    public GameObject myself;
    public int timeAmount;
    // Update is called once per frame
    void Update()
    {
        if(myself.activeSelf == false)
        {
            deactivationTimer();
        }
    }
    void deactivationTimer()
    {
        Debug.LogError("StartingTimer");
        new WaitForSeconds(timeAmount);
        myself.SetActive(true);
    }
}

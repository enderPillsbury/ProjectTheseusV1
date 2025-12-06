using UnityEngine;

public class AreaChange : MonoBehaviour
{
    public GameObject fixedStage, ruinedStage;
    void OnTriggerEnter(Collider other)
    {
        fixedStage.SetActive(false);
        ruinedStage.SetActive(true);
    }
}

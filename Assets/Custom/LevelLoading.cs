using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    public void LoadPuzzleLevel(){
        SceneManager.LoadScene("puzzleLevel");
    }

    public void LoadTimedLevel(){
        SceneManager.LoadScene("timedLevel");
    }
}

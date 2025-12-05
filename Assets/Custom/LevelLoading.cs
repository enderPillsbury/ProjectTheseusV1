using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{
    public void LoadPuzzleLevel(){
        SceneManager.LoadScene("PuzzleLevel");
    }

    public void LoadTimedLevel(){
        SceneManager.LoadScene("TimedLevel");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
}

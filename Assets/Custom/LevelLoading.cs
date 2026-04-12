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
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1Basic");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("BasicLevel2");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("BasicLevel3");
    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene("BasicLevel4Fixed");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}

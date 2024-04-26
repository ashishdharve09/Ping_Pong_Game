using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject winningScene;
    public GameObject player;
    public GameObject pauseScene;


    public void gameOver() 
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void winScene()
    {
        winningScene.SetActive(true);
        Time.timeScale = 0;

    }
    public void pause()
    {
        pauseScene.SetActive(true);
        Time.timeScale = 0;
    }
    public void unpause()
    {
        pauseScene.SetActive(false);
        Time.timeScale = 1;
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void quit()
    {
        Application.Quit();
    }
    
}

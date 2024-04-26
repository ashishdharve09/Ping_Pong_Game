using UnityEngine;
using UnityEngine.UI;

public class ScoreManagement : MonoBehaviour
{
    public Text playerScore;
    public Text enemyScore;

    public GameManager gameManager;
    void Update()
    {
        if (playerScore.text == "10")
        {
            gameManager.gameOver();
        }
        if (enemyScore.text == "10")
        {
            gameManager.winScene();
        }
    }
}

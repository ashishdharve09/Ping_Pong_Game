using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreDisplay(); // Initialize display
    }

    public void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        if (scoreText != null) 
        {
            scoreText.text = "" + score;
        }
    }
}

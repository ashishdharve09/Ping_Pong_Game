using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public Score scoreManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            scoreManager.AddPoints(1);
        }
    }
}

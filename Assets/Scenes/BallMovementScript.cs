using UnityEngine;

public class BallMovementScript : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    public AudioSource audioSource1;
    void Start()
    {
        rb.velocity = new Vector2(1, 1) * moveSpeed;
    }
        void OnCollisionEnter2D(Collision2D collision)
    {
        if (audioSource1 != null)
        {
            audioSource1.Play();
        }
    }
}

using UnityEngine;
public class EnemyMovement : MonoBehaviour
{
    public float speed; 

    private Rigidbody2D rb;
    public GameObject ball;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() // FixedUpdate is generally better for physics 
    {
        Vector2 direction = (ball.transform.position - transform.position).normalized;
        Vector2 force = direction * speed;

        rb.AddForce(force);
    }
}
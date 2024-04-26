using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // controller only in vertical 
    private Rigidbody2D rb;
    public float Speed;

    public GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }
    void Update()
    {
        float Vertical = Input.GetAxis ("Vertical");

        Vector2 movement = new Vector2 (rb.velocity.x, Vertical * Speed);
        rb.velocity = movement;

        if (Input.GetKeyDown(KeyCode.Escape) && gameManager.pauseScene.activeSelf)
        {
            gameManager.unpause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !gameManager.pauseScene.activeSelf)
        {
            gameManager.pause();
        }
    }
   
}

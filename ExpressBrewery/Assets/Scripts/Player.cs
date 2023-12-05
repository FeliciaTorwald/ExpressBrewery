using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f; // Adjust this to control movement speed
    private Rigidbody2D rb;
    Vector2 movement;
    public HerbTypes heldHerb;
    public Transform hand;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
    private void Update()
    {
        heldHerb = hand.GetComponentInChildren<HerbTypes>();
    }
}

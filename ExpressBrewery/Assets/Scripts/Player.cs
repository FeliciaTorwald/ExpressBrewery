using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f; // Adjust this to control movement speed
    private Rigidbody2D rb;
    Vector2 movement;
    public HerbTypes heldHerb = HerbTypes.None;

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
    }
        //private HerbTypes GetHerbTypeByName(string herbName)
        //{
        //    foreach (Transform child in transform)
        //    {
        //        if (child.gameObject.name == herbName)
        //        {
        //            // Assuming the herb type is stored in the Herb component (replace Herb with your actual component type)
        //            //Herb herbComponent = child.GetComponent<Herb>();
        //        //    if (herbComponent != null)
        //        //    {
        //        //        return herbComponent.herbType;
        //        //    }
        //        //}
        //    }

        //    return HerbTypes.None; // Return None if the herb is not found
        //}
}

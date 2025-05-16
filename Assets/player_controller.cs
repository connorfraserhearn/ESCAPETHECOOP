using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public float move_speed = 5f;

    private Rigidbody2D rb;
    private Vector2 move_input;

    public Transform fire_point;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from keyboard
        float move_x = Input.GetAxisRaw("Horizontal");
        float move_y = Input.GetAxisRaw("Vertical");

        move_input = new Vector2(move_x, move_y).normalized;

        if (move_input != Vector2.zero)
        {
            fire_point.right = move_input;
        }
    }

    void FixedUpdate()
    {
        // Apply movement to Rigidbody
        rb.velocity = move_input * move_speed;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg_projectile : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 5f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ENEMY"))
        {
            Destroy(other.gameObject);   // Kill enemy
            Destroy(gameObject);         // Destroy egg

            enemy_spawner enemy_spawner = FindObjectOfType<enemy_spawner>();
            if (enemy_spawner != null)
            {
                enemy_spawner.current_enemies--; // Let more spawn
            }
        }
    }
}

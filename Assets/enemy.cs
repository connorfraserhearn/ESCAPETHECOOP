using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void move_towards_target()
    {
        if (target == null) return;

        Vector2 direction = (target.position - transform.position).normalized;
        transform.position += (Vector3)(direction * speed * Time.deltaTime);
    }

    public Transform target;
    public float speed = 2f;
}

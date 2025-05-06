using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harmer_patrol : MonoBehaviour
{

    public Transform point_one;
    public Transform point_two;
    public float speed = 2f;

    private Transform target_point;

    // Start is called before the first frame update
    void Start()
    {
        target_point = point_two;
    }

    // Update is called once per frame
    void Update()
    {
        if (target_point == null) return;

        Vector3 current_position = transform.position;
        Vector3 target_position = new Vector3(target_point.position.x, current_position.y, current_position.z);

        transform.position = Vector3.MoveTowards(current_position, target_position, speed * Time.deltaTime);

        Debug.Log("Moving to: " + target_point.name + " Current X: " + current_position.x + " Target X: " + target_position.x);

        // Check if the farmer has reached the target point
        if (Mathf.Approximately(transform.position.x, target_position.x))
        {
            // Switch to the other point
            target_point = target_point == point_one ? point_two : point_one;
            Debug.Log("Switching target to: " + target_point.name);
        }
    }
}

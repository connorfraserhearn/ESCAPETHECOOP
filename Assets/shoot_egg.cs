using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_egg : MonoBehaviour
{
    public GameObject egg_prefab;
    public Transform fire_point;
    public float fire_cooldown = 1f;
    private float fire_timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0f) return;

        fire_timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && fire_timer >= fire_cooldown)
        {
            Instantiate(egg_prefab, fire_point.position, fire_point.rotation);
            fire_timer = 0f;
        }
    }
}

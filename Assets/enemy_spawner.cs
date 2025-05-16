using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public GameObject[] enemy_prefabs;
    public Transform[] spawn_points;
    public Transform player;
    public float spawn_interval = 60f;
    public int maximum_enemies = 5;
    public int current_enemies = 0;
    private float timer = 0f;
    private bool first_spawned = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (current_enemies >= maximum_enemies)
            return;

        timer += Time.deltaTime;

        if (timer >= spawn_interval)
        {
            if (!first_spawned)
            {
                spawn_enemy(0);
                first_spawned = true;
            }
            else
            {
                spawn_random_enemy();
            }

            timer = 0f;
        }
    }

    void spawn_enemy(int index)
    {
        Transform spawn_point = spawn_points[Random.Range(0, spawn_points.Length)];
        GameObject enemy = Instantiate(enemy_prefabs[index], spawn_point.position, Quaternion.identity);

        enemy follow_script = enemy.GetComponent<enemy>();
        if (follow_script != null)
        {
            follow_script.target = player;
        }

        current_enemies++;
    }
    void spawn_random_enemy()
    {
        int index = Random.Range(0, enemy_prefabs.Length);
        spawn_enemy(index);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlock_gate : MonoBehaviour
{
    public GameObject win_panel;
    public GameObject timer_text;
    public Collider2D gate_collider;
    public float unlock_time = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (game_stats_timer.time_played >= unlock_time)
        {
            gate_collider.enabled = true;
        }   
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && game_stats_timer.time_played >= unlock_time)
        {
            Time.timeScale = 0f;
            win_panel.SetActive(true);
            timer_text.SetActive(false);
        }
    }
}

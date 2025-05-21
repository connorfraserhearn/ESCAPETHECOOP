using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title_screen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        game_stats_timer.time_played = 0f;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject title_panel;

    public void StartGame()
    {
        title_panel.SetActive(false);
        Time.timeScale = 1f;
    }
}

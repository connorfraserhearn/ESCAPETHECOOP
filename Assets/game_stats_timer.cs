using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_stats_timer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0f)
        {
            time_played += Time.deltaTime;
        }
    }
    public static float time_played = 0f;
}

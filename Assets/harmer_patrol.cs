using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harmer_patrol : enemy
{

    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        move_towards_target();
    }
}

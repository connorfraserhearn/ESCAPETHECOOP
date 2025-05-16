using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meat_eater_patrol : enemy
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.25f;
    }

    // Update is called once per frame
    void Update()
    {
        move_towards_target();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent3 : AIControl
{
    // Update is called once per frame
    void Update()
    {
        if (isNearTarget())
        {
            Evade();
        }
        else
        {
            Wander();
        }
    }
}

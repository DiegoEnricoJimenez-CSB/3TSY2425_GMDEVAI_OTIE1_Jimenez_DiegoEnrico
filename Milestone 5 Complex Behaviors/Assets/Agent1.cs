using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent1 : AIControl
{

    void Update()
    {
        if (isNearTarget())
        {
            Pursue();
        }
        else
        {
            Wander();
        }
    }
}

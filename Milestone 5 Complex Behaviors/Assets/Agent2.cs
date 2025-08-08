using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent2 : AIControl
{
    // Update is called once per frame
    void Update()
    {
        if (isNearTarget() && canSeeTarget())
        {
            CleverHide();
        }
        else
        {
            Wander();
        }
    }
}

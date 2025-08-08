using System.Collections;
using System.Collections.Generic;
//using UnityEditor.U2D;
using UnityEngine;

public class VehicleMovement : MonoBehaviour
{
    public Transform goal;
    public float speed = 0;
    public float rotSpeed = 1;
    public float acceleration = 5;
    public float deceleration = 1;
    public float minSpeed = 0;
    public float maxSpeed = 10;
    public float breakAngle = 20;

    private void Start()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
        //Vector3 lookAtGoal = new Vector3(goal.position.x, goal.position.x, goal.position.z);
        Vector3 direction = lookAtGoal - this.transform.position;

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                            Quaternion.LookRotation(direction),
                                            Time.deltaTime * rotSpeed);

        // speed = Mathf.Clamp(speed + (acceleration * Time.deltaTime), minSpeed, maxSpeed);

        if (Vector3.Angle(goal.forward, this.transform.forward) > breakAngle && (speed > maxSpeed * .2) )
        {
            speed = Mathf.Clamp(speed - (deceleration * Time.deltaTime), minSpeed, maxSpeed);
        }
        else
        {
            speed = Mathf.Clamp(speed + (acceleration * Time.deltaTime), minSpeed, maxSpeed);
        }
        this.transform.Translate(0, 0, speed);
    }
}

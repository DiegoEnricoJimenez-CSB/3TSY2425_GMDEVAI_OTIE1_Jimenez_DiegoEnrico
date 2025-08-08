using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    public GameObject targetPlayer;

    // Start is called before the first frame update
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("AI");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 1000))
            {
                foreach (GameObject ai in agents)
                {
                    ai.GetComponent<AIControl>().agent.SetDestination(hit.point);
                }
            }

        }
        else
        {
            foreach (GameObject ai in agents)
            {
                ai.GetComponent<AIControl>().agent.SetDestination(targetPlayer.transform.position);
                if (ai.GetComponent<AIControl>().agent.remainingDistance < 5)
                    ai.GetComponent<AIControl>().agent.isStopped = true;
                else
                    ai.GetComponent<AIControl>().agent.isStopped = false;
            }
        }
    }
}

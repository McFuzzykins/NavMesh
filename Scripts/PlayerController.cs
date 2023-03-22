using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //check if click LMB
        {
            Ray newPos = cam.ScreenPointToRay(Input.mousePosition); //shoot ray for new position
            RaycastHit hit;

            if (Physics.Raycast(newPos, out hit)) //checking if ray hit something
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}

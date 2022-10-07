using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State {
    public GameObject glowObj;
    public GameObject lightDecider;
    public DecideLight light;
    

    public ChaseState(StateController stateController) : base(stateController) { }

    public override void CheckTransitions()
    {
        if(Vector3.Distance(stateController.ai.transform.position, stateController.player.transform.position) < stateController.detectionRange / 2)
        {
            stateController.SetState(new AttackState(stateController));
        }
    }
    public override void Act()
    {
        if (Vector3.Distance(stateController.ai.transform.position, stateController.player.transform.position) < 10)
        {
            stateController.destination = stateController.player.transform.position;
            stateController.ai.SetDestination(stateController.destination);
        }
        else if (light.target != null && Vector3.Distance(stateController.ai.transform.position, light.target.transform.position) < stateController.detectionRange * 2)
        {
            Debug.Log("should be going after the light");
            stateController.destination = light.target.transform.position;
            stateController.ai.SetDestination(stateController.destination);

            if (Vector3.Distance(stateController.ai.transform.position, light.target.transform.position) < 1)
            {
                light.target.GetComponent<Light>().enabled = false;
                light.target.GetComponent<BoxCollider>().enabled = false;


                stateController.destination = stateController.GetNextNavPoint();
                stateController.SetState(new PatrolState(stateController));

            }

            if (light.target.GetComponent<Light>().enabled == false)
            {
                stateController.destination = stateController.GetNextNavPoint();
                stateController.SetState(new PatrolState(stateController));

            }


        }
        else 
        {
            stateController.destination = stateController.GetNextNavPoint();
            stateController.SetState(new PatrolState(stateController));

        
        } 

    }

    public override void OnStateEnter()
    {
        stateController.ChangeColor(Color.blue);
        stateController.ai.speed = 4f;

        lightDecider = GameObject.FindGameObjectWithTag("lightTracker");
        light = lightDecider.GetComponent<DecideLight>();
    }
}

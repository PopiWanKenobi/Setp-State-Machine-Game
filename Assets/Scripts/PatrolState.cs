using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolState : State {

    public GameObject glowObj;
    public GameObject lightDecider;
    public DecideLight light;

    public PatrolState(StateController stateController) : base(stateController) { }
   
    public override void CheckTransitions()
    {
        if (Vector3.Distance(stateController.ai.transform.position, stateController.player.transform.position) < stateController.detectionRange)
        {
            stateController.destination = stateController.player.transform.position;

            stateController.SetState(new ChaseState(stateController));
        }
        if (light.target != null && Vector3.Distance(stateController.ai.transform.position, light.target.transform.position) < stateController.detectionRange * 2)
        {

                stateController.SetState(new ChaseState(stateController));

            
        }
        
    }
    public override void Act()
    {
        if (light.target != null)
        {
            stateController.destination = light.target.transform.position;
            stateController.ai.SetDestination(stateController.destination);

        }

        else if (stateController.destination == null || Vector3.Distance(stateController.ai.transform.position, stateController.destination) < 2 )
        {
            stateController.destination = stateController.GetNextNavPoint();
            stateController.ai.SetDestination(stateController.destination);
        }
        
        
    }
    public override void OnStateEnter()
    {
        lightDecider = GameObject.FindGameObjectWithTag("lightTracker");
        light = lightDecider.GetComponent<DecideLight>();

        //stateController.destination = stateController.GetNextNavPoint();

 
        stateController.agent.speed = 2f;
 
        
        stateController.ai.SetDestination(stateController.destination);
        stateController.ChangeColor(Color.green);


    }

}

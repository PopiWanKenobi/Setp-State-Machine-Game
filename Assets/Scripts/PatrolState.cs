using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : State {

    public GameObject glowObj;
    public GameObject lightDecider;
    public DecideLight light;

    public PatrolState(StateController stateController) : base(stateController) { }
   
    public override void CheckTransitions()
    {
        if (stateController.CheckIfInRange("Player"))
        {
            stateController.SetState(new ChaseState(stateController));
        }
        if (light.target != null)
        {
            //Debug.Log("light on, swapped to chase");
            //stateController.SetState(new ChaseState(stateController));
            if ((stateController.transform.position - light.target.transform.position).magnitude < 10)
            {
                stateController.SetState(new ChaseState(stateController));

            }
        }
        
    }
    public override void Act()
    {
        if(stateController.destination == null || stateController.ai.DestinationReached())
        {
            stateController.destination = stateController.GetNextNavPoint();
            stateController.ai.SetTarget(stateController.destination);
        }
    }
    public override void OnStateEnter()
    {
        lightDecider = GameObject.FindGameObjectWithTag("lightTracker");
        light = lightDecider.GetComponent<DecideLight>();
        //stateController.destination = stateController.GetNextNavPoint();
        
        if (stateController.ai.agent != null)
        {
            stateController.ai.agent.speed = .5f;
        }
        stateController.ai.SetTarget(stateController.destination);
        stateController.ChangeColor(Color.green);
    }

}

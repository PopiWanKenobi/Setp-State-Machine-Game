using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeState : State
{
    public FleeState(StateController stateController) : base(stateController)
    {
    }

    public override void CheckTransitions()
    {
        if (stateController.CheckIfInRange("navpoint"))
        {
            stateController.hasAttacked = false;
            stateController.SetState(new PatrolState(stateController));
        }
    }
    public override void Act()
    {
        if (stateController.destination == null || stateController.ai.DestinationReached())
        {
            stateController.destination = stateController.GetNextNavPoint();
            stateController.ai.SetTarget(stateController.destination);
        }
    }
    public override void OnStateEnter()
    {
        stateController.destination = stateController.GetNextNavPoint();
        if (stateController.ai.agent != null)
        {
            stateController.ai.agent.speed = 3.5f;
        }
        stateController.ai.SetTarget(stateController.destination);
        stateController.ChangeColor(Color.yellow);
    }
}

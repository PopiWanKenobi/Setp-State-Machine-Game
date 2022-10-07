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
            stateController.canAttack = true;

            if (!stateController.CheckIfInRange("Player"))
            {
                stateController.SetState(new PatrolState(stateController));
            }
            else
            {
            stateController.destination = stateController.GetNextNavPoint();

            }



        }
    }
    public override void Act()
    {
        if (stateController.destination == null || Vector3.Distance(stateController.ai.transform.position, stateController.destination) < 2)
        {
            stateController.destination = stateController.GetNextNavPoint();
            stateController.ai.SetDestination(stateController.destination);
        }
    }
    public override void OnStateEnter()
    {
        //stateController.destination = stateController.GetNextNavPoint();
        if (stateController.ai != null)
        {
            stateController.ai.speed = 2f;
        }
        stateController.ai.SetDestination(stateController.destination);
        //stateController.ChangeColor(Color.yellow);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{

    public AttackState(StateController stateController) : base(stateController) { }

        public override void CheckTransitions()
        {
            if (Vector3.Distance(stateController.ai.transform.position, stateController.player.transform.position) > stateController.detectionRange)
            {
                stateController.SetState(new PatrolState(stateController));
            }

            if(stateController.hasAttacked)
            {
                stateController.SetState(new FleeState(stateController));
            }
        }

        public override void Act()
        {

                stateController.destination = stateController.player.transform.position;
                stateController.ai.SetDestination(stateController.destination);

               if (Vector3.Distance(stateController.ai.transform.position, stateController.player.transform.position) < 1) stateController.AttackPlayer();
            
        }

        public override void OnStateEnter()
        {
            stateController.ai.speed = 4;
            stateController.ChangeColor(Color.red);
        }
}

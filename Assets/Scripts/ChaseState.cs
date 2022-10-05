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
        if(stateController.CheckIfInRange("Player"))
        {
            stateController.SetState(new AttackState(stateController));
        }
    }
    public override void Act()
    {
        if(stateController.enemyToChase != null)
        {
            stateController.destination = stateController.enemyToChase.transform;
            stateController.ai.SetTarget(stateController.destination);
        }
        else if (light.target != null)
        {
            Debug.Log("should be going after the light");
            stateController.destination = light.target.transform;
            stateController.ai.SetTarget(stateController.destination);

            if ((stateController.transform.position - light.target.transform.position).magnitude < 2)
            {
                light.target.GetComponent<Light>().enabled = false;
                light.target.GetComponent<BoxCollider>().enabled = false;
                

                stateController.destination = null;
                stateController.SetState(new PatrolState(stateController));

            }

            if (light.target.GetComponent<Light>().enabled == false) 
            {
                stateController.destination = null;
                stateController.SetState(new PatrolState(stateController));
                
            }


        }
    }

    public override void OnStateEnter()
    {
        stateController.ChangeColor(Color.blue);
        stateController.ai.agent.speed = 2f;
        lightDecider = GameObject.FindGameObjectWithTag("lightTracker");
        light = lightDecider.GetComponent<DecideLight>();
    }
}

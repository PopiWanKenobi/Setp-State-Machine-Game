using UnityEngine;
using UnityEngine.AI;

public class Attack : State
{
    
    public GameObject glowObj;
    public GameObject lightDecider;
    public DecideLight light;

    public Attack(GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player)
        : base(_npc, _agent, _anim, _player)
    {
        name = STATE.ATTACK;
        agent.speed = 2; //speed is only important if agent has a pathg
        agent.isStopped = false;
    }

    public override void Enter()
    {
        lightDecider = GameObject.FindGameObjectWithTag("lightTracker");
        light = lightDecider.GetComponent<DecideLight>();
        Debug.Log("Attack");
        base.Enter();
    }
    public override void Update()
    {

        if ((agent.transform.position - player.transform.position).magnitude < 2)
        {
            Debug.Log("Hit the player");
            nextState = new Chase(npc, agent, anim, player);
            stage = EVENT.EXIT;
        }

       else
        {
            nextState = new Chase(npc, agent, anim, player);
            stage = EVENT.EXIT;
        }


    }
    public override void Exit()
    {
        // anim.ResetTrigger("isWalking"); //takes out any sitting animations that didnt run
        base.Exit();
    }
}

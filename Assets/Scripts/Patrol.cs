using UnityEngine;
using UnityEngine.AI;

public class Patrol : State
{
    public GameObject checkpoint;
    public GameObject lightDecider;
    public DecideLight light;

    


    public Patrol(GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player)
        : base(_npc, _agent, _anim, _player)
    {
        name = STATE.PATROL;
        agent.speed = 2; //speed is only important if agent has a pathg
        agent.isStopped = false;
    }

    public override void Enter()
    {
        lightDecider = GameObject.FindGameObjectWithTag("lightTracker");
        light = lightDecider.GetComponent<DecideLight>();
        Debug.Log("Partoling");
        base.Enter();
    }
    public override void Update()
    {
        if (light.target != null)
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
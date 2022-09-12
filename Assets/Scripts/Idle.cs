using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Idle : State
{

    public Idle(GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player)
        : base(_npc, _agent, _anim, _player)
    {
        name = STATE.IDLE;
    }
    public override void Enter()
    {
        //anim.SetTrigger("isIdle");

        Debug.Log("I'm in idle right now");
        base.Enter();
    }
    public override void Update()
    {

        nextState = new Patrol(npc, agent, anim, player);
        stage = EVENT.EXIT;

    }
    public override void Exit()
    {
        //anim.ResetTrigger("isIdle"); //takes out any sitting animations that didnt run
        base.Exit();
    }
}

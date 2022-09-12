using UnityEngine;
using UnityEngine.AI;

public class Patrol : State
{
    public GameObject checkpoint;
    public GameObject glowObj;
    public Light glowStick;





    public Patrol(GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player)
        : base(_npc, _agent, _anim, _player)
    {
        name = STATE.PATROL;
        agent.speed = 2; //speed is only important if agent has a pathg
        agent.isStopped = false;
    }

    public override void Enter()
    {
        glowObj = GameObject.FindGameObjectWithTag("light");
        glowStick = glowObj.GetComponent<Light>();
        checkpoint = GameObject.FindGameObjectWithTag("Player");

        Debug.Log("I'm in patrol right now");
        base.Enter();
    }
    public override void Update()
    {
        agent.SetDestination(checkpoint.transform.position);

        if (glowStick.isActiveAndEnabled == true)
        {
            nextState = new Attack(npc, agent, anim, player);
            stage = EVENT.EXIT;
        }


    }
    public override void Exit()
    {
       // anim.ResetTrigger("isWalking"); //takes out any sitting animations that didnt run
        base.Exit();
    }
}
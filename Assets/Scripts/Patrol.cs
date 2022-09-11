using UnityEngine;
using UnityEngine.AI;

public class Patrol : State
{
    int currentIndex = -1;


    public Patrol(GameObject _npc, NavMeshAgent _agent, Animator _anim, Transform _player)
        : base(_npc, _agent, _anim, _player)
    {
        name = STATE.PATROL;
        agent.speed = 2; //speed is only important if agent has a pathg
        agent.isStopped = false;
    }

    public override void Enter()
    {
        currentIndex = 0;
        //anim.SetTrigger("isWalking");
        Debug.Log("I'm in patrol right now");
        base.Enter();
    }
    public override void Update()
    {
        //do whatever you want to do for the patrol
        //Debug.Log("I'm supposed to be walking around");


        /*
        if (agent.remainingDistance < 1)
        {
            if (currentIndex >= GameEnviornment.Singleton.Checkpoints.Count - 1) //this is checking if theres a path to patrol
            {
                currentIndex = 0;
            }
            else
            {
                currentIndex++;
            }
            agent.SetDestination(GameEnviornment.Singleton.Checkpoints[currentIndex].transform.position);
        }*/
        agent.SetDestination(new Vector3(0,0,0));

    }
    public override void Exit()
    {
       // anim.ResetTrigger("isWalking"); //takes out any sitting animations that didnt run
        base.Exit();
    }
}
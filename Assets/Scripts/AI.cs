using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    NavMeshAgent agent;
    Animator anim;
    public Transform player;
    State currentState;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();
        currentState = new Idle(gameObject, agent, anim, player);
    }
    private void Update()
    {
        currentState = currentState.Process();
    }
}
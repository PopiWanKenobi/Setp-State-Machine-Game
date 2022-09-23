using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class AI : MonoBehaviour
{
    /*Animator anim;
    public Transform player;
    State currentState;
    public GameObject navPointsParent;
    public GameObject[] navPoints;

    public Transform target;
    public GameObject enemyToChase;

    public float remainingDistance;

    public Transform destination;

    public NavMeshAgent agent;

    public GameObject[] enemies;

    public GameObject newNavPoint;

    public int navPointNum;
    public int navPointCount;

    [Header("A.I Settings")]
    public float detectionRadius = 8;
    public float maximumDetectionAngle = 50;
    public float minimumDetectionAngle = -50;

    void Start()
    {

        navPoints = GameObject.FindGameObjectsWithTag("navpoint");
        navPointCount = navPoints.Length;

        Debug.Log("Number of nav points " + navPointCount);
        for(int i = 0; i < navPointCount; i++)
        {
            Debug.Log("Nav Point Name : " + navPoints[i]);
            Debug.Log("Nav Point Transform x : " + navPoints[i].transform.position.x + " z : " + navPoints[i].transform.position.z);

        }

        agent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();
        currentState = new Idle(gameObject, agent, anim, player);
    }
    private void Update()
    {
        currentState = currentState.Process();
    }
    public bool DestinationReached()
    {
        return agent.remainingDistance < agent.stoppingDistance;
    }
    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    public void AddNavPoint(Vector3 pos)
    {
        GameObject go = Instantiate(newNavPoint, pos, Quaternion.identity);
        go.transform.SetParent(navPointsParent.transform);
        navPoints = GameObject.FindGameObjectsWithTag("navpoint");

    }

    public Transform GetNextNavPoint()
    {
        Debug.Log("Nav Point Num: " + navPointNum);
        navPointNum = (navPointNum + 1) % navPoints.Length; //Object reference not set to an instance of an object

        return navPoints[navPointNum].transform;
    }

    public Vector3 GetRandomPoint()
    {
        Vector3 ran = new Vector3(Random.Range(-detectionRadius, detectionRadius), 1.5f, Random.Range(-detectionRadius, detectionRadius));
        return ran;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);

        Vector3 fovLine1 = Quaternion.AngleAxis(maximumDetectionAngle, transform.up) * transform.forward * detectionRadius;
        Vector3 fovLine2 = Quaternion.AngleAxis(minimumDetectionAngle, transform.up) * transform.forward * detectionRadius;
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, fovLine1);
        Gizmos.DrawRay(transform.position, fovLine2);
    }
    */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace KB
{
    public class EnemyLocomotionManager : CharacterStats
    {

        /*public LayerMask detectionLayer;
        NavMeshAgent navMeshAgent;
        EnemyManager enemyManager;
        public Rigidbody enemyRigidBody;

        public Vector3 direction;

        public float distanceFromTarget;
        public float stoppingDistance = 1.0f;

        public float rotationSpeed = 15;

        private void Awake() 
        {
            enemyManager = GetComponent<EnemyManager>();
            navMeshAgent = GetComponentInChildren<NavMeshAgent>();
            enemyRigidBody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            navMeshAgent.enabled = false;
            enemyRigidBody.isKinematic = false;
        }

        public void HandleMoveToTarget()
        {
            Vector3 targetDirection = enemyManager.currentTarget.transform.position - transform.position;
            distanceFromTarget = Vector3.Distance(enemyManager.currentTarget.transform.position, transform.position);
            float viewableAngle = Vector3.Angle(targetDirection, transform.forward);

            if(enemyManager.isPreformingAction)
            {
                navMeshAgent.enabled = false;
            }
            else
            {
                if(distanceFromTarget > stoppingDistance)
                {
                    //animator
                } 
                else if(distanceFromTarget <= stoppingDistance)
                {
                    //animator 
                }
            }

            direction = enemyManager.target.transform.position - this.transform.position;
            this.transform.LookAt(enemyManager.target.transform.position);
            if (direction.magnitude > 1)
            {
                Vector3 velocity = direction.normalized * 1.0f * Time.deltaTime;
                this.transform.position = this.transform.position + velocity;
            }

            HandleRotateTowardsTarget();
            navMeshAgent.transform.localPosition = Vector3.zero;
            navMeshAgent.transform.localRotation = Quaternion.identity;
        }

        private void HandleRotateTowardsTarget()
        {
            if(enemyManager.isPreformingAction)
            {
                Vector3 direction = enemyManager.currentTarget.transform.position - transform.position;
                direction.y = 0;
                direction.Normalize();

                if(direction == Vector3.zero)
                {
                    direction = transform.forward;
                }

                Quaternion targetRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed / Time.deltaTime);
            }
            else 
            {
                Vector3 relativeDirection = transform.InverseTransformDirection(navMeshAgent.desiredVelocity);
                Vector3 targetVelocity = enemyRigidBody.velocity;

                navMeshAgent.enabled = true;
                navMeshAgent.SetDestination(enemyManager.currentTarget.transform.position);
                enemyRigidBody.velocity = targetVelocity;
                transform.rotation = Quaternion.Slerp(transform.rotation, navMeshAgent.transform.rotation, rotationSpeed / Time.deltaTime);
            }
        }*/
    }

}

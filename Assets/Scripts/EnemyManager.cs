using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KB
{
    public class EnemyManager : CharacterManager
    {
        /*EnemyLocomotionManager enemyLocomotionManager;
        EnemyStats enemyStats;

        public CharacterStats currentTarget;
        public State currentState;
        
        public GameObject target;

        public bool isPreformingAction;

        [Header("A.I Settings")]
        public float detectionRadius = 10;
        public float maximumDetectionAngle = 50;
        public float minimumDetectionAngle = -50;

        


        private void Awake() 
        {
            enemyLocomotionManager = GetComponent<EnemyLocomotionManager>();
            enemyStats = GetComponent<EnemyStats>();
        }

        private void Update()
        {
            HandleStateMachine();
        }

        private void HandleStateMachine() 
        {
            if(enemyLocomotionManager.currentTarget == null)
            {
                enemyLocomotionManager.HandleDetection();
            }
            else 
            {
                enemyLocomotionManager.HandleMoveToTarget();
            }
            if(currentState != null)
            {
                State nextState = currentState.Tick(this, enemyStats);

                if(nextState != null)
                {
                    SwitchToNextState(nextState);
                }
            }
        }

        private void SwitchToNextState(State state)
        {
            currentState = state;
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
        }*/
    }
}


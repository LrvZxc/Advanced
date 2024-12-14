using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyGuard : MonoBehaviour
{
    public List<Transform> Waypoints;
    public Transform Target;
    public NavMeshAgent agent;
    public Animator Animator;
    public GameObject CaughtCutScene;


    void Start()
    {
        
    }
  
    void Update()
    {

        float distance = Vector3.Distance(transform.position, Target.position);  
        if(distance < 4f)
        {
            Animator.SetBool("IsWalking", false);
            
            var rnd = Random.Range(0, Waypoints.Count);
            Target = Waypoints[rnd];                                                                                
        }
        else
        {
            agent.SetDestination(Target.position);
            Animator.SetBool("IsWalking", true);
            
        }
     
        
    }
    
}

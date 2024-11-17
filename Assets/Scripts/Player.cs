using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
  public NavMeshAgent agent;
    
    
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                //GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube)
                //cube.transform.position = hit.point;

                agent.SetDestination(hit.point);
            }
                Debug.DrawLine(ray.origin, hit.point);
         
          
        }
     }
}

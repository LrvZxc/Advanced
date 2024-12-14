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

    //Появляеться ли выбранный обьект после активации анимации throw? Выполенено.
    //Издает ли монетка звук?


  public NavMeshAgent agent;
  public Animator animator;
  public Vector3 Hit;
  public GameObject Coin;
  public GameObject CaughtCutScene;
   





    void Update()
    {
        CoinThrow();

        Movement();

        AnimationManagment();
        
    }
  
    private void AnimationManagment()
    {
        float distance = Vector3.Distance(transform.position, Hit);
        if (distance > 4f)
        {
            animator.SetBool("IsWalking", true);
            Debug.Log(distance);
        }
        else
        {

            animator.SetBool("IsWalking", false);
        }
    }

    private void Movement()
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
          
        }
    }

    private void CoinThrow()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

           
          if(Physics.Raycast(ray, out hit, 100))
            { 
                var coin = Instantiate(Coin);
                coin.transform.position = hit.point; 
            }
            animator.SetTrigger("throw");
        }
    }
}

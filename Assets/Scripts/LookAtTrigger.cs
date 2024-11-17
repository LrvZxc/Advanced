using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTrigger : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public Transform PlayerLookAt;


    void Update()
    {
        transform.LookAt(PlayerLookAt);
    }
}

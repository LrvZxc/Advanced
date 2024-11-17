using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraOneTrigger : MonoBehaviour
{

    void Start()
    {

    }

    public Transform CameraPoint;
    public GameObject Camera;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Camera.transform.position = CameraPoint.position;

        }
    }


    void Update()
    {

    }


}

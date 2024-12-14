using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGuard : MonoBehaviour

{
    public GameObject CaughtCutScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CaughtCutScene.SetActive(true);
            Debug.Log("Trigger is working!");
        }
    }
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCardTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject CutScene;
    public GameObject SleepingGuard;
    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Player"))
        {
            CutScene.SetActive(true);
            SleepingGuard.SetActive(false);
            Debug.Log("Trigger is working!");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

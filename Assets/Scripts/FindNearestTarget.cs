using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindNearestTarget : MonoBehaviour
{
    private GameObject[] allTargets;
    [SerializeField] private Transform closestTarget;
     private Animator anim;
     private MoveToChoosenTarget moveScript;

     private void Start()
     {
         anim = GetComponent<Animator>();
         moveScript = GetComponent<MoveToChoosenTarget>();
     }

     void Update()
    {
       closestTarget =  chooseClosestEnemy();
       if (closestTarget != null)
       {
           anim.SetBool("isChasing",true);
           moveScript.SetTarget(closestTarget);
       }
       else
       {
           anim.SetBool("isChasing",false);
       }
    }

    public Transform chooseClosestEnemy()
    {
        allTargets = GameObject.FindGameObjectsWithTag("Target");
        float closetDistance = Mathf.Infinity;
        Transform returnTargetTans = null;
        foreach (GameObject target in allTargets)
        {
            float distance = Vector3.Distance(transform.position, target.transform.position);
            if (distance < closetDistance)
            {
                closetDistance = distance;
                returnTargetTans = target.transform;
            }
        }
        
        return returnTargetTans;
    }
}

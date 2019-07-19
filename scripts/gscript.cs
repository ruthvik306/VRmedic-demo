using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class gscript : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent nma;
    public float distance;
    public GameObject gob;
    //public float second;
    //public float stime;
    void Start()
    {
        nma = GetComponent<NavMeshAgent>();

    }
    void Update()
    {
    //    stime = Time.time;
            nma.SetDestination(target.transform.position);
            distance = Vector3.Distance(transform.position, target.transform.position);
            if (distance <= 4f)
            {
                GetComponent<Animator>().Play("Idle");
                gob.SetActive(true);



            }
        else
                GetComponent<Animator>().Play("walking");

            
    }
           
            
}



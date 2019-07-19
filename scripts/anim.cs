using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public void walk()
    {
        Vector3 pos = new Vector3(25.903f, -21.8f, -13.26f);
        player.transform.position = pos;
        player.GetComponent<Animator>().Play("walk");
    }
}

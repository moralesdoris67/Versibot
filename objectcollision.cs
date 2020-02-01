using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectcollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "deadplant")
        {
            Debug.Log("deadplant");
            playerscore++; //refrence score variable from scoresystem script
        }

        if (collision.gameObject.tag == "plastic")
        {
            Debug.Log("plastic");
            Destroy(this.gameObject);
        }
    }
}

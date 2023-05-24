using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGate : MonoBehaviour
{
    GameObject myGameObject;
    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            myGameObject = GameObject.FindWithTag("Fork");
            myGameObject.transform.position = new Vector3((float)-26.627239227294923,(float)150.11000061035157,(float)3.584754467010498);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            myGameObject = GameObject.FindWithTag("Fork");
            myGameObject.transform.position = new Vector3((float)-26.627239227294923,(float)147.5399932861328,(float)3.584754467010498);
        }
    } 
}

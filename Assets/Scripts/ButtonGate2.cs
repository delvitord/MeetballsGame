using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGate2 : MonoBehaviour
{
    GameObject myGameObject;
    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            myGameObject = GameObject.FindWithTag("Fork1");
            myGameObject.transform.position = new Vector3((float)-19.329999923706056,(float)148.52999877929688,(float)20.799999237060548);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            myGameObject = GameObject.FindWithTag("Fork1");
            myGameObject.transform.position = new Vector3((float)-19.329999923706056,(float)145.10000610351563,(float)20.799999237060548);
        }
    } 
}

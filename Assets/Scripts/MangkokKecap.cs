using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MangkokKecap : MonoBehaviour
{
    int isVictory = 0;
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Kecap"))
        {
            Die();
        }
    }

    void Die()
    {
        transform.position = new Vector3((float)-27.06999969482422,(float)144.75698852539063,(float)-12.505462646484375);
    }
    
}

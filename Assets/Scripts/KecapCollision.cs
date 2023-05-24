using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KecapCollision : MonoBehaviour
{
    Vector3 startPoint = new Vector3((float)-25.31999969482422,(float)146.2939910888672,(float)-12.505462646484375);

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Saos"))
        {
            Die();
        }

        if (other.gameObject.CompareTag("FinishKecap"))
        {
            Die();
        }

        if (other.gameObject.CompareTag("Checkpoint"))
        {
            startPoint = new Vector3((float)-31.41999816894531,(float)143.91000366210938,(float)15.020000457763672);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Respawn"))
        {
            Die();
        }
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }

    void Die()
    {
        transform.position = startPoint;
    }
}

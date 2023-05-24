using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2CameraController : MonoBehaviour
{
    
    [SerializeField] GameObject target;
    [SerializeField] float xOffset;
    [SerializeField] float yOffset;
    [SerializeField] float zOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + new Vector3( xOffset, yOffset, zOffset);
        transform.LookAt(target.transform.position);
    }
}

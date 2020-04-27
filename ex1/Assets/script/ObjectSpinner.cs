using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpinner : MonoBehaviour
{
     public float speed=50.0f;
     public Transform target;
     
     private Vector3 zAxis = new Vector3(0, 0, 1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(target.position, zAxis, speed);
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}

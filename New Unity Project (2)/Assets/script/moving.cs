using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    // Start is called before the first frame update
     float stepSize = 0.1f;


    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.UpArrow)) 
            transform.position += new Vector3(0, stepSize, 0);
         if (Input.GetKey(KeyCode.DownArrow)) 
            transform.position += new Vector3(0, -stepSize, 0);
         if (Input.GetKey(KeyCode.RightArrow)) 
            transform.position += new Vector3(stepSize,0, 0);
         if (Input.GetKey(KeyCode.LeftArrow)) 
            transform.position += new Vector3(-stepSize, 0, 0);
       
        
    }
}

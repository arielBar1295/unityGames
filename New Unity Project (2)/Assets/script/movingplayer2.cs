using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplayer2 : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
     float stepSize = 0.1f;


    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.W)) 
            transform.position += new Vector3(0, stepSize, 0);
         if (Input.GetKey(KeyCode.S)) 
            transform.position += new Vector3(0, -stepSize, 0);
         if (Input.GetKey(KeyCode.D)) 
            transform.position += new Vector3(stepSize,0, 0);
         if (Input.GetKey(KeyCode.A)) 
            transform.position += new Vector3(-stepSize, 0, 0);
       
        
    }
}

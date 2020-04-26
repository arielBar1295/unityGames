using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_player : MonoBehaviour
{
    public int pointP1=0;
    public int pointP2=0;
    public KeyCode right;
    public KeyCode left;
    public KeyCode up;
    public KeyCode down;
    float stepSize = 0.03f;

    void Update()
    { 
        if (Input.GetKey(up)) 
            transform.position += new Vector3(0, stepSize, 0);
         if (Input.GetKey(down)) 
            transform.position += new Vector3(0, -stepSize, 0);
         if (Input.GetKey(right)) 
            transform.position += new Vector3(stepSize,0, 0);
         if (Input.GetKey(left)) 
            transform.position += new Vector3(-stepSize, 0, 0);
       
        
    }
        private void OnTriggerEnter2D(Collider2D col){
            if(col.gameObject.tag == "planet"){
                 if(this.tag == "play1"){
                      pointP1+=10;
                      Destroy(col.gameObject);

                 }
                else{
                    pointP2+=10;
                    Destroy(col.gameObject);

                } 

            }


            }  
    }


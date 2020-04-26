using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control2Players : MonoBehaviour
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
        if (Input.GetKey(up)) {
            transform.position += new Vector3(0, stepSize, 0);
            
        }
         if (Input.GetKey(down)) 
            transform.position += new Vector3(0, -stepSize, 0);
         if (Input.GetKey(right)) 
            transform.position += new Vector3(stepSize,0, 0);
         if (Input.GetKey(left)) 
            transform.position += new Vector3(-stepSize, 0, 0);
       
        
    }
        private void OnTriggerEnter2D(Collider2D col){
            if(this.tag == "player1"){
                Debug.Log("in play1 collision");
               if (col.gameObject.tag == "planet"){
                    Destroy(col.gameObject);
                    pointP1+=10;
        }
            }
            else{
                 Debug.Log("in play2 collision");

                if (col.gameObject.tag == "planet"){
                    Destroy(col.gameObject);
                    pointP2+=10; 
            }

            }  
    }
// void OnGUI()
//     {
//         GUI.Box(new Rect(700, 20, 100, 20), "Score : "+point);

//     }
}

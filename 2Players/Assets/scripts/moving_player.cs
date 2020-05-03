using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_player : MonoBehaviour
{
    public int pointPlayer1=0;
    public int pointPlayer2=0;
    public int pointP1;
     public int pointP2;

    public int pointP3;

    public int pointP4;

    public KeyCode right;
    public KeyCode left;
    public KeyCode up;
    public KeyCode down;
    float stepSize = 0.03f;

    void Update()
    { 
        if (Input.GetKey(up)) {
          transform.position += new Vector3(0, stepSize, 0);
          Debug.Log("now moving:"+this.name);
          }
            
         if (Input.GetKey(down)) 
            transform.position += new Vector3(0, -stepSize, 0);
         if (Input.GetKey(right)) 
            transform.position += new Vector3(stepSize,0, 0);
         if (Input.GetKey(left)) 
            transform.position += new Vector3(-stepSize, 0, 0);
       
        
    }
        private void OnTriggerEnter2D(Collider2D col){
            if(col.gameObject.tag =="P1" ||col.gameObject.tag =="P2"||col.gameObject.tag =="P3"||col.gameObject.tag =="P4"){
                int pointsToAdd=0;
                  switch(col.gameObject.tag) 
{
  case "P1":
 pointsToAdd= pointP1;
    break;
  case "P2":
   pointsToAdd= pointP2;

    break;
      case "P3":
      pointsToAdd= pointP3;

    break;
      case "P4":
       pointsToAdd= pointP4;

    break;
  default:
  
    break;
}
                 if(this.tag == "play1"){
                      pointPlayer1+=pointsToAdd;
                      Destroy(col.gameObject);

                 }
                else{
                    pointPlayer2+=pointsToAdd;
                    Destroy(col.gameObject);

                } 

            }


            }  
    }


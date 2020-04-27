using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlepath : MonoBehaviour
{

     private float RotateSpeed = 3f;
     private float Radius = 2.0f;
 
     private Vector2 centre;
     private float angle;
 
     private void Start()
     {
         centre = transform.position;
     }
 
     private void Update()
     {  //continue moving while holding the key
        if (Input.GetKey(KeyCode.RightArrow)) {
           angle += RotateSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
             angle -= RotateSpeed * Time.deltaTime;
        }
 
        
 
         var offset = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)) * Radius;
         transform.position = centre + offset;
     }
}

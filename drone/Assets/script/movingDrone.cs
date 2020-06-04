﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movingDrone : MonoBehaviour
{     
    Rigidbody drone;
    [SerializeField] Text scoreT;
    [SerializeField] int scorePlanetPrurple;

    [SerializeField] int scorePlanetBlue;

    [SerializeField] int scorePlanetYellow;

    [SerializeField] int scorePlanetRed;

    int score=0;
    // Start is called before the first frame update
    void Start()
    {
        drone=GetComponent<Rigidbody>();
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovementUpDown();
        MovementForward();
        Rotation();
        sides();
       
        drone.AddRelativeForce(Vector3.up * upForce);
        drone.rotation=Quaternion.Euler(
            new Vector3(0,currYrotation,drone.rotation.z)
        );
    }
    public float upForce;
    void MovementUpDown()
    {
        if(Input.GetKey(KeyCode.I))
        {
            upForce=450f;
        }
        else if(Input.GetKey(KeyCode.K))
        {
            upForce=-200f;
        }
          else if(!Input.GetKey(KeyCode.K)&&!Input.GetKey(KeyCode.I))
        {
            upForce=98.1f;
        }
    }
    private float movementForwardSpeed=300.0f;
    private float titlAmountForward;
        private float titelVelocityForward=0;

    void MovementForward()
    {
      if(Input.GetAxis("Vertical") != 0)
      {           

          drone.AddRelativeForce(Vector3.forward * Input.GetAxis("Vertical") * movementForwardSpeed);
           titlAmountForward=Mathf.SmoothDamp(titlAmountForward, 20 * Input.GetAxis("Vertical"), ref titelVelocityForward ,0.1f);
      }
    }
    private float wantedYrotation;
    private float currYrotation;
        private float rotationAmountbykeys=2.5f;
            private float rotationYvelocity;
            void Rotation()
            {
                if(Input.GetKey(KeyCode.J))
                {
                    wantedYrotation-=rotationAmountbykeys;
                }
                if(Input.GetKey(KeyCode.H))
                {
                    wantedYrotation+=rotationAmountbykeys;
                }
                currYrotation=Mathf.SmoothDamp(currYrotation,wantedYrotation, ref rotationYvelocity , 0.25f);
            }
    private float sideAmount=300f;
    private float titelamountSides;
    private float titelamountVel;
    void sides()
    {
         
          drone.AddRelativeForce(Vector3.right * Input.GetAxis("Horizontal") * sideAmount);

    }
    void OnCollisionEnter(Collision collisionInfo)
{
    if(collisionInfo.gameObject.tag=="blueP")
    {   
        score+=scorePlanetBlue;
        Destroy(collisionInfo.gameObject);
        scoreT.text="Score:"+score;
    }
     if(collisionInfo.gameObject.tag=="redP")
    {   
        score+=scorePlanetRed;
        Destroy(collisionInfo.gameObject);
        scoreT.text="Score:"+score;
    }
     if(collisionInfo.gameObject.tag=="yellowP")
    {   
        score+=scorePlanetYellow;
        Destroy(collisionInfo.gameObject);
        scoreT.text="Score:"+score;
    }
     if(collisionInfo.gameObject.tag=="purpleP")
    {   
        score+=scorePlanetPrurple;
        Destroy(collisionInfo.gameObject);
        scoreT.text="Score:"+score;
    }


         }
}

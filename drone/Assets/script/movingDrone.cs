using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movingDrone : MonoBehaviour
{     
    Rigidbody drone;
    [SerializeField] Text scoreT;
    int score=0;
    // Start is called before the first frame update
    void Awake()
    {
        drone=GetComponent<Rigidbody>();
                 transform.rotation = Quaternion.Euler(0,-93f, 0);

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
            new Vector3(titlAmountForward,currYrotation,drone.rotation.z)
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
    private float movementForwardSpeed=500.0f;
    private float titlAmountForward=0;
    private float titelVelocityForward;
    void MovementForward()
    {
      if(Input.GetAxis("Vertical") != 0)
      {           

          drone.AddRelativeForce(transform.forward * movementForwardSpeed * Time.deltaTime);
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
      if(Mathf.Abs(Input.GetAxis("Horizontal")) > 0.2f)
      {          
          drone.AddRelativeForce(Vector3.right * Input.GetAxis("Horizontal") * sideAmount);
          titelamountSides=Mathf.SmoothDamp(titelamountSides, 20 * Input.GetAxis("Horizontal"), ref titelamountVel ,0.1f);
      }
      else
      {
          titelamountSides=Mathf.SmoothDamp(titelamountSides, 0, ref titelamountVel ,0.1f);
      }
    }
    void OnCollisionEnter(Collision collisionInfo)
{
    if(collisionInfo.gameObject.tag=="planet")
    {   
        score+=10;
        Destroy(collisionInfo.gameObject);
        scoreT.text="Score:"+score;
    }


         }
}

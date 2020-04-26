using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   Vector3 scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
 public void Update(){
    
     transform.localScale +=scaleChange;
      if (transform.localScale.y < 0.7f || transform.localScale.y > 1.0f)
        {
            scaleChange = -scaleChange;
        }
}
}
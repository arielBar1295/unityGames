using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showPointsPlayer2 : MonoBehaviour
{
     void OnGUI()
    {
   GUI.Box(new Rect(500,10, 100, 20), "Score : "+ GameObject.Find("player2").GetComponent<moving_player>().pointPlayer2);
   //  GUI.Box(new Rect(Screen.width*1/3,Screen.height,10,10),"Build Options");


    }
}

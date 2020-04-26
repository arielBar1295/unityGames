using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showPoints : MonoBehaviour
{
    
    void OnGUI()
    {
    GUI.Box(new Rect(10, 10, 100, 20), "Score : "+ GameObject.Find("player1").GetComponent<moving_player>().pointPlayer1);

    }
}

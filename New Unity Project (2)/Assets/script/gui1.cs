using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gui1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnGUI()
    {
    GUI.Box(new Rect(500, 10, 100, 20), "Score : "+ GameObject.Find("player1").GetComponent<control2Players>().pointP1);

    }
}

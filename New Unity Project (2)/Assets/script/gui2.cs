using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gui2 : MonoBehaviour
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
            Debug.Log("int gui1");

     GUI.Box(new Rect(10, 10, 100, 20), "Score : "+ GameObject.Find("player1 (1)").GetComponent<control2Players>().pointP2);

    }
}

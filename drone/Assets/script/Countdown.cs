using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    [SerializeField] int levelTolLoad;
    [SerializeField] float timer;
    [SerializeField] Text timerSeconds;
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if(timer<=0)
        {
            Debug.Log("in if!!");
            Application.LoadLevel(levelTolLoad);
        }
    }
}

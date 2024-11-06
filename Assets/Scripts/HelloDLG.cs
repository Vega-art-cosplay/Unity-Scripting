using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloDLG : MonoBehaviour
{
    // Default is ""
    public string message = "Welcome to scripting";

    // Default is 0
    int year = 2024;

    // Default is 0f
    float age;

    // Default is false
    bool isRunning = false;
    bool isWalking = true;

    // Start is called before the first frame update
    void Start()
    {
        //print(message);


        //isWalking = !isRunning;
        //print(isRunning);
        //print(isWalking);

    }

    // Update is called once per frame
    void Update()
    {
        print(message);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeout : MonoBehaviour
{
    GameObject Animal;
    GameObject Car;
    bool TimeoutUsable = false;

    public void Start()
    {
        Animal = GameObject.Find("animal");//找到animal对象
        Car = GameObject.Find("Car");//找到车子
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && TimeoutUsable == false)
        {
            Debug.Log("暂停");
            Stop();
            TimeoutUsable = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && TimeoutUsable == true)
        {
            Debug.Log("继续");
            Continue();
            TimeoutUsable = false;
        }
    }    
    public void Stop()
    {
        Animal.GetComponent<AnimalTimeout>().enabled = true;
        //CarSuspended();
    }
    public void Continue()
    {
        Animal.GetComponent<AnimalTimeout>().enabled = false;
        //CarContinue();
    }
}

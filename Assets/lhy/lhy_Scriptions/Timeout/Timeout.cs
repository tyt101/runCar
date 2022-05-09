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
        Animal = GameObject.Find("animal");//�ҵ�animal����
        Car = GameObject.Find("Car");//�ҵ�����
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && TimeoutUsable == false)
        {
            Debug.Log("��ͣ");
            Stop();
            TimeoutUsable = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && TimeoutUsable == true)
        {
            Debug.Log("����");
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

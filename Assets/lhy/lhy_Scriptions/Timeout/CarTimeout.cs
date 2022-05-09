using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTimeout : MonoBehaviour
{
    bool Usable = false;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)&&Usable == false)
        {
            //Debug.Log("ÔÝÍ£");
            CarSuspended();
            Usable = true;
        }
        if (Input.GetKeyDown(KeyCode.E)&&Usable == true)
        {
            //Debug.Log("¼ÌÐø");
            CarContinue();
            Usable = false;
        }
    }
    public void CarSuspended()
    {
        this.GetComponent<Move>().enabled = false;
    }
    public void CarContinue()
    {
        this.GetComponent<Move>().enabled = true;
    }
}

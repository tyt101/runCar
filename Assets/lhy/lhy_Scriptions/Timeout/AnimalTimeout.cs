using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalTimeout : MonoBehaviour
{
    bool Usable = false;
    int count;
    public void Start()
    {
        count = this.transform.childCount;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && Usable == false)
        {
            AnimalSuspended();
            Usable = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && Usable == true)
        {
            AnimalContinue();
            Usable = false;
        }
    }
    public void AnimalSuspended()//������ͣ
    {
        for (int i = count - 1; i >= 0; i--)
        {


            //else
            //{
            //    Debug.Log("û�нű�");
            //}
            try
            {
                if (this.transform.GetChild(i).GetChild(0).GetComponent<NPCScript>() != null)
                {
                    this.transform.GetChild(i).GetChild(0).GetComponent<NPCScript>().enabled = false;
                }
            }
            catch (System.Exception)
            {

                
            }
        }
    }
    public void AnimalContinue()//�������
    {
        for (int i = count - 1; i >= 0; i--)
        {
            try
            {
                if (this.transform.GetChild(i).GetChild(0).GetComponent<NPCScript>() != null)
                {
                    this.transform.GetChild(i).GetChild(0).GetComponent<NPCScript>().enabled = true;
                }
            }
            catch (System.Exception)
            {


            }
            //else
            //{
            //    Debug.Log("û�нű�");
            //}
        }
    }
}

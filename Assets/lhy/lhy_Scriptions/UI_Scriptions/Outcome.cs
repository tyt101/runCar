using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Outcome : MonoBehaviour
{
    GameObject Hb;//����Ѫ������
    public GameObject button;
    public void Awake()
    {
        Hb = GameObject.Find("Canvas/HealthBars");//��ȡѪ������
        //button = GameObject.Find("Canvas/buttonGameObject");
    }
   
    /// <summary>
    /// ����Ϸͨ��ʱ����ʾ��Ϸͨ�ص��ı�
    /// </summary>
    public void Win()
    {
            transform.Find("Win").GetComponent<Text>().enabled = true;
    }

    /// <summary>
    /// ����Ϸʧ��ʱ����ʾ��Ϸʧ�ܵ��ı�
    /// </summary>
    public void Defeat()
    {
       transform.Find("Defeat").GetComponent<Text>().enabled = true;        
    }
    public void showButton()
    {
        button.SetActive(true);
    }
    public void Update()
    {
        if(Hb.GetComponent<Slider>().value == 0)//�ж�Ѫ���Ƿ�Ϊ0
        {
            Defeat();
        }
    }
}

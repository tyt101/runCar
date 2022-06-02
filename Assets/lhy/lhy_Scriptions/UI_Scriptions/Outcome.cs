using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Outcome : MonoBehaviour
{
    GameObject Hb;//定义血条对象
    public GameObject button;
    public void Awake()
    {
        Hb = GameObject.Find("Canvas/HealthBars");//获取血条对象
        //button = GameObject.Find("Canvas/buttonGameObject");
    }
   
    /// <summary>
    /// 当游戏通关时，显示游戏通关的文本
    /// </summary>
    public void Win()
    {
            transform.Find("Win").GetComponent<Text>().enabled = true;
    }

    /// <summary>
    /// 当游戏失败时，显示游戏失败的文本
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
        if(Hb.GetComponent<Slider>().value == 0)//判断血量是否为0
        {
            Defeat();
        }
    }
}

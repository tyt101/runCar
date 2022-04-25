using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Handoff : MonoBehaviour
{
    static bool eSpace = false;
    static bool rSpace = false;
    /// <summary>
    /// 触发存档点击事件
    /// </summary>
    public void OnExistBtn()
    {
        if (rSpace == true)//判断读档档案是否显示
        {
            for (int i = 0; i < 9; i++)
            {
                GameObject.Find("Canvas/readSpace").transform.GetChild(i).GetComponent<Image>().enabled = false;
                rSpace = false;
            }
        }
        for (int i = 0; i < 9; i++)//显示存档档案
        {
            GameObject.Find("Canvas/existSpace").transform.GetChild(i).GetComponent<Image>().enabled = true;
            eSpace = true;
        }
    }
    /// <summary>
    /// 触发读档点击事件
    /// </summary>
    public void OnReadBtn()
    {
        if (eSpace == true)//判断存档档案是否显示
        {
            for (int i = 0; i < 9; i++)
            {
                GameObject.Find("Canvas/existSpace").transform.GetChild(i).GetComponent<Image>().enabled = false;
                eSpace = false;
            }
        }
        for (int i = 0; i < 9; i++)//显示读档档案
        {
            GameObject.Find("Canvas/readSpace").transform.GetChild(i).GetComponent<Image>().enabled = true;
            rSpace = true;
        }
    }
}

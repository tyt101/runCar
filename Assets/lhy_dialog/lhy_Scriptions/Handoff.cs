using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Handoff : MonoBehaviour
{
    static bool eSpace = false;
    static bool rSpace = false;
    /// <summary>
    /// �����浵����¼�
    /// </summary>
    public void OnExistBtn()
    {
        if (rSpace == true)//�ж϶��������Ƿ���ʾ
        {
            for (int i = 0; i < 9; i++)
            {
                GameObject.Find("Canvas/readSpace").transform.GetChild(i).GetComponent<Image>().enabled = false;
                rSpace = false;
            }
        }
        for (int i = 0; i < 9; i++)//��ʾ�浵����
        {
            GameObject.Find("Canvas/existSpace").transform.GetChild(i).GetComponent<Image>().enabled = true;
            eSpace = true;
        }
    }
    /// <summary>
    /// ������������¼�
    /// </summary>
    public void OnReadBtn()
    {
        if (eSpace == true)//�жϴ浵�����Ƿ���ʾ
        {
            for (int i = 0; i < 9; i++)
            {
                GameObject.Find("Canvas/existSpace").transform.GetChild(i).GetComponent<Image>().enabled = false;
                eSpace = false;
            }
        }
        for (int i = 0; i < 9; i++)//��ʾ��������
        {
            GameObject.Find("Canvas/readSpace").transform.GetChild(i).GetComponent<Image>().enabled = true;
            rSpace = true;
        }
    }
}

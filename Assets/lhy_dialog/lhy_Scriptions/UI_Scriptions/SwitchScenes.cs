using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    /// <summary>
    /// OnArchiveBtn()������������浵��¼����ť���л�������Load(�浵\��������)
    /// </summary>
    public void OnArchiveBtn()
    {
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// OnBackBtn()��������������ء���ť���л�������GameStart����Ϸ��ʼ���棩
    /// </summary>
    public void OnBackBtn()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// OnShoppingBtn()���������Ϸ�̳ǡ���ť���л�������Supermarket����Ϸ�̳ǽ��棩
    /// </summary>
    public void OnShoppingBtn()
    {
        SceneManager.LoadScene(3);
    }

    /// <summary>
    /// OnLoadGoInBtn()���������ʼ��Ϸ����ť���л���������Ϸ����
    /// </summary>
    public void OnLoadGoInBtn()
    {
        SceneManager.LoadScene(4);
    }
}

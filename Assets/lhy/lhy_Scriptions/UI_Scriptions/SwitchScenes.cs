using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    /// <summary>
    /// OnArchiveBtn()方法，点击“存档记录”按钮，切换场景到Load(存档\读档界面)
    /// </summary>
    public void OnArchiveBtn()
    {
        SceneManager.LoadScene(2);
    }

    /// <summary>
    /// OnBackBtn()方法，点击“返回”按钮，切换场景到GameStart（游戏开始界面）
    /// </summary>
    public void OnBackBtn()
    {
        SceneManager.LoadScene("Load");
    }

    /// <summary>
    /// OnShoppingBtn()，点击“游戏商城”按钮，切换场景到Supermarket（游戏商城界面）
    /// </summary>
    public void OnShoppingBtn()
    {
        SceneManager.LoadScene("Supermarket");
    }

    /// <summary>
    /// OnLoadGoInBtn()，点击“开始游戏”按钮，切换场景到游戏界面
    /// </summary>
    public void OnLoadGoInBtn()
    {
        SceneManager.LoadScene("TheSecondLevel");
    }
}

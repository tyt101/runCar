using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void OnArchiveBtn()
    {
        SceneManager.LoadScene(2);
    }
    public void OnBackBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void OnShoppingBtn()
    {
        SceneManager.LoadScene(3);
    }
    public void OnLoadGoInBtn()
    {
        Debug.Log("hello");
        SceneManager.LoadScene("hjyScene");
    }
}

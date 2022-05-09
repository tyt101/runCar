using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Function : MonoBehaviour
{
    private Button button;
    private void Start()
    {
        button = GetComponent<Button>();
        //button.onClick.AddListener(load);
    }
    //此处待补充需要加载页面
    public void load()
    {
        InteratorDialog.instance.btn.SetActive(false);
        SceneManager.LoadScene("One1Scence");
    }
    public void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Debug.Log(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Function : MonoBehaviour
{
    private Button button;
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(load);
    }
    //此处待补充需要加载页面
    private void load()
    {
        Debug.Log("加载进入");
        InteratorDialog.instance.btn.SetActive(false);
    }
}

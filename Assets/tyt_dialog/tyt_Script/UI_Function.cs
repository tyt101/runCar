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
    //�˴���������Ҫ����ҳ��
    private void load()
    {
        Debug.Log("���ؽ���");
        InteratorDialog.instance.btn.SetActive(false);
    }
}

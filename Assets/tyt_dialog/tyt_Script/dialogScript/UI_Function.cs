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
        button.onClick.AddListener(load);
    }
    //�˴���������Ҫ����ҳ��
    public void load()
    {
        InteratorDialog.instance.btn.SetActive(false);
        SceneManager.LoadScene(1);
    }
}

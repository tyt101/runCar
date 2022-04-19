using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InteratorDialog : MonoBehaviour
{
    //实例
    public static InteratorDialog instance;
    //public
    public GameObject PanelBox;
    public Text introduces;
    public GameObject btn;
    [TextArea(1,3)] public string[] introductionLines;
    //private
    [SerializeField] private float textSpeed;
    private int currentLine;
    private bool isScrolling;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        btn = GameObject.Find("LoadGoInButton");
        btn.SetActive(false);
        PanelBox.SetActive(false);
    }
    private void Update()
    {
        if (PanelBox.activeInHierarchy)
        {
                if (Input.GetMouseButtonDown(0))
                {
                    if (!isScrolling)
                    {
                        currentLine++;
                        if (currentLine < introductionLines.Length)
                        {
                            StartCoroutine(ScrollingText());
                        }
                        else
                        {
                            //button按钮激活
                            PanelBox.SetActive(false);
                            btn.SetActive(true);
                            FindObjectOfType<PlayerController>().canMove = true;
                    }
                    }
                }
        }
    }
    private IEnumerator ScrollingText()
    {
        //使文字一个一个显示出
        isScrolling = true;
        introduces.text = "";
        
        foreach (char letter in introductionLines[currentLine].ToCharArray())
        {
            introduces.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
        
        isScrolling = false;
    }

    public void ShowDialogue(string[] _newLines)
    {
        //避免因为同时按住w键和空格键引发的Player一直往前跑的问题
        //else内容待补充
        if (FindObjectOfType<PlayerController>().speed == 0)
        {
            introductionLines = _newLines;
            currentLine = 0;

            StartCoroutine(ScrollingText());
            PanelBox.SetActive(true);
            FindObjectOfType<PlayerController>().canMove = false;
        }
        else
        {
            Debug.Log("请先将速度降为0");
        }
    }
}

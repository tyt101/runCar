using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InteratorDialog : MonoBehaviour
{
    public GameObject PanelBox;
    public Text introduces;
    [TextArea(1,3)] public string[] introductionLines;
    [SerializeField] private int currentLine;
    [SerializeField] private float textSpeed;
    private bool isScrolling;
    private void Start()
    {
        PanelBox.SetActive(true);
    }
    private void Update()
    {
        if (PanelBox.activeInHierarchy)
        {
            if (!isScrolling)
            {
               
                if (Input.GetMouseButtonDown(0))
                {
                    if (currentLine < introductionLines.Length)
                    {
                        StartCoroutine(ScrollingText());
                        //introduces.text = introductionLines[currentLine];
                    }
                    else
                    {
                        //进入开始界面
                        PanelBox.SetActive(false);
                    }
                }
            }
        }
    }
    private IEnumerator ScrollingText()
    {
        isScrolling = true;
        introduces.text = "";
        
        foreach (char letter in introductionLines[currentLine].ToCharArray())
        {
            introduces.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }
        currentLine += 1;
        isScrolling = false;
    }
}

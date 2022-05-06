using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SearchDialogManager : MonoBehaviour
{
    public static SearchDialogManager instance;
    public GameObject DialogPanel;
    public Text DialogueText;
    public Text DialogueName;
    private bool isScrolling;
    private float textSpeed = 0.04f;
    //对话数组
    [TextArea(1, 3)] public string[] dialogueLines;
    //输出对应行
    [SerializeField] public int currentLine;
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
        //DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        DialogueText.text = dialogueLines[currentLine];
    }
    private void Update()
    {
        if (DialogPanel.activeInHierarchy)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (isScrolling == false)
                {
                    currentLine++;
                    if (currentLine < dialogueLines.Length)
                    {
                        checkName();
                        StartCoroutine(ScrollingText());
                        //DialogueText.text = dialogueLines[currentLine];
                    }
                    else
                    {
                        DialogPanel.SetActive(false);
                        FindObjectOfType<PlayerController>().canMove = true;
                    }
                }
                
            }
        }
    }
    public void ShowDialogue(string[] _newLines ,bool _hasName)
    {
        dialogueLines = _newLines;
        currentLine = 0;

        checkName();
        StartCoroutine(ScrollingText());
        //DialogueText.text = dialogueLines[currentLine];
        DialogPanel.SetActive(true);
        DialogueName.gameObject.SetActive(_hasName);
        FindObjectOfType<PlayerController>().canMove = false;
    }
    private void checkName()
    {
        if (dialogueLines[currentLine].StartsWith("n-"))
        {
            DialogueName.text = dialogueLines[currentLine].Replace("n-","");
            currentLine++;
        }
    }
    private IEnumerator ScrollingText()
    {
        //使文字一个一个显示出
        isScrolling = true;
        DialogueText.text = "";

        foreach (char letter in dialogueLines[currentLine].ToCharArray())
        {
            DialogueText.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }

        isScrolling = false;
    }
    public void currentIndex()
    {
        currentLine = 0;
    }
}

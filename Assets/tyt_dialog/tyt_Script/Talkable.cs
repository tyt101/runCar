using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talkable : MonoBehaviour
{
    //public
    [TextArea(1, 3)] public string[] lines;
    public GameObject ui_text;
    //private
    private bool isEntered;
    private void Start()
    {
        ui_text = GameObject.Find("InteractTextObject");
        ui_text.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = true;
            ui_text.SetActive(true);
            Debug.Log("Player Entered");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = false;
            ui_text.SetActive(false);
            Debug.Log("Player Out");
        }
    }
    private void Update()
    {
        if (isEntered && Input.GetKeyDown(KeyCode.Space) && InteratorDialog.instance.PanelBox.activeInHierarchy == false)
        {
            InteratorDialog.instance.ShowDialogue(lines);
            ui_text.SetActive(false);
        }
    }
}

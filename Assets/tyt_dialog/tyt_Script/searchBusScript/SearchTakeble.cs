using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchTakeble : MonoBehaviour
{
    [SerializeField] private bool isEntered;
    [TextArea(1, 3)] public string[] lines;
    [TextArea(1, 3)] public string[] lines1;
    public bool hasName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            isEntered = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isEntered = false;
        }
    }
    private void Update()
    {
        if (isEntered && Input.GetKeyDown(KeyCode.Space) && SearchDialogManager.instance.DialogPanel.activeInHierarchy == false)
        {
            string[] line = FindObjectOfType<PlayerController>().hasCar ? lines : lines1;
            SearchDialogManager.instance.ShowDialogue(line, hasName);
        }
    }
}

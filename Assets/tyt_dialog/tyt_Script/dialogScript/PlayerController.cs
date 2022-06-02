using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    //public
    public Animator m_animator;
    public float speed = 0;
    //private
    public bool canMove = true;
    private bool isMove = false;
    public bool hasCar;
    private string[] lines;
    void Start()
    {
        m_animator = GetComponent<Animator>();
    } 

    // Update is called once per frame
    void Update()
    {
        updateSpeed();
        updateDirection();
    }
    private void updateSpeed()
    {
        if (canMove)
        {
            if (Keyboard.current.wKey.isPressed)
            {
                isMove = true;
            }
            if (Keyboard.current.wKey.wasReleasedThisFrame)
            {
                isMove = false;
            }
            if (isMove)
            {
                if (speed < 2)
                    speed += 0.05f;
            }
            else
            {
                speed = 0;
            }
            m_animator.SetFloat("Speed", speed);
        }
    }
    private void updateDirection()
    {
        if (isMove)
        {
            if (Keyboard.current.aKey.isPressed)
                this.transform.Rotate(0, (float)-0.5, 0);
            if (Keyboard.current.dKey.isPressed)
                this.transform.Rotate(0, (float)0.5, 0);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            Debug.Log("Car");
            if (SearchDialogManager.instance.currentLine >= SearchDialogManager.instance.dialogueLines.Length)
            {
                hasCar = true;
            }
        }
        else if (other.gameObject.tag == "Doctor")
        {
            SearchDialogManager.instance.currentIndex();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Doctor")
        {
            if (hasCar)
            {
                if (SearchDialogManager.instance.currentLine >= SearchDialogManager.instance.dialogueLines.Length)
                {
                    Debug.Log(")Doctor");
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }


        }
    }
}

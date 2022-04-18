using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Animator m_animator;
    public float speed = 0;
    private bool isMove = false;
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
            if (speed < 1)
                speed += 0.05f;
        }
        else
        {
            speed = 0;
        }
        m_animator.SetFloat("Speed", speed);
    }
    private void updateDirection()
    {
        if (isMove)
        {
            if (Keyboard.current.aKey.isPressed)
                this.transform.Rotate(0, -1, 0);
            if (Keyboard.current.dKey.isPressed)
                this.transform.Rotate(0, 1, 0);
        }

    }
}

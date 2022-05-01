using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Cat : MonoBehaviour
{
    private Animator m_animator;
    private void Start()
    {
        m_animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("CCCCCCCCCCCCCC");
        if (other.CompareTag("Player"))
        {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAA");
            m_animator.SetBool("death?", true);
        }
        if (other.CompareTag("collision"))
        {
            Debug.Log("BBBBBBBBBBBBBBBBBBBBBB");
            m_animator.SetBool("jump?", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("collision"))
        {
            Debug.Log("BBBBBBBBBBBBBBBBBBBBBB");
            m_animator.SetBool("jump?", false);
        }
    }
}

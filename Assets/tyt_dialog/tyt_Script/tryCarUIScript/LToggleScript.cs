using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LToggleScript : MonoBehaviour
{
    public GameObject ToggleGameObject;
    private bool isShow = true;
    private int perFrame = 0;
    private void Update()
    {
        perFrame++;
        if (Input.GetKeyUp(KeyCode.L))
        {
            if (perFrame % 1000 > 0)
            {
                isShow = !isShow;
                ToggleGameObject.SetActive(isShow);
                perFrame = 0;
            }
        }
    }
}

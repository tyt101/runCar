using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 按W\A\D键控制车的移动
/// </summary>
public class Move : MonoBehaviour
{
    public float speed = 1.5f;//车移动的速度
    public float speed1 = -1.5f;//车移动的速度
    //[HideInInspector]
    public float rotationAngle = 45f;//改变方向时旋转的角度
    public void Update()
    {
        MoveState();
    }

    /// <summary>
    /// 判断键盘状态，操纵赛车移动
    /// </summary>
    public void MoveState()
    {
        if(Input.GetKey(KeyCode.W))//按下W键向前移动
        {
            if (speed <= 5)
            {
                speed += 0.1f;
            }
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))//按下D键向右旋转
        {
            this.transform.Rotate(0, rotationAngle * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.A))//按下A键向左旋转
        {
            this.transform.Rotate(0, -rotationAngle * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.Z)&& Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 50f * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -50f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))//按下W键向前移动
        {
            
            //speed = -1.5f;
            if (speed1 >= -5)
            {
                speed1 += -0.1f;
            }
            this.transform.Translate(0, 0, speed1 * Time.deltaTime);
        }
    }
}

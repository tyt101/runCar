using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 按W\A\D键控制车的移动
/// </summary>
public class Move : MonoBehaviour
{
    //public delegate void PlayerScore(int temp);//定义委托
    //public event PlayerScore GetScore;//定义得分事件，用于发出得分的消息
    
    public float speed = 3;//车移动的速度
    public float speed1 = -3;//车移动的速度
    //[HideInInspector]
    public float rotationAngle = 45f;//改变方向时旋转的角度
    public void FixedUpdate()
    {
        MoveState();
    }

    /// <summary>
    /// 判断键盘状态，操纵赛车移动
    /// </summary>
    public void MoveState()
    {
        if (Input.GetKey(KeyCode.W))//按下W键向前移动
        {
            if (speed <= 3)
            {
                speed += 0.1f;
            }
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))//按下D键向右旋转
        {
            this.transform.Rotate(0, rotationAngle * Time.deltaTime * 2, 0);
        }
        if (Input.GetKey(KeyCode.A))//按下A键向左旋转
        {
            this.transform.Rotate(0, -rotationAngle * Time.deltaTime * 2, 0);
        }
        if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, 50f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -50f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))//按下W键向前移动
        {

            //speed = -1.5f;
            if (speed1 >= -3)
            {
                speed1 += -0.1f;
            }
            this.transform.Translate(0, 0, speed1 * Time.deltaTime);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "obstacle")
        {
            this.transform.Translate(-Vector3.forward);
            System.Threading.Thread.Sleep(100);
        }
        if (col.name == "StartFinishLine")
        {            
            GameObject.Find("Canvas").GetComponent<Outcome>().Win();
            this.enabled = false;
            if(GameObject.Find("Canvas"))
            GameObject.Find("Canvas").GetComponent<Outcome>().showButton();
            //GetComponent<Outcome>().showButton();
        }
        if (col.name == "StartFinishLine1")
        {
            GameObject.Find("Canvas").GetComponent<Outcome>().Win();
            this.enabled = false;
            if (Coin.Money >= 120 && CountDown.totaltime >= 0)
                GameObject.Find("Canvas").GetComponent<Outcome>().showButton();

        }
        /*if (col.gameObject.tag=="coin")//检查Player碰撞的物体是不是
        {
             GetScore(1);//发送得分事件消息，为接收器提供参数1，实现+1分的效果
            //if (GetScore != null)//检查事件是否为空，即有没有接收器订阅它
        }*/


    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//引入unity的UI编辑库

public class Catch : MonoBehaviour
{
    public Text txtcoin;
    void Update()
    {
        GameObject ifCollect = GameObject.Find("/Canvas/Money/ScoreText");
        ifCollect.GetComponent<Text>().text = Coin.Money.ToString();
    }
    /*public Move Car;//定义PlayerControl类
    public int score;//定义积分变量
    public Text ScoreText;//定义要修改的Text
    void Start()
    {
        Car.GetScore += Player_GetScore;//调用类，订阅Player的得分事件，start函数已经作为了我们的消息接收器
    }

    private void Player_GetScore(int score)//定义消息处理器来处理消息，给属性赋值，改变积分值
    {
        Score += score;
    }
    void Update()
    {

    }
    public int Score//定义积分属性，使用属性来进行控制，使每次积分被改变时就调用一次文本显示的修改
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            ScoreText.text = score.ToString();//让UI显示的分数等于score的值，这里有String类型的转换
        }
    }*/

}
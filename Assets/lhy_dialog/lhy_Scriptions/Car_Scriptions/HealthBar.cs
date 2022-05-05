using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float damageValue = 10f;//每次碰撞的损伤值
    GameObject healthBar;//定义血条对象
                         //实例
    public static HealthBar instance;
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
    }
    public void Start()
    {
        healthBar = GameObject.Find("Canvas/HealthBars");//获取血条对象
    }

    /// <summary>
    /// 减血
    /// </summary>
    public void Damage()
    {
        healthBar.GetComponent<Slider>().value -= damageValue;
    }

    /// <summary>
    /// 是否触发碰撞
    /// </summary>
    /// <param name="other">触发器</param>
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "obstacle")//如果障碍物不是地形
        {
            Debug.Log("障碍物的名字是：" + other.name);
            Damage();//减血
        }
        //if(other.tag == "Animal")
        //{
        //    Debug.Log("动物的名字是：" + other.name);
        //    Damage();
        //}
    }

    /// <summary>
    /// 赛车停止移动
    /// </summary>
    public void Death()
    {
        this.GetComponentInParent<Move>().enabled = false;
    }
    public void Update()
    {
        if (healthBar.GetComponent<Slider>().value <= 0)//血量小于等于0
            Death();
    }
}

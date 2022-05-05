using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float damageValue = 10f;//ÿ����ײ������ֵ
    GameObject healthBar;//����Ѫ������
                         //ʵ��
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
        healthBar = GameObject.Find("Canvas/HealthBars");//��ȡѪ������
    }

    /// <summary>
    /// ��Ѫ
    /// </summary>
    public void Damage()
    {
        healthBar.GetComponent<Slider>().value -= damageValue;
    }

    /// <summary>
    /// �Ƿ񴥷���ײ
    /// </summary>
    /// <param name="other">������</param>
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "obstacle")//����ϰ��ﲻ�ǵ���
        {
            Debug.Log("�ϰ���������ǣ�" + other.name);
            Damage();//��Ѫ
        }
        //if(other.tag == "Animal")
        //{
        //    Debug.Log("����������ǣ�" + other.name);
        //    Damage();
        //}
    }

    /// <summary>
    /// ����ֹͣ�ƶ�
    /// </summary>
    public void Death()
    {
        this.GetComponentInParent<Move>().enabled = false;
    }
    public void Update()
    {
        if (healthBar.GetComponent<Slider>().value <= 0)//Ѫ��С�ڵ���0
            Death();
    }
}

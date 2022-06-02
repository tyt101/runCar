using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetTest : MonoBehaviour
{
    private bool isMagnet = false;
    private float lasttime;
    private float currenttime;
    // Use this for initialization
    void Start()
    {
        lasttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        currenttime = Time.time;
        if (currenttime - lasttime <= 10)
        {
            //��������������ʯ�Ļ� �ͼ�������Χ�����д�����ײ������Ϸ����
            if (isMagnet)
            {

                //��������Ϊ���İ뾶��5�ķ�Χ�ڵ����еĴ�����ײ������Ϸ����
                Collider[] colliders = Physics.OverlapSphere(this.transform.position, 2);
                foreach (var item in colliders)
                {
                    //����ǽ��
                    if (item.tag.Equals("coin"))
                    {
                        //�ý�ҵĿ�ʼ�ƶ�
                        item.GetComponent<Coin>().isCanMove = true;
                    }
                }

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Magnet"))
        {
            //������ҿ�����ȡ��Χ�Ľ��
            isMagnet = true;
            //��������ʯ
            Destroy(other.gameObject);
            lasttime = Time.time;
        }
    }
}

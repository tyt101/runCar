using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��W\A\D�����Ƴ����ƶ�
/// </summary>
public class Move : MonoBehaviour
{
    //public delegate void PlayerScore(int temp);//����ί��
    //public event PlayerScore GetScore;//����÷��¼������ڷ����÷ֵ���Ϣ
    
    public float speed = 3;//���ƶ����ٶ�
    public float speed1 = -3;//���ƶ����ٶ�
    //[HideInInspector]
    public float rotationAngle = 45f;//�ı䷽��ʱ��ת�ĽǶ�
    public void FixedUpdate()
    {
        MoveState();
    }

    /// <summary>
    /// �жϼ���״̬�����������ƶ�
    /// </summary>
    public void MoveState()
    {
        if (Input.GetKey(KeyCode.W))//����W����ǰ�ƶ�
        {
            if (speed <= 3)
            {
                speed += 0.1f;
            }
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))//����D��������ת
        {
            this.transform.Rotate(0, rotationAngle * Time.deltaTime * 2, 0);
        }
        if (Input.GetKey(KeyCode.A))//����A��������ת
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
        if (Input.GetKey(KeyCode.S))//����W����ǰ�ƶ�
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
        /*if (col.gameObject.tag=="coin")//���Player��ײ�������ǲ���
        {
             GetScore(1);//���͵÷��¼���Ϣ��Ϊ�������ṩ����1��ʵ��+1�ֵ�Ч��
            //if (GetScore != null)//����¼��Ƿ�Ϊ�գ�����û�н�����������
        }*/


    }

}

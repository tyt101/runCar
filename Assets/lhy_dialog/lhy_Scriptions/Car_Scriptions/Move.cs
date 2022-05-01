using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ��W\A\D�����Ƴ����ƶ�
/// </summary>
public class Move : MonoBehaviour
{
    public float speed = 1.5f;//���ƶ����ٶ�
    public float speed1 = -1.5f;//���ƶ����ٶ�
    //[HideInInspector]
    public float rotationAngle = 45f;//�ı䷽��ʱ��ת�ĽǶ�
    public void Update()
    {
        MoveState();
    }

    /// <summary>
    /// �жϼ���״̬�����������ƶ�
    /// </summary>
    public void MoveState()
    {
        if(Input.GetKey(KeyCode.W))//����W����ǰ�ƶ�
        {
            if (speed <= 5)
            {
                speed += 0.1f;
            }
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))//����D��������ת
        {
            this.transform.Rotate(0, rotationAngle * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.A))//����A��������ת
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
        if (Input.GetKey(KeyCode.S))//����W����ǰ�ƶ�
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

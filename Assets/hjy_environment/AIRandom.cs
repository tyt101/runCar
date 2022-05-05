using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class AIRandom : MonoBehaviour
{
    //�����ٶȺ���ת�ٶ�
    public float MoveSpeed = 1.0f;
    public float RotateSpeed = 30.0f;
    //������·��ʽ
    public int key = 0;
    //��ǰ�Ƿ�����
    public bool temp = true;
    //��ǰ���ؽű���������Ϊ
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        key = 1;
        //��ȡ������Ϊ
        m_Animator = GetComponent<Animator>();
        //Э�̹Һ�̨
        StartCoroutine("Wait");
    }


    void Update()
    {
        if (temp == false)
        {
            //����Ϊ��ֱ����������ִ�к������·����
            return;
        }
        //��ʼ���ߣ���������޸�Ϊ�������߷�ʽ
        switch (key)
        {
            case 1:
                //��ǰ��
                transform.Translate(0, 0, 1 * MoveSpeed * Time.deltaTime, Space.Self);
                //��ת1��
                transform.Rotate(0, 1 * RotateSpeed * Time.deltaTime, 0, Space.Self);
                break;
            case 2:
                transform.Translate(0, 0, 1 * MoveSpeed * Time.deltaTime, Space.Self);
                transform.Rotate(0, 1 * RotateSpeed * Time.deltaTime, 0, Space.Self);
                break;
            case 3:
                transform.Translate(0, 0, 1 * MoveSpeed * Time.deltaTime, Space.Self);
                transform.Rotate(0, 1 * RotateSpeed * Time.deltaTime, 0, Space.Self);
                break;
            case 4:
                transform.Translate(0, 0, 1 * MoveSpeed * Time.deltaTime, Space.Self);
                transform.Rotate(0, 1 * RotateSpeed * Time.deltaTime, 0, Space.Self);
                break;

        }

    }
    IEnumerator Wait()
    {
        while (true)
        {
            //��������һ��Timer����
            yield return new WaitForSeconds(2);
            Timer();
        }
    }

    void Timer()
    {
        //���������1-3
        int i = Random.Range(0, 4);
        //��·�ĸ���Ϊ3/2
        if (i > 1)
        {
            temp = true;
            //������ģ����Ϊ״̬Ϊվ���������ʹ��cube��û����Ϊ���Ļ���ע����������
            //m_Animator.SetBool("idle", true);
            //������ת��ԭ�����ת
            transform.Rotate(0, 180, 0, Space.Self);
            return;
        }
        else
        {
            temp = false;
            //������ģ����Ϊ״̬Ϊ��·
            m_Animator.SetBool("idle", false);
        }
        //��һ����·��ʽ�������ǰ�˳����Ҳ���Ըĳ����
        key++;
        //��·��ʽ������1-4�������ڣ������ҿ�������ɶ
        if (key == 5)
        {
            key = 1;
        }
    }
}



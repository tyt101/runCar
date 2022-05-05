using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class AIRandom : MonoBehaviour
{
    //行走速度和旋转速度
    public float MoveSpeed = 1.0f;
    public float RotateSpeed = 30.0f;
    //控制走路方式
    public int key = 0;
    //当前是否行走
    public bool temp = true;
    //当前挂载脚本的人物行为
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        key = 1;
        //获取人物行为
        m_Animator = GetComponent<Animator>();
        //协程挂后台
        StartCoroutine("Wait");
    }


    void Update()
    {
        if (temp == false)
        {
            //行走为否直接跳过，不执行后面的走路代码
            return;
        }
        //开始行走，这里可以修改为四种行走方式
        switch (key)
        {
            case 1:
                //向前走
                transform.Translate(0, 0, 1 * MoveSpeed * Time.deltaTime, Space.Self);
                //旋转1度
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
            //两秒运行一次Timer函数
            yield return new WaitForSeconds(2);
            Timer();
        }
    }

    void Timer()
    {
        //生成随机数1-3
        int i = Random.Range(0, 4);
        //走路的概率为3/2
        if (i > 1)
        {
            temp = true;
            //设人物模型行为状态为站立，如果是使用cube等没有行为树的话请注释这条代码
            //m_Animator.SetBool("idle", true);
            //自身旋转，原地向后转
            transform.Rotate(0, 180, 0, Space.Self);
            return;
        }
        else
        {
            temp = false;
            //设人物模型行为状态为走路
            m_Animator.SetBool("idle", false);
        }
        //换一种走路方式，这里是按顺序，你也可以改成随机
        key++;
        //走路方式控制在1-4开区间内，别问我开区间是啥
        if (key == 5)
        {
            key = 1;
        }
    }
}



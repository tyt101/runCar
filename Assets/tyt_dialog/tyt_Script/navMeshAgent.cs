using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navMeshAgent : MonoBehaviour
{
    //������յ����������
    private NavMeshAgent nav;
    //������б�
    private List<Vector3> destpoints;
    //������һ�������
    private int nextindex;
    //�뵼�������ľ��� 
    private float calcdist = 5f;
    private float dist = 0f;

    void Start()
    {
        //�������·�߼��뵽List�б���
        destpoints = new List<Vector3>();
        destpoints.Add(GameObject.Find("point0").transform.position);
        destpoints.Add(GameObject.Find("point1").transform.position);
        destpoints.Add(GameObject.Find("point2").transform.position);
        destpoints.Add(GameObject.Find("point3").transform.position);
        //��ȡ��ǰ������NavMeshAgent
        nav = this.transform.GetComponent<NavMeshAgent>();

        //��������ĵ㣬��ȡ��һ������
        Vector3 navpoint = this.transform.position;
        for (int i = 0; i < destpoints.Count; ++i)
        {
            //�����жϵ��ڵ�ǰλ�õ�ǰ�����Ǻ󷽣�����Ǻ󷽲�������
            Vector3 dir = destpoints[i] - navpoint;
            float dot = Vector3.Dot(transform.forward, dir);
            //�жϵ���ǰ��ʱ�ż�������ĵ�ľ���
            if (dot > 0)
            {
                float tmpdist = Vector3.Distance(destpoints[i], navpoint);
                if (dist == 0)
                {
                    dist = tmpdist;
                    nextindex = i;
                }
                else if (dist > tmpdist)
                {
                    dist = tmpdist;
                    nextindex = i;
                }
            }
        }
    }

    void Update()
    {
        //�жϾ����Ƿ��ڵ��ﷶΧ�ڣ�������ߵ�һ�¸���
        if (Vector3.Distance(this.transform.position, destpoints[nextindex]) < calcdist)
        {
            if (nextindex == destpoints.Count - 1)
            {
                nextindex = 0;
            }
            else
            {
                nextindex++;
            }
        }

        nav.SetDestination(destpoints[nextindex]);
    }
}

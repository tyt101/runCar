using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//����unity��UI�༭��

public class Catch : MonoBehaviour
{
    public Move player;//����PlayerControl��
    public int score;//������ֱ���
    public Text ScoreText;//����Ҫ�޸ĵ�Text
    void Start()
    {
        player.GetScore += Player_GetScore;//����PlayerControl�࣬����Player�ĵ÷��¼���start�����Ѿ���Ϊ�����ǵ���Ϣ������
    }

    private void Player_GetScore(int score)//������Ϣ��������������Ϣ�������Ը�ֵ���ı����ֵ
    {
        Score += score;
    }
    void Update()
    {

    }
    public int Score//����������ԣ�ʹ�����������п��ƣ�ʹÿ�λ��ֱ��ı�ʱ�͵���һ���ı���ʾ���޸�
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            ScoreText.text = score.ToString();//��UI��ʾ�ķ�������score��ֵ��������String���͵�ת��
        }
    }

}

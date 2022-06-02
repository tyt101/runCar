using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 200.0f;
    public static int Money = 0;
    //����ƶ��ĵ�Ŀ��
    GameObject target;
    //����Ƿ�����ƶ�
    public bool isCanMove = false;
    //����ƶ����ٶ�
    public float speed = 0.1f;
    // Use this for initialization
    void Start()
    {
        //��ȡ���
        target = GameObject.Find("car_1");
    }

    //public static Text txt;
    // Start is called before the first frame update
    /*void Start()
    {
        Money = 0;
        txt = GameObject.Find("Text").GetComponent<Text>();
    }*/

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(rotationSpeed * Time.deltaTime, 0, 0));
        if (isCanMove)
        {
            //���������ƶ����ٶ�
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);
        }
        //GameObject ifCollect = GameObject.Find("/Canvas/Money");
        //ifCollect.GetComponent<Text>().text = Money.ToString();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name =="car_1")
        {
            Money++;
            Destroy(gameObject);
            Debug.Log("�Ե������");
            //Catch.txt.text = "��ң�" + Catch.Money;
        }
        


    }

}

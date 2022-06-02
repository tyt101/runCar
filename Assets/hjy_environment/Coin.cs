using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 200.0f;
    public static int Money = 0;
    //金币移动的的目标
    GameObject target;
    //金币是否可以移动
    public bool isCanMove = false;
    //金币移动的速度
    public float speed = 0.1f;
    // Use this for initialization
    void Start()
    {
        //获取玩家
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
            //金币向玩家移动的速度
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
            Debug.Log("吃到金币啦");
            //Catch.txt.text = "金币：" + Catch.Money;
        }
        


    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
	// Start is called before the first frame update
	private float totaltime = 80;
	public  Text TimeText;
	private float intervaltime = 1;
	//public float times = 60;
	//private int s;//定义一个秒

	void Start()
	{
		//TimeText = GameObject.Find("TimeText").GetComponent<Text>();
		TimeText.text = string.Format("{0:D2}:{1:D2}", (int)totaltime / 60, (int)totaltime % 60);
	}

	void Update()
	{
		if(totaltime>0)
        {
			intervaltime -= Time.deltaTime;
			if(intervaltime<=0)
            {
				intervaltime += 1;
				totaltime--;
				TimeText.text = string.Format("{0:D2}:{1:D2}", (int)totaltime / 60, (int)totaltime % 60);

			}
        }
		else
        {
			//Gameover();

        }
		//计时器完成倒计时的功能
		/*times -= Time.deltaTime;
		s = (int)times % 60; //小数转整数 
		TimeText.text = s.ToString();
		if (times <= 0)
		{
			//判定倒计时结束时该做什么
		}*/
	}

    private void Gameover()
    {
        throw new NotImplementedException();
    }
 
}

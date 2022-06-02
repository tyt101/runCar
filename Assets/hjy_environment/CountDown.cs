using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
	// Start is called before the first frame update
	public static float totaltime = 80;
	public  Text TimeText;
	public Text replay;
	private float intervaltime = 1;
	//public float times = 60;
	//private int s;//定义一个秒
	bool Usable = false;

	void Start()
	{
		//TimeText = GameObject.Find("TimeText").GetComponent<Text>();
		TimeText.text = string.Format("{0:D2}:{1:D2}", (int)totaltime / 60, (int)totaltime % 60);
	}

	void FixedUpdate()
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
			if(Coin.Money>=120)
            {
				SceneManager.LoadScene(3);
			}
        }
		if (totaltime<=0)
		{
			
			Gameover();
			
        }
		Stop();
	}

    private void Gameover()
    {
		//transform.Find("RePlay").
        replay.GetComponent<Text>().enabled = true;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Debug.Log(SceneManager.GetActiveScene().buildIndex);
		Coin.Money = 0;
		System.Threading.Thread.Sleep(2000);

	}

	public void Stop()
    {
		if (Input.GetKeyDown(KeyCode.Q) && Usable == false)
		{
			Debug.Log("暂停");
			Time.timeScale = 0;
			Usable = true;
		}
		if (Input.GetKeyDown(KeyCode.E) && Usable == true)
		{
			Debug.Log("继续");
			Time.timeScale = 1;
			Usable = false;
		}
	}
 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeoutUI : MonoBehaviour
{
    bool Usable = false;    
    public void Update()
    {
		if (Input.GetKeyDown(KeyCode.Q) && Usable == false)
		{
			this.transform.GetChild(0).GetComponent<Image>().enabled = true;
			Usable = true;
		}
		if (Input.GetKeyDown(KeyCode.E) && Usable == true)
		{
			this.transform.GetChild(0).GetComponent<Image>().enabled = false;
			Usable = false;
		}
	}
}

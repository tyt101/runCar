using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 200.0f;
    public static int Money = 0;
 
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

        //GameObject ifCollect = GameObject.Find("/Canvas/Money");
        //ifCollect.GetComponent<Text>().text = Money.ToString();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            
            Money++;
            Destroy(gameObject);
            //Catch.txt.text = "½ð±Ò£º" + Catch.Money;
        }
        


    }

}

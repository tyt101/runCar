using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    [SerializeField] private List<Transform> _pointList;
    [SerializeField] private GameObject _root;
    public float moveSpeed = 4f;
    private bool isCanMove;
    private Animator _ani;
    private void Start()
    {
        _isUp = true;
        isCanMove = true;
        _ani = GetComponent<Animator>();
    }


    private int index = 0;
    private bool _isUp = false;
    private void Update()
    {
        if (isCanMove)
        {
            if (_pointList != null && _pointList.Count > 0)
            {
                float dis = Vector3.Distance(transform.position, _pointList[index].position);
                if (Mathf.Abs(dis) < 0.1f)
                {
                    if (_isUp)
                    {
                        index++;
                        if (index >= _pointList.Count)
                        {
                            index -= 2;
                            _isUp = false;
                        }
                    }
                    else
                    {
                        index--;
                        if (index < 0)
                        {
                            index += 2;
                            _isUp = true;
                        }
                    }
                }
                Vector3 forward = (_pointList[index].position - transform.position).normalized;
                transform.forward = forward;
                transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * moveSpeed);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {;
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Enterner");
            isCanMove = false;
            _ani.SetBool("death?", true);
            Destroy(_root, 3);
        }
    }
}

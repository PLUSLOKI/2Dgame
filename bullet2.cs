using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2 : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }


        if (collision.CompareTag("Player"))
        {
            Debug.Log("�÷��̾ �߰� ũ���� ���Ϲ��� �浹�߽��ϴ�");
            Destroy(this.gameObject);
        }
    }
}

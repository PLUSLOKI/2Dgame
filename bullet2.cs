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
            Debug.Log("플레이어가 중간 크기의 낙하물과 충돌했습니다");
            Destroy(this.gameObject);
        }
    }
}

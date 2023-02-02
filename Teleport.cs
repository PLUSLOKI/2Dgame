using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject targetObj;
    
    public GameObject toObj;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("ok"); //충돌 체크
            targetObj = collision.gameObject;
            targetObj.transform.position = toObj.transform.position;
        }
    }
}

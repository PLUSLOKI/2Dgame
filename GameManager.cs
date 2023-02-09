using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet1;
    // Use this for initialization

    [SerializeField]
    private GameObject bullet2;
    // Use this for initialization

    [SerializeField]
    private GameObject bullet3;
    // Use this for initialization

    void Start()
    {
        StartCoroutine(Createbullet1Routine());
        StartCoroutine(Createbullet2Routine());
        StartCoroutine(Createbullet3Routine());
    }

    void Update()
    {
        
    }

    IEnumerator Createbullet1Routine()
    {
        while(true)
        {
            CreateBullet1();
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator Createbullet2Routine()
    {
        while (true)
        {
            CreateBullet2();
            yield return new WaitForSeconds(5);
        }
    }

    IEnumerator Createbullet3Routine()
    {
        while (true)
        {
            CreateBullet3();
            yield return new WaitForSeconds(10);
        }
    }



    private void CreateBullet1()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f, 1.0f), 1.1f, 0));
        pos.z = 0.0f;
        Instantiate(bullet1, pos, Quaternion.identity);
    }

    private void CreateBullet2()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f, 1.0f), 1.1f, 0));
        pos.z = 0.0f;
        Instantiate(bullet2, pos, Quaternion.identity);
    }

    private void CreateBullet3()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f, 1.0f), 1.1f, 0));
        pos.z = 0.0f;
        Instantiate(bullet3, pos, Quaternion.identity);
    }
}

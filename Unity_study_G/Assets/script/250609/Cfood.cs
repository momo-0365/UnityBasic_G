using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cfood : MonoBehaviour
{
    int count;

    private void Awake()
    {
        count = 0;
    }

    void Start()
    {


    }

    public void Gacha()
    {
        int randomValue = Random.Range(1, 101);
        Debug.Log($"랜덤한 값은 : {randomValue} 입니다");

        if (8 <= count)
        {
            Debug.Log("확정으로 '각청'을 뽑았다!");
            count = 0;
        }
        else if (randomValue <= 10)
        {
            Debug.Log("각청을 뽑았다!");
        }
        else if (randomValue <= 30)
        {
            Debug.Log("모나를 뽑았다!");
        }
        else
        {
            Debug.Log("치치를 뽑았다!");
        }

        count++;
    }
}
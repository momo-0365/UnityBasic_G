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
        Debug.Log($"������ ���� : {randomValue} �Դϴ�");

        if (8 <= count)
        {
            Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
            count = 0;
        }
        else if (randomValue <= 10)
        {
            Debug.Log("��û�� �̾Ҵ�!");
        }
        else if (randomValue <= 30)
        {
            Debug.Log("�𳪸� �̾Ҵ�!");
        }
        else
        {
            Debug.Log("ġġ�� �̾Ҵ�!");
        }

        count++;
    }
}
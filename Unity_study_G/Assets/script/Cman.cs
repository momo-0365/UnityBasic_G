using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cman : MonoBehaviour
{
    private string name = "������";
    private int age = 21;
    private float height = 180f;
    private string mbti = "INFP";

    void Start()
    {
        Say(name, age, height, mbti);
    }

    public void Say(string name, int age, float height, string mbti)
    {
        Debug.Log("�� �̸��� " + name + ". ���ط� " + age + "���̴�!");
        Debug.Log("�� Ű�� " + height + "cm�̰�, MBTI�� " + mbti + "��!!!");
    }
}

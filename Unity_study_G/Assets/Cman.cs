using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cman
{
    private string name = "������";
    private int age = 21;
    // private float height = 180f;
    // private string mbti = "INFP";

    void Start()
    {
        SelfIntroduction(name, age);
    }

    public void SelfIntroduction(string name, int age)
    {
        Debug.Log("���� �̸���" + name + "�Դϴ�.");
        Debug.Log($"���� ���̴� {age}�� �Դϴ�.");
    }
    
    public void Selfintrodution(string _name, int _age)
    {
        Debug.Log("���� �̸���" + _name + "�Դϴ�.");
        Debug.Log($"���� ���̴� {_age}�� �Դϴ�.");
    }
}




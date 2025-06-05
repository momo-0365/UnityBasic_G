using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cman
{
    private string name = "박지원";
    private int age = 21;
    // private float height = 180f;
    // private string mbti = "INFP";

    void Start()
    {
        SelfIntroduction(name, age);
    }

    public void SelfIntroduction(string name, int age)
    {
        Debug.Log("저의 이름은" + name + "입니다.");
        Debug.Log($"저의 나이는 {age}살 입니다.");
    }
    
    public void Selfintrodution(string _name, int _age)
    {
        Debug.Log("저의 이름은" + _name + "입니다.");
        Debug.Log($"저의 나이는 {_age}살 입니다.");
    }
}




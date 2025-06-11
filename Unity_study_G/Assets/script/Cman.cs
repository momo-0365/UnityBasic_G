using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cman : MonoBehaviour
{
    private string name = "박지원";
    private int age = 21;
    private float height = 180f;
    private string mbti = "INFP";

    void Start()
    {
        Say(name, age, height, mbti);
    }

    public void Say(string name, int age, float height, string mbti)
    {
        Debug.Log("내 이름은 " + name + ". 올해로 " + age + "살이다!");
        Debug.Log("내 키는 " + height + "cm이고, MBTI는 " + mbti + "다!!!");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMana : MonoBehaviour
{
    // ประกาศตัวแปร public สำหรับวัตถุ A และ B
    public GameObject objectA;
    public GameObject objectB;

    void Start()
    {
        // ตรวจสอบว่าวัตถุ B ถูกตั้งให้ไม่ทำงาน (inactive) ตั้งแต่เริ่มต้นหรือไม่
        if (objectB != null)
        {
            objectB.SetActive(false);
        }
    }

    void Update()
    {
        // ตรวจสอบว่าวัตถุ A ถูกทำลายหรือไม่
        if (objectA == null && objectB != null && !objectB.activeSelf)
        {
            // เปิดใช้งานวัตถุ B
            objectB.SetActive(true);
        }
    }
}
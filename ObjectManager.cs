using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject objectA; // วัตถุ A
    public GameObject objectB; // วัตถุ B
    public GameObject objectC; // วัตถุ C

    void Update()
    {
        // ตรวจสอบว่าวัตถุ A ถูกทำลายหรือไม่
        if (objectA == null)
        {
            // ปิดการใช้งานวัตถุ B
            if (objectB != null)
            {
                objectB.SetActive(false);
            }

            // เปิดการใช้งานวัตถุ C
            if (objectC != null)
            {
                objectC.SetActive(true);
            }

            // ปิดการใช้งานสคริปต์นี้เพื่อไม่ให้ทำงานซ้ำ
            this.enabled = false;
        }
    }
}
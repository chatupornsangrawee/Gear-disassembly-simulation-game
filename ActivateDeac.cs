using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeac : MonoBehaviour
{
    public GameObject[] objectsA; // วัตถุ A หลายชิ้น
    public GameObject objectB; // วัตถุ B

    private bool hasActivatedB = false; // สถานะว่าฟังก์ชันทำงานแล้วหรือยัง

    void Update()
    {
        // ตรวจสอบว่าฟังก์ชันนี้ทำงานไปแล้วหรือยัง
        if (hasActivatedB)
        {
            return; // ถ้าได้ทำงานแล้ว ให้ออกทันที
        }

        bool anyObjectAActive = false;

        foreach (GameObject objA in objectsA)
        {
            // ตรวจสอบว่าถ้าวัตถุ A ชิ้นใดชิ้นหนึ่งถูกเปิดใช้งาน
            if (objA.activeSelf)
            {
                anyObjectAActive = true;
                break;
            }
        }

        // ถ้าไม่มีวัตถุ A ใด ๆ ถูกเปิดใช้งาน
        if (!anyObjectAActive)
        {
            // เปิดใช้งานวัตถุ B
            objectB.SetActive(true);
            hasActivatedB = true; // ตั้งค่าสถานะว่าได้ทำงานแล้ว
        }
    }
}
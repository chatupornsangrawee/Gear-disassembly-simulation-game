using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject[] objectsA; // วัตถุ A หลายชิ้น
    public GameObject objectB; // วัตถุ B

    void Update()
    {
        foreach (GameObject objA in objectsA)
        {
            // ตรวจสอบว่าถ้าวัตถุ A ชิ้นใดชิ้นหนึ่งถูกเปิดใช้งาน
            if (objA.activeSelf)
            {
                // ปิดใช้งานวัตถุ B
                objectB.SetActive(false);
                return;
            }
        }

    }
}
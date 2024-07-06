using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleObjects : MonoBehaviour
{
    // อ้างอิงถึงวัตถุ A และ B
    public GameObject objectA;
    public GameObject objectB;
    // อ้างอิงถึงปุ่ม UI
    public Button toggleButton;

    void Start()
    {
        // ตรวจสอบให้แน่ใจว่ามีการตั้งค่าปุ่ม
        if (toggleButton != null)
        {
            // เพิ่ม listener ให้กับปุ่มเพื่อเรียกใช้ฟังก์ชัน ToggleObjects เมื่อกดปุ่ม
            toggleButton.onClick.AddListener(ToggleObjectsFunction);
        }
    }

    void ToggleObjectsFunction()
    {
        // เปิดใช้งานวัตถุ A
        if (objectA != null)
        {
            objectA.SetActive(true);
        }

        // ปิดใช้งานวัตถุ B
        if (objectB != null)
        {
            objectB.SetActive(false);
        }
    }
}
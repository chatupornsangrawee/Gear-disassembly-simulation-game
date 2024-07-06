using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOrderControll : MonoBehaviour
{
    public Button[] buttons; // ใส่ปุ่มทั้งหมดที่ต้องการในลำดับที่ถูกต้องใน Inspector

    private int currentButtonIndex = 0;

    void Start()
    {
        // ปิดใช้งานปุ่มทั้งหมดก่อน
        foreach (Button button in buttons)
        {
            button.interactable = false;
        }

        // เปิดใช้งานปุ่มแรก
        if (buttons.Length > 0)
        {
            buttons[0].interactable = true;
        }

        // เพิ่ม listener ให้กับปุ่มทั้งหมด
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // เก็บค่าของ i ไว้ในตัวแปร local เพื่อใช้ใน lambda expression
            buttons[i].onClick.AddListener(() => OnButtonClick(index));
        }
    }

    void OnButtonClick(int index)
    {
        // ปิดใช้งานปุ่มปัจจุบัน
        buttons[index].interactable = false;

        // เพิ่ม index ไปยังปุ่มถัดไป
        currentButtonIndex = index + 1;

        // ตรวจสอบว่ามีปุ่มถัดไปหรือไม่
        if (currentButtonIndex < buttons.Length)
        {
            // เปิดใช้งานปุ่มถัดไป
            buttons[currentButtonIndex].interactable = true;
        }
    }
}
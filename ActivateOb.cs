using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateOb : MonoBehaviour
{
    public GameObject objectToActivate; // วัตถุ A ที่จะเปิดใช้งาน
    public GameObject objectToDeactivate;  // วัตถุ B ที่จะปิดใช้งาน
    public Button activateButton;       // ปุ่มที่ใช้เรียกใช้การกระทำ

    void Start()
    {
        // ตรวจสอบว่า objectToActivate, objectToDeactivate และ activateButton ได้รับการกำหนดค่าแล้ว
        if (objectToActivate != null && objectToDeactivate != null && activateButton != null)
        {
            // ซ่อนวัตถุในตอนเริ่มต้น
            objectToActivate.SetActive(false);

            // เพิ่ม listener ให้กับปุ่มเพื่อเรียกใช้ฟังก์ชัน ActivateObjectA
            activateButton.onClick.AddListener(ActivateObjectA);
        }
        else
        {
            Debug.LogError("ObjectToActivate, ObjectToDeactivate หรือ ActivateButton ยังไม่ได้กำหนดค่า");
        }
    }

    void ActivateObjectA()
    {
        // เปิดใช้งานวัตถุ A
        objectToActivate.SetActive(true);

        // ปิดใช้งานวัตถุ B
        if (objectToDeactivate != null)
        {
            objectToDeactivate.SetActive(false);
        }
        else
        {
            Debug.LogError("ObjectToDeactivate ไม่มีใน scene หรือถูกกำหนดค่าเป็น null");
        }
    }
}
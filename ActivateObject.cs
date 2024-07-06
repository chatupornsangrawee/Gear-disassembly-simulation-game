using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    public GameObject player;  // ตัวละครผู้เล่น
    public GameObject S;       // วัตถุที่ต้องการเปิดใช้งาน
    public float activationDistance = 5.0f;  // ระยะทางที่ผู้เล่นต้องเข้ามาใกล้เพื่อเปิดใช้งาน

    // Update is called once per frame
    void Update()
    {
        // คำนวณระยะทางระหว่างผู้เล่นกับวัตถุ S
        float distance = Vector3.Distance(player.transform.position, S.transform.position);

        // ตรวจสอบว่าผู้เล่นอยู่ในระยะที่กำหนดหรือไม่
        if (distance <= activationDistance)
        {
            // เปิดใช้งานวัตถุ S
            S.SetActive(true);
        }
        else
        {
            // ปิดการใช้งานวัตถุ S
            S.SetActive(false);
        }
    }
}
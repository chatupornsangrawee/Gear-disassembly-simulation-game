using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // ความเร็วในการหมุน

    void Update()
    {
        // เช็คว่ามีการคลิ๊กขวาค้างหรือไม่
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X"); // การเคลื่อนที่ของเมาส์ในแนวนอน
            float mouseY = Input.GetAxis("Mouse Y"); // การเคลื่อนที่ของเมาส์ในแนวตั้ง

            // หมุนวัตถุรอบแกน Y
            transform.Rotate(Vector3.up, -mouseX * rotationSpeed * Time.deltaTime, Space.World);
            // หมุนวัตถุรอบแกน X
            transform.Rotate(Vector3.right, mouseY * rotationSpeed * Time.deltaTime, Space.World);
        }
    }
}
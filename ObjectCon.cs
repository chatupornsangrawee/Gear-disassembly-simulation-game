using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCon : MonoBehaviour
{
    public GameObject objectA; // วัตถุ A
    public GameObject objectB; // วัตถุ B
    private Vector3 initialPosition; // ตำแหน่งเริ่มต้นของวัตถุ A

    void Start()
    {
        // เก็บตำแหน่งเริ่มต้นของวัตถุ A
        if (objectA != null)
        {
            initialPosition = objectA.transform.position;
        }
        else
        {
            Debug.LogError("Object A is not assigned!");
        }

        // ทำให้แน่ใจว่าวัตถุ B ปิดใช้งานอยู่ตอนเริ่มเกม
        if (objectB != null)
        {
            objectB.SetActive(false);
        }
        else
        {
            Debug.LogError("Object B is not assigned!");
        }
    }

    void Update()
    {
        // ตรวจสอบว่ามีการเคลื่อนย้ายวัตถุ A หรือไม่
        if (objectA != null)
        {
            if (objectA.transform.position != initialPosition)
            {
                // ถ้าวัตถุ A ไม่อยู่ในตำแหน่งเริ่มต้น เปิดใช้งานวัตถุ B
                if (objectB != null && !objectB.activeSelf)
                {
                    objectB.SetActive(true);
                }
            }
            else
            {
                // ถ้าวัตถุ A กลับไปยังตำแหน่งเริ่มต้น ปิดใช้งานวัตถุ B
                if (objectB != null && objectB.activeSelf)
                {
                    objectB.SetActive(false);
                }
            }
        }

        // ตรวจสอบว่าถ้าวัตถุ A ถูกทำลาย ให้ทำลายวัตถุ B ด้วย
        if (objectA == null && objectB != null)
        {
            Destroy(objectB);
        }
    }
}
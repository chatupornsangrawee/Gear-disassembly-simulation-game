using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    // ลิสต์ของ GameObject ที่เก็บวัตถุ B ที่ต้องการทำลาย
    public List<GameObject> objectsToDestroy = new List<GameObject>();

    // ตัวแปร Public สำหรับเก็บวัตถุ SS
    public GameObject SS;

    // ฟังก์ชันที่เรียกเมื่อมีการคลิกที่วัตถุ A
    private void OnMouseDown()
    {
        // ตรวจสอบว่าวัตถุ SS ถูกเปิดใช้งานอยู่หรือไม่
        if (SS.activeInHierarchy)
        {
            // ถ้ามีวัตถุในลิสต์ objectsToDestroy
            if (objectsToDestroy.Count > 0)
            {
                // ดึงวัตถุ B ที่ต้องการทำลายออกมาจากลิสต์
                GameObject objectB = objectsToDestroy[0];

                // ทำลายวัตถุ B ที่อยู่ในลำดับแรกของลิสต์
                Destroy(objectB);

                // ลบวัตถุ B ที่ถูกทำลายออกจากลิสต์
                objectsToDestroy.RemoveAt(0);
            }
        }
    }
}
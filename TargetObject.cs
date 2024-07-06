using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetObject : MonoBehaviour
{
    // ลำดับการชนที่ถูกต้อง
    public List<string> correctCollisionOrder;
    private int currentCollisionIndex = 0;

    // ฟังก์ชันนี้จะถูกเรียกเมื่อมีวัตถุอื่นมาชน
    void OnCollisionEnter(Collision collision)
    {
        // ตรวจสอบชื่อของวัตถุที่มาชน
        if (collision.gameObject.name == correctCollisionOrder[currentCollisionIndex])
        {
            // ทำลายวัตถุที่มาชนถ้าลำดับถูกต้อง
            Destroy(collision.gameObject);
            currentCollisionIndex++;

            // ถ้าชนครบทุกลำดับแล้วก็รีเซ็ตลำดับการชนใหม่
            if (currentCollisionIndex >= correctCollisionOrder.Count)
            {
                currentCollisionIndex = 0;
            }
        }
        else
        {
            // ถ้าลำดับไม่ถูกต้องให้ทำอย่างอื่น (เช่น แสดงข้อความ หรือไม่ทำอะไร)
            Debug.Log("ชนไม่ตรงลำดับที่กำหนด");
        }
    }
}
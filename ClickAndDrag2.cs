using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag2 : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private bool isDragging = false;
    public Transform targetTransform; // วัตถุ A ที่เราจะย้ายไป

    void OnMouseDown()
    {
        originalPosition = transform.position; // เก็บตำแหน่งเริ่มต้น
        originalRotation = transform.rotation; // เก็บการหมุนเริ่มต้น
        isDragging = true; // กำหนดให้กำลังลาก
    }

    void OnMouseUp()
    {
        // กลับไปยังตำแหน่งและการหมุนเริ่มต้น
        transform.position = originalPosition;
        transform.rotation = originalRotation;
        isDragging = false; // ไม่ได้ลากแล้ว
    }

    void Update()
    {
        if (targetTransform != null && isDragging)
        {
            // ย้ายตำแหน่งของ B ไปยังตำแหน่งของ A ทุกครั้งที่ A เปลี่ยนแปลง
            transform.position = targetTransform.position;
            transform.rotation = targetTransform.rotation;
        }
    }
}
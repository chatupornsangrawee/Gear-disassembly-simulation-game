using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private float zCoord;
    private Vector3 originalPosition;
    private bool isDragging = false;

    void OnMouseDown()
    {
        zCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        screenPoint = gameObject.transform.position;
        offset = gameObject.transform.position - GetMouseWorldPos();
        originalPosition = transform.position; // เก็บตำแหน่งเริ่มต้น
        isDragging = true; // กำหนดให้กำลังลาก
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 targetPos = GetMouseWorldPos() + offset;
            targetPos.x = originalPosition.x; // คงค่าแกน X
            targetPos.y = originalPosition.y; // คงค่าแกน Y

            // จำกัดการเคลื่อนที่ในแกน Z ให้อยู่ระหว่าง 8.0 ถึง 9.1
            targetPos.z = Mathf.Clamp(targetPos.z, 8.0f, 9.5f);

            transform.position = targetPos;
        }
    }

    void OnMouseUp()
    {
        // กลับไปยังตำแหน่งเริ่มต้น
        transform.position = originalPosition;
        isDragging = false; // ไม่ได้ลากแล้ว
    }
}
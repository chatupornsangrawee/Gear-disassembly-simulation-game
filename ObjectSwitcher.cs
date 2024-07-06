using UnityEngine;

public class ObjectSwitcher : MonoBehaviour
{
    // ประกาศตัวแปร public สำหรับวัตถุ A และ B
    public GameObject objectA;
    public GameObject objectB;

    void Start()
    {
        // ตรวจสอบว่าตัวแปร objectA และ objectB ถูกตั้งค่าหรือไม่
        if (objectA == null)
        {
            Debug.LogError("objectA ไม่ได้ถูกตั้งค่าใน Inspector!");
        }
        if (objectB == null)
        {
            Debug.LogError("objectB ไม่ได้ถูกตั้งค่าใน Inspector!");
        }
    }

    void OnMouseDown()
    {
        // ตรวจสอบว่ามีการคลิกซ้ายเมาส์หรือไม่
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("คลิกซ้ายเมาส์ถูกตรวจจับบนวัตถุเป้าหมาย");

            // ตรวจสอบ objectA และ objectB อีกครั้งก่อนทำการเปลี่ยนแปลงสถานะ
            if (objectA != null && objectB != null)
            {
                // เปิดใช้งานวัตถุ A
                objectA.SetActive(true);
                Debug.Log("เปิดใช้งาน objectA");

                // ปิดใช้งานวัตถุ B
                objectB.SetActive(false);
                Debug.Log("ปิดใช้งาน objectB");
            }
            else
            {
                Debug.LogError("objectA หรือ objectB ไม่ได้ถูกตั้งค่าใน Inspector!");
            }
        }
    }
}

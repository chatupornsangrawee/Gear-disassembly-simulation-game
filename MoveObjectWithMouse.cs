using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObjectWithMouse : MonoBehaviour
{
    public Texture2D newCursorTexture; // รูปภาพ cursor ที่ต้องการใช้เป็นใหม่
    public Button changeCursorButton; // ปุ่ม UI ที่จะใช้เปลี่ยน cursor
    public GameObject objectB; // วัตถุ B ที่จะใช้เปิด/ปิด

    private bool objectBEnabled = false;
    private Texture2D defaultCursorTexture; // เก็บรูปภาพ cursor เริ่มต้นของ Unity

    void Start()
    {
        // เชื่อมโยงการกดปุ่ม UI กับฟังก์ชันเปลี่ยน cursor
        changeCursorButton.onClick.AddListener(ChangeMouseCursor);

        // เก็บรูปภาพ cursor เริ่มต้นของ Unity
        defaultCursorTexture = Resources.Load<Texture2D>("Cursors/default_cursor");

        // เชื่อมโยงการเปิด/ปิด วัตถุ B กับการเปลี่ยน cursor เมื่อถูกเปิด
        objectB.SetActive(objectBEnabled);
    }

    void Update()
    {
        // ตรวจสอบว่าวัตถุ B ถูกเปิดหรือไม่
        if (objectB.activeSelf && !objectBEnabled)
        {
            // เปลี่ยน cursor เมาส์เป็นรูปที่กำหนดเมื่อวัตถุ B ถูกเปิด
            Cursor.SetCursor(newCursorTexture, Vector2.zero, CursorMode.Auto);
            objectBEnabled = true;
        }
        else if (!objectB.activeSelf && objectBEnabled)
        {
            // เปลี่ยน cursor เมาส์กลับเป็นรูปเริ่มต้นเมื่อวัตถุ B ถูกปิด
            Cursor.SetCursor(defaultCursorTexture, Vector2.zero, CursorMode.Auto);
            objectBEnabled = false;
        }
    }

    void ChangeMouseCursor()
    {
        // เปลี่ยน cursor เมาส์เป็นรูปที่กำหนด
        Cursor.SetCursor(newCursorTexture, Vector2.zero, CursorMode.Auto);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    void Start()
    {
        // ถ้าปุ่มถูกแนบกับสคริปต์นี้ ให้เพิ่มการคลิกฟังชัน
        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(QuitGame);
        }
    }

    void QuitGame()
    {
        // ออกจากแอปพลิเคชัน
        Application.Quit();

        // ถ้าอยู่ในโหมดการพัฒนา (เช่น ใน Editor ของ Unity) ให้หยุดการเล่น
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad;

    void Start()
    {
        // ถ้าปุ่มถูกแนบกับสคริปต์นี้ ให้เพิ่มการคลิกฟังชัน
        Button btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(ChangeScene);
        }
    }

    public void ChangeScene()
    {
        // โหลดฉากที่กำหนด
        SceneManager.LoadScene(sceneToLoad);
    }
}
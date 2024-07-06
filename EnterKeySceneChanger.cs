using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterKeySceneChanger : MonoBehaviour
{
    public string sceneToLoad;

    void Update()
    {
        // ตรวจสอบการกดปุ่ม Enter (Return)
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // โหลดฉากที่กำหนด
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
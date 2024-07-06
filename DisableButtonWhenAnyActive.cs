using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButtonWhenAnyActive : MonoBehaviour
{
    public GameObject[] objectsA; // วัตถุ A หลายชิ้นที่ต้องการตรวจสอบ
    public Button targetButton; // ปุ่ม UI ที่ต้องการปิดการทำงาน

    void Update()
    {
        bool anyActive = false;
        
        foreach (GameObject obj in objectsA)
        {
            if (obj.activeInHierarchy)
            {
                anyActive = true;
                break;
            }
        }

        targetButton.interactable = !anyActive;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public string targetTag = "01"; // กำหนด tag ของวัตถุที่ต้องการให้ถูกทำลาย

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag(targetTag))
        {
            Debug.Log("Destroying object with tag: " + targetTag);
            Destroy(collision.gameObject);
            Destroy(gameObject); // ทำลายวัตถุที่มี script นี้
        }
    }
}
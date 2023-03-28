using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving : MonoBehaviour
{
    public float speed = 1.0f; // Hızı değiştirmek için kullanılacak değişken

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // A, D veya sol ok ve sağ ok tuşlarının değerini alır
        float verticalInput = Input.GetAxis("Vertical"); // W, S veya yukarı ok ve aşağı ok tuşlarının değerini alır

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput); // Girişleri yön vektörü olarak birleştirir

        transform.Translate(direction * speed * Time.deltaTime); // Yön vektörüne hızı ve zaman farkını ekleyerek hareketi uygular
    }
}

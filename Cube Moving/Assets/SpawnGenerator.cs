using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGenerator : MonoBehaviour
{
    public GameObject objectToSpawn; // Oluşturulacak nesnenin prefab'ı

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // Sol fare düğmesine basıldıysa
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10; // Kameranın ileri doğru 10 birim uzaklığına 3 boyutlu bir vektör oluşturur
            Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(mousePos); // Fare pozisyonunu dünya koordinatlarına dönüştürür

            spawnPosition.y = 0; // Y pozisyonunu sıfırlar
            Instantiate(objectToSpawn, spawnPosition, Quaternion.identity); // Nesneyi oluşturur
        }
    }
}

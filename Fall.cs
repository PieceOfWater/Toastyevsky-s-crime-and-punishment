using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public GameObject spawnObject;
    private bool isSpawning = false;
    private int scaleColliderCount = 9;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);
            if (hitCollider != null && hitCollider.CompareTag("Scale"))
            {
                SpawnObject(hitCollider.transform.position);
                scaleColliderCount--;
                if (scaleColliderCount <= 0)
                {
                    Debug.Log("All scale colliders clicked");
                }
            }
        }
    }

    void SpawnObject(Vector3 position)
    {
        if (!isSpawning)
        {
            isSpawning = true;
            GameObject newObject = Instantiate(spawnObject, position, Quaternion.identity);
            newObject.SetActive(true);
            isSpawning = false;
        }
    }
}
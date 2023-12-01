using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject door;
    
    void OnMouseDown()
    {
        door.SetActive(true);
        Destroy(this.gameObject);
    }
}

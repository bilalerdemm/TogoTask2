using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableController : MonoBehaviour
{
    public static TableController instance;
    public Transform spawnPoint;

    private void Awake()
    {
        instance = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CollectTable")
        {
            Debug.Log("Toplanabilir.");
            
        }
        if (other.gameObject.tag == "CompareTable")
        {
            Debug.Log("Karsilastirilabilir.");
        }

    }
}

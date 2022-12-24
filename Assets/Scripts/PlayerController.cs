using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public GameObject collectPoint;
    public int maxChildCount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueTable"))
        {
            Debug.Log("Blue Table");

            int childCount = Random.Range(1, maxChildCount);
            maxChildCount -= maxChildCount;
            other.gameObject.transform.GetChild(childCount).transform.parent = transform;
        }

        if (other.gameObject.CompareTag("GreenTable"))
        {
            transform.GetChild(2).transform.parent = other.gameObject.transform;
        }

        if (other.gameObject.CompareTag("RedTable"))
        {
            transform.GetChild(2).transform.parent = other.gameObject.transform;
        }

    }
}

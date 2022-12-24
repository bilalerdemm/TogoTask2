using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject collectPoint;
    public int maxChildCount;
    public SkinnedMeshRenderer playerMesh;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BlueTable"))
        {
            Debug.Log("Blue Table");

            int childCount = Random.Range(1, maxChildCount);
            maxChildCount -= maxChildCount;
            if (this.transform.childCount < 4)
            {
                playerMesh.material.color = other.gameObject.transform.GetChild(childCount).GetComponent<MeshRenderer>().material.color;
                other.gameObject.transform.GetChild(childCount).transform.parent = transform;
                this.transform.GetChild(3).transform.position = collectPoint.transform.position;
            }


        }
        if (transform.childCount==4)
        {


            if (other.gameObject.CompareTag("GreenTable"))
            {
                transform.GetChild(3).transform.parent = other.gameObject.transform;

            }

            if (other.gameObject.CompareTag("RedTable"))
            {
                transform.GetChild(3).transform.parent = other.gameObject.transform;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMatCol : MonoBehaviour
{
    [SerializeField] private Material myMat;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            myMat.color = Color.red;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myMat.color = Color.green;
        }
    }

}

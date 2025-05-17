using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskObject : MonoBehaviour
{
    [Header("put on mask obj with mask material and put obj to mask in objmasked")]
    public GameObject[] ObjMasked;
    void Start()
    {
        for (int i = 0; i < ObjMasked.Length; i++)
        {
            ObjMasked[i].GetComponent<MeshRenderer>().material.renderQueue = 3002;
        }
        Destroy(this);
    }

}


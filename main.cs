using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Loading Now");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0.01f, 0, 0);
    }
} 

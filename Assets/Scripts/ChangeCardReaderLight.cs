using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCardReaderLight : MonoBehaviour
{
    public Collider handleCollider;
    Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.name == "Card")
        {
            lt.color = Color.green;
            transform.GetComponent<Renderer>().material.color= Color.green;
            handleCollider.enabled = true;
        }
    }
}

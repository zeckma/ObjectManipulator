using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    public float speedRotate;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speedRotate * Time.deltaTime, 0);
    }

 
}

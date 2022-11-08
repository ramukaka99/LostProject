using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject GameObj;
    public Transform trans;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(GameObj, trans.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

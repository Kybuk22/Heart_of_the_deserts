using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptbackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        transform.position=new Vector3(0.1f*pos.x,0.1f*pos.y,1f);
    }
}

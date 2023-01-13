using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapChangingScript : MonoBehaviour
{

    // Start is called before the first frame update
    IEnumerator Start()
    {
        var sr = GetComponent<SpriteRenderer>();
        for (float i = 1f; i > 0f; i=i-0.1f)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, i);
            yield return new WaitForSeconds(0.1f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

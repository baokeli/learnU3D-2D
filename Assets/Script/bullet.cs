using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0,0.1f,0);
        Vector3 v3 = Camera.main.WorldToScreenPoint(transform.position);
        if(v3.y > Screen.height)
        {
            Destroy(this.gameObject);
        }
    }
}

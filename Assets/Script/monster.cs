using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    public int maxHP = 5;
    int HP = 5;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "bullet")
        {
            Destroy(collider.gameObject);
            if(--HP == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

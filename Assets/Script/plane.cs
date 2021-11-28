using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public GameObject bulletFB;
    float dtTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseV3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y,1);
        transform.position = Camera.main.ScreenToWorldPoint(CheckV3InScreen(mouseV3));

        dtTime += Time.deltaTime;
        if(dtTime > 0.1)
        {
            GameObject bullet = Instantiate(bulletFB);
            bullet.transform.position = transform.position + new Vector3(0, 1, 0);
            dtTime = 0;
        }
    }

    Vector3 CheckV3InScreen(Vector3 v3)
    {
        Vector3 retV3 = new Vector3(v3.x,v3.y,v3.z);

        if (retV3.x > Screen.width)
            retV3.x = Screen.width;
        else if (retV3.x < 0)
            retV3.x = 0;

        if (retV3.y > Screen.height)
            retV3.y = Screen.height;
        else if (retV3.y < 0)
            retV3.y = 0;

        return retV3;
    }
}

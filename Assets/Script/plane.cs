using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    public GameObject guai = null;
    public int mysize = 10;
    // Start is called before the first frame update
    void Start()
    {
        guai = GameObject.Find("/π÷ŒÔ_4");
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        guai.transform.Translate(0.01f, 0, 0);
        transform.Translate(0, 0.01f, 0);
    }
}

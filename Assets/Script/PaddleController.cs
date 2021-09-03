using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float kecepatan;
    public float batasAtas;
    public float batasBawah;
    public string axis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float gerak1 = Input.GetAxis(axis) * kecepatan * Time.deltaTime;
        float nextPos1 = transform.position.y + gerak1;
        if (nextPos1 > batasAtas)
        {
            gerak1 = 0;
        }
        if (nextPos1 < batasBawah)
        {
            gerak1 = 0;
        }
        transform.Translate(0, gerak1, 0);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float rho = 28;
    public float beta = 8/3;
    public float sigma = 10;
    public float timeScale = 10000;
    public float scale = 0.1F;
    public float x;
    public float y;
    public float z;
    float dxdt;
    float dydt;
    float dzdt;
    public TrailRenderer trail;
    float e = 2.7182818f;

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x / scale;
        y = transform.position.y / scale;
        z = transform.position.z / scale;

        dxdt = sigma * (y - x);
        dydt = (x * (rho - z)) - y;
        dzdt = (x * y) - (beta * z);

        transform.position += new Vector3(dxdt*Time.deltaTime/timeScale, dydt*Time.deltaTime/timeScale, dzdt*Time.deltaTime/timeScale);

        trail.startColor = new Color(0f, 1f - (1f / Mathf.Log(0.2f*(Mathf.Abs(dxdt) + Mathf.Abs(dydt) + e))), 1f);
        trail.endColor = new Color(1f, 1f - (1f / Mathf.Log(0.2f*(Mathf.Abs(dxdt) + Mathf.Abs(dydt) + e))), 0f);
    }
}

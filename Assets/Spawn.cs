using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform circle;
    public int number = 100;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < number + 1; i++)
        {
            Transform point = Instantiate(circle, new Vector3(10F*i/number, 0, 0), Quaternion.identity);
            point.name = i.ToString();
        }
    }


}

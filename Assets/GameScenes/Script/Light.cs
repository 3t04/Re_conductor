using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    [SerializeField] private float Speed = 3;
    [SerializeField] private int num = 0;
    private Renderer rend;
    private float alfa = 0;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {

        if (!(rend.material.color.a <= 0))
        {
            rend.material.color = new Color(rend.material.color.r, rend.material.color.r, rend.material.color.r, alfa);
        }

        if (num == 1)
        {
            if (Input.GetKeyDown(KeyCode.d))
            {
                colorChange();
            }
        }
        if (num == 2)
        {
            if (Input.GetKeyDown(KeyCode.f))
            {
                colorChange();
            }
        }
        if (num == 3)
        {
            if (Input.GetKeyDown(KeyCode.j))
            {
                colorChange();
            }
        }
        if (num == 4)
        {
            if (Input.GetKeyDown(KeyCode.k))
            {
                colorChange();
            }
        }
        alfa -= Speed * Time.deltaTime;
    }

    void colorChange()
    {
        alfa = 0.3f;
        rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b,alfa);
    }
}

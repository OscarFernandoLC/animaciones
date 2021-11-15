using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionAnimImportSettings : MonoBehaviour
{
Animator anim;
    public float velocidad = 0f;
    public float aceleracion = 0.1f;
    public float desaceleracion = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool moverseoprimido = Input.GetKey("w");
        bool dispararoprimido = Input.GetKey("o");

        if(moverseoprimido && velocidad < 1.0f)
        {
            velocidad += Time.deltaTime * aceleracion;
        }
        if(!moverseoprimido && velocidad > 0.0f)
        {
            velocidad -= Time.deltaTime * desaceleracion;
        }
        if(!moverseoprimido && velocidad < 0.0f)
        {
            velocidad = 0.0f;
        }

        anim.SetFloat("velocidad", velocidad);

    }
}
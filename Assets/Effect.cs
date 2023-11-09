using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class Effect : MonoBehaviour
{
    public StudioEventEmitter effectEmitter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) effectEmitter.Play();
    }
}

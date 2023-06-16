using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public bool isChecked = false;
    private CHeckpointManager CHeckpointManager;

    private void Start()
    {
        CHeckpointManager = GameObject.FindObjectOfType<CHeckpointManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        isChecked = true;
    }

    public void Reset()
    {
        isChecked = false;
    }
}

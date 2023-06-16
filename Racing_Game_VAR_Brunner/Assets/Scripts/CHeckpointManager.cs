using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHeckpointManager : MonoBehaviour
{
    private Checkpoints[] checkpoints;

    // Start is called before the first frame update
    void Start()
    {
        checkpoints = GameObject.FindObjectsOfType<Checkpoints>();
    }

    public void OnCheckpointTrigger()
    {

    }

    private bool CheckIfAllCheckpointsHit()
    {
        foreach(Checkpoints checkpoint in checkpoints)
        {
            if(!checkpoint.isChecked)
            {
                return false;
            }
        }
        return true;
    }

    private void ResetCheckpoints()
    {
        foreach (Checkpoints checkpoint in checkpoints)
        {
            checkpoint.Reset();
        }

    }
    

}

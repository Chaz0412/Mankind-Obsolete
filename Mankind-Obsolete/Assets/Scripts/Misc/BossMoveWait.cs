using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoveWait : MonoBehaviour
{
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count < 40)
        {
            count++;
        }
        else if(count >= 40)
        {
            Destroy(gameObject);
        }
    }
}

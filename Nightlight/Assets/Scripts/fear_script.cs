using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fear_script : MonoBehaviour
{
    [Range(0, 1000)]
    public int fear = 1000;
    public bool isTouchingLight;

    public Vector3 respawn;

    private void Start()
    {
        respawn = new Vector3(0f, 0f);
        Debug.Log("boi");
    }

    private void Update()
    {
        if (isTouchingLight && fear < 1000)
        {
            fear += 5;
        }
        else if (!isTouchingLight && fear > 0)
        {
            fear --;
        }

        if (fear == 0 && !isTouchingLight)
        {
            gameObject.transform.position = respawn;
            Debug.Log("boi2 electric boogaloo");
        }
    }
}

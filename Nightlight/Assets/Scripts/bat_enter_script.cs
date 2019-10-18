using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat_enter_script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<fear_script>().isTouchingLight = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        other.GetComponent<fear_script>().isTouchingLight = false;
    }
}

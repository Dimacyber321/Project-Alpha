using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PATH : MonoBehaviour
{
    private void onDrawGizmos()
    {
        foreach(Transform t in transform)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(t.position, 1f);
        }
        Gizmos.color = Color.red;
    }
}

using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int _numberOfBumps=0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag!="Hit"){
        _numberOfBumps++;
        Debug.Log("bumps == " + _numberOfBumps.ToString());
        }
    }
}

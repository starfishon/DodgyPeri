using UnityEngine;

public class RotateME : MonoBehaviour
{
    [SerializeField] float axisX;
    [SerializeField] float axisy;
    [SerializeField] float axisz;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(axisX* Time.deltaTime,axisy* Time.deltaTime,axisz* Time.deltaTime));
        
    }
}

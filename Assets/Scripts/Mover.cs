using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float _movemnetSpeed=1f;
    float _xValue,_yValue,_zValue;
    
    void Start()
    {

     //   transform.Translate(transform.position.x+1,transform.position.y,transform.position.z+1);
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime;  
        _xValue=Input.GetAxis("Horizontal") * delta * _movemnetSpeed;
        _yValue=0;
        _zValue=Input.GetAxis("Vertical") * delta * _movemnetSpeed ;
        transform.Translate(_xValue,_yValue,_zValue);
        
    }
}

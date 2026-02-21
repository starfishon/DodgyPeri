using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float _movemnetSpeed=1f;
    float _xValue,_yValue,_zValue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    
    }



    void MovePlayer()
    {
        float delta = Time.deltaTime;  
        _xValue=Input.GetAxis("Horizontal") * delta * _movemnetSpeed;
        _yValue=0;
        _zValue=Input.GetAxis("Vertical") * delta * _movemnetSpeed ;
        transform.Translate(_xValue,_yValue,_zValue);
    }



}

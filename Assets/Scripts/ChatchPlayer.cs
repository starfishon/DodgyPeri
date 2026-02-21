using UnityEngine;

public class ChatchPlayer : MonoBehaviour
{
    [SerializeField] GameObject _player;
    [SerializeField] public float _speed=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        /*
        float axisX = Mathf.MoveTowards(transform.position.x,_player.transform.position.x,_speed);
        float axisy = Mathf.MoveTowards(transform.position.y,_player.transform.position.y,_speed);
        float axisz = Mathf.MoveTowards(transform.position.z,_player.transform.position.z,_speed);
        transform.position = new Vector3(axisX,axisy,axisz);
        */

        transform.position =Vector3.MoveTowards(transform.position,_player.transform.position,_speed * Time.deltaTime);

        if (transform.position==_player.transform.position) Destroy(gameObject);
        
    }
}

using UnityEngine;

public class TimeChecker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] float _StartTime=0;
    [SerializeField] float _WaitTime=5;

    MeshRenderer _myMesh;
    Rigidbody _myRigidBody;
    void Start()
    {
        _myMesh = GetComponent<MeshRenderer>();
        _myRigidBody = GetComponent<Rigidbody>();

        _myRigidBody.useGravity = false;
        _myMesh.enabled = false;

      //  _StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {   
        float currentTime =Time.time;
      //  Debug.Log($"gling glong {_StartTime} {currentTime}");
        if (currentTime - _StartTime >= _WaitTime)
        {
            _myRigidBody.useGravity = true;
            _myMesh.enabled = true;
            Debug.Log($"gling glong {_StartTime} {currentTime}");
            _StartTime = currentTime;
        }
    }
}

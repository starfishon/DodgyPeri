using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
        MeshRenderer _mesh = GetComponent<MeshRenderer>();
        Color color;
        ColorUtility.TryParseHtmlString("#3b0e4d", out color);
        
        _mesh.material.color = color;
        Debug.Log("wall collision");
        _mesh.gameObject.tag = "Hit";

        }

    }

    void OnTriggerEnter(Collider other)
    {
        ChatchPlayer[] balls = FindObjectsByType<ChatchPlayer>(FindObjectsSortMode.None);

        foreach (ChatchPlayer ball in balls)
        {
            ball._speed = 20f;
        }
        Destroy(gameObject);
    }

}

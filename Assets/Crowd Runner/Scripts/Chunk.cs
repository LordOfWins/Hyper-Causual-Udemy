using UnityEngine;

public class Chunk : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Chunk Settings")]
    [SerializeField] private Vector3 chunkSize;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public float GetChunkSize()
    {
        return chunkSize.z;
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position, chunkSize);
    }
}

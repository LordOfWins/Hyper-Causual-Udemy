using UnityEngine;

public class CrowdSystem : MonoBehaviour
{

    [Header("Elements")]
    [SerializeField] private Transform runnerPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Crowd System")]
    [SerializeField] private float radius = 1f;
    [SerializeField] private float angle = 137.508f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlaceRunners();
    }
    private void PlaceRunners()
    {
        for (int i = 0; i < runnerPrefab.childCount; i++)
        {
            Vector3 childLocalPosition = GetChildLocalPosition(i);
            runnerPrefab.GetChild(i).localPosition = childLocalPosition;
        }
    }
    private Vector3 GetChildLocalPosition(int index) // 상세한 설명:
    {
        float x = radius * Mathf.Sqrt(index) * Mathf.Cos(Mathf.Deg2Rad * index * angle); //설명: 반지름 * 인덱스의 제곱근 * 인덱스 * 각도
        float z = radius * Mathf.Sqrt(index) * Mathf.Sin(Mathf.Deg2Rad * index * angle); //설명: 반지름 * 인덱스의 제곱근 * 인덱스 * 각도
        return new Vector3(x, 0, z);
    }
}

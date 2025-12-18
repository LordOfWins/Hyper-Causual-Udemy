using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("Element Settings")]
    [SerializeField] private CrowdSystem crowdSystem;
    [SerializeField] private ChunkManager chunkManager;

    [Header("Player Settings")]
    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Header("Control Settings")]
    [SerializeField] private float slideSpeed;
    private Vector3 clickedScreenPosition;
    private Vector3 clickedPlayerPosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        ManageControl();
    }

    private void MoveForward()
    {

        transform.position += new Vector3(0, 0, 1) * Time.deltaTime * speed;

    }

    private void ManageControl()
    {
        if (Input.GetMouseButtonDown(0)) //만약 마우스 왼쪽 버튼이 눌렸다면
        {
            //마우스의 이동량을 구한다.
            clickedScreenPosition = Input.mousePosition;
            clickedPlayerPosition = transform.position;
        }
        else if (Input.GetMouseButton(0)) //만약 마우스 왼쪽 버튼이 눌려져 있다면
        {
            float xScreenDifference = Input.mousePosition.x - clickedScreenPosition.x;

            xScreenDifference /= Screen.width;
            xScreenDifference *= slideSpeed;

            Vector3 position = transform.position;
            position.x = clickedPlayerPosition.x + xScreenDifference;
            //참가자 청크의 이동 범위 제한(청크의 반지름 최대 범위)
            position.x = Mathf.Clamp(position.x, -chunkManager.GetChunkWidth()/2+crowdSystem.GetRadius(), chunkManager.GetChunkWidth()/2-crowdSystem.GetRadius());
            transform.position = position;
            // transform.position = clickedPlayerPosition + Vector3.right * xScreenDifference;
        }



    }
}

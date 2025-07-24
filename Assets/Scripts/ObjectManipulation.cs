using UnityEngine;

public class ObjectManipulation : MonoBehaviour
{
    // ���ű�������
    public float MinScale = 0.2f;
    public float MaxScale = 3.0f;
    // ��������
    private float scaleRate = 1f;
    // �³ߴ�
    private float newScale;

    // ����
    private Ray ray;
    private RaycastHit hitInfo;

    private bool isDragging = false;
    private Vector3 offset;

    // ��ת
    private float rotationSpeed = 5.0f;

    private void OnMouseDown()
    {
        isDragging = true;
        offset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {
        // ��ק
        if (isDragging)
        {
            Vector3 newPosition = GetMouseWorldPosition() + offset;
            transform.position = newPosition;
        }

        // ��ת
        if (Input.GetMouseButton(1))
        {
            float mousX = Input.GetAxis("Mouse X");
            float mousY = Input.GetAxis("Mouse Y");
            transform.Rotate(mousY * rotationSpeed, -mousX * rotationSpeed, 0, Space.World);
        }

        // ����
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                newScale += Input.GetAxis("Mouse ScrollWheel") * scaleRate;
                newScale = Mathf.Clamp(newScale, MinScale, MaxScale);
                transform.localScale = new Vector3(newScale, newScale, newScale);
            }
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}

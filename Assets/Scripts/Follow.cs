using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 offsetView;

    private void Update()
    {
        if (target == null)
        {
            return;
        }

        FollowView();
    }

    private void FollowView()
    {
        float x = target.eulerAngles.x;
        float y = target.eulerAngles.y;
        float z = target.eulerAngles.z;

        Quaternion rotation = Quaternion.Euler(x + offsetView.x, y + offsetView.y, z + offsetView.z);

        transform.rotation = rotation;
    }
}

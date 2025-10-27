using System.Collections;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    private IEnumerator Start()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                target.SetActive(true);

                yield break;
            }

            yield return null;
        }
    }
}

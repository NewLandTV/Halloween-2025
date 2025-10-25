using System.Collections;
using System.Text;
using TMPro;
using UnityEngine;

public class TalkUI : MonoBehaviour
{
    [SerializeField]
    private GameObject backgroundImage;
    [SerializeField]
    private TextMeshProUGUI messageText;
    [SerializeField]
    private float characterPerSecond = 10f;

    private Coroutine talkRoutine;

    private WaitForSeconds cps;

    private void Awake() => cps = new WaitForSeconds(1f / characterPerSecond);

    private void OnValidate() => Awake();

    public void Show(string message)
    {
        if (!backgroundImage.activeSelf)
        {
            backgroundImage.SetActive(true);
        }

        if (talkRoutine != null)
        {
            StopCoroutine(talkRoutine);
        }

        talkRoutine = StartCoroutine(TalkProcess(message));
    }

    public void HIde()
    {
        backgroundImage.SetActive(false);

        messageText.text = string.Empty;
    }

    private IEnumerator TalkProcess(string message)
    {
        messageText.text = string.Empty;

        StringBuilder text = new StringBuilder(message.Length);

        for (int i = 0; i < message.Length; i++)
        {
            text.Append(message[i]);

            messageText.text = text.ToString();

            yield return cps;
        }
    }
}

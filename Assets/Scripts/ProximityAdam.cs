using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityAdam : MonoBehaviour
{
    [SerializeField] private GameObject FoundAdamMessage;
    [SerializeField] private GameObject Step1Popup;

    // Start is called before the first frame update
    void Start()
    {
        if (FoundAdamMessage != null)
        {
            FoundAdamMessage.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Optional: You can remove this method if unused
    }

   private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Body"))
        {
            if (FoundAdamMessage != null)
            {
                FoundAdamMessage.SetActive(true);
                StartCoroutine(HideAfterSeconds(5f));
            }
        }
    }

    private IEnumerator HideAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        FoundAdamMessage.SetActive(false);
        Step1Popup.SetActive(true);
    }
}

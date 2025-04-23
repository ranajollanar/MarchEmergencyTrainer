using UnityEngine;
using UnityEngine.UI;

public class FoundAdam : MonoBehaviour
{
    private Image warningImage;
    private float fadeSpeed = 2f;
    private float alpha = 1f;
    private bool fadingOut = true;

    void Start()
    {
        warningImage = GetComponent<Image>();

        if (warningImage == null)
        {
            Debug.LogError("Image component not found on children.");
        }
    }

    void Update()
    {
        // Warning fade effect
        if (warningImage != null)
        {
            Color currentColor = warningImage.color;

            if (fadingOut)
            {
                alpha -= Time.deltaTime * fadeSpeed;
                if (alpha <= 0.3f)
                {
                    alpha = 0.3f;
                    fadingOut = false;
                }
            }
            else
            {
                alpha += Time.deltaTime * fadeSpeed;
                if (alpha >= 1f)
                {
                    alpha = 1f;
                    fadingOut = true;
                }
            }

            currentColor.a = alpha;
            warningImage.color = currentColor;
        }
    }
}

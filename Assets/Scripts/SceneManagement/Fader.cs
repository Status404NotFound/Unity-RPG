using System.Collections;
using UnityEngine;

namespace RPG.SceneManagement
{
    public class Fader : MonoBehaviour
    {
        CanvasGroup convasGroup;

        private void Start()
        {
            convasGroup = GetComponent<CanvasGroup>();
        }

        public IEnumerator FadeOut(float time)
        {
            while (convasGroup.alpha < 1)
            {
                convasGroup.alpha += Time.deltaTime / time;
                yield return null;
            }
        }

        public IEnumerator FadeIn(float time)
        {
            while (convasGroup.alpha > 0)
            {
                convasGroup.alpha -= Time.deltaTime / time;
                yield return null;
            }
        }
    }
}

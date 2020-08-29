using RPG.Saving;
using System.Collections;
using UnityEngine;

namespace RPG.SceneManagement
{
    public class SavingWrraper : MonoBehaviour
    {
        const string defaultSaveFile = "quicksave";

        [SerializeField] float fadeInTime;

        private IEnumerator Start()
        {
            Fader fader = FindObjectOfType<Fader>();

            fader.FadeOutImmediate();
            yield return GetComponent<SavingSystem>().LoadLastScene(defaultSaveFile);
            yield return fader.FadeIn(fadeInTime);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F5))
            {
                Save();
            }
            if (Input.GetKeyDown(KeyCode.F6))
            {
                Load();
            }
        }

        public void Load()
        {
            GetComponent<SavingSystem>().Load(defaultSaveFile);
        }

        public void Save()
        {
            GetComponent<SavingSystem>().Save(defaultSaveFile);
        }
    }
}

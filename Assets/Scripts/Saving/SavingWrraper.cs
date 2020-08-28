using UnityEngine;

namespace RPG.Saving
{
    public class SavingWrraper : MonoBehaviour
    {
        const string defaultSaveFile = "quicksave";

        private void Start()
        {
            Load();
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

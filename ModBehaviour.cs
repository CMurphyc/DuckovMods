using System;
using UnityEngine;
using Duckov;
using Duckov.Utilities;
using UnityEngine.UI;
using TMPro;
namespace DuckovMods
{
    public class ModBehaviour : Duckov.Modding.ModBehaviour
    {
        private TextMeshProUGUI? loadMessage;
        public TextMeshProUGUI LoadMessage
        {
            get
            {
                if (loadMessage == null)
                {
                    loadMessage = Instantiate(GameplayDataSettings.UIStyle.TemplateTextUGUI);
                }
                return loadMessage;
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                Debug.Log("Alt Key Down");
                LoadMessage.SetText("Mod Has Loaded!");
            }

            if (Input.GetKeyUp(KeyCode.LeftAlt))
            {
                Debug.Log("Alt Key Up");
                GameObject.Destroy(loadMessage);
            }
        }
    }
}

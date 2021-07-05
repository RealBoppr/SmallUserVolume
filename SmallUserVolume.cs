using System.Collections;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

[assembly: MelonInfo(typeof(SmallUserVolume.Main), "SmallUserVolume", "1.4", "Boppr")]
[assembly: MelonGame("VRChat", "VRChat")]


namespace SmallUserVolume
{
    public class Main : MelonMod
    {
        public static MelonPreferences_Entry<bool> Tiny;
        public override void OnApplicationStart()
        {
            MelonCoroutines.Start(CheckUIManager());
            MelonPreferences_Category Category0 = MelonPreferences.CreateCategory("SmallUserVolume", "Small User Volume");
            Tiny = Category0.CreateEntry("TinyUserVolume", false, "Tiny User Volume");
        }

        private IEnumerator CheckUIManager()
        {
            while (VRCUiManager.prop_VRCUiManager_0 == null) { yield return null; }
            OnUIInit();
        }

        private void OnUIInit()
        {
            Transform UV = GameObject.Find("UserInterface/QuickMenu/UserInteractMenu/User Volume").transform;
            UV.FindChild("VolumeText").gameObject.SetActive(false);
            Transform VD = UV.FindChild("VolumeDisplay");
            Transform VS = UV.FindChild("VolumeSlider");
            Transform VNT = VS.FindChild("Fill Area").FindChild("VolumeNumberText");
            Transform RaV = UV.FindChild("Raise");
            Transform LV = UV.FindChild("Lower");
            Transform ReV = UV.FindChild("Reset");

            if (Tiny.Value) { goto TinyUserVolume; } else { goto SmallUserVolume; }

        SmallUserVolume:
            VD.GetComponent<RectTransform>().sizeDelta = new Vector2(840f, 37.71f);
            VD.localPosition = new Vector3(-210f, VD.localPosition.y, VD.localPosition.z);
            VS.GetComponent<RectTransform>().sizeDelta = new Vector2(840f, 160f);
            VS.localPosition = new Vector3(-210f, VS.localPosition.y, VS.localPosition.z);
            RaV.GetComponent<RectTransform>().sizeDelta = new Vector2(210f, 210f);
            RaV.GetComponentInChildren<Text>().text = "+";
            RaV.localPosition = new Vector3(+105f, RaV.localPosition.y, RaV.localPosition.z);
            LV.GetComponent<RectTransform>().sizeDelta = new Vector2(210f, 210f);
            LV.GetComponentInChildren<Text>().text = "-";
            LV.localPosition = new Vector3(-525f, LV.localPosition.y, LV.localPosition.z);
            ReV.GetComponent<RectTransform>().sizeDelta = new Vector2(420f, 210f);
            ReV.localPosition = new Vector3(-210f, ReV.localPosition.y, ReV.localPosition.z);
            return;

        TinyUserVolume:
            VD.gameObject.SetActive(false);
            VS.FindChild("Fill Area").FindChild("Fill").gameObject.SetActive(false);
            VS.FindChild("Background").gameObject.SetActive(false);
            VNT.localPosition = new Vector3(15f, VNT.localPosition.y, VNT.localPosition.z);
            VS.GetComponent<RectTransform>().sizeDelta = new Vector2(840f, 160f);
            VS.localPosition = new Vector3(-420f, +140f, VS.localPosition.z);
            RaV.GetComponent<RectTransform>().sizeDelta = new Vector2(210f, 150f);
            RaV.GetComponentInChildren<Text>().text = "+";
            RaV.localPosition = new Vector3(-315f, RaV.localPosition.y, RaV.localPosition.z);
            LV.GetComponent<RectTransform>().sizeDelta = new Vector2(210f, 150f);
            LV.GetComponentInChildren<Text>().text = "-";
            LV.localPosition = new Vector3(-525f, LV.localPosition.y, LV.localPosition.z);
            ReV.GetComponent<RectTransform>().sizeDelta = new Vector2(420f, 150f);
            ReV.localPosition = new Vector3(-420f, +20f, ReV.localPosition.z);
            return;
        }
    }
}

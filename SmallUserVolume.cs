using System.Collections;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace SmallUserVolume
{
    public class Class : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonCoroutines.Start(CheckUIManager());
        }
        private IEnumerator CheckUIManager()
        {
            while (VRCUiManager.prop_VRCUiManager_0 == null) { yield return null; }
            OnUIManagerInit();
        }
        public void OnUIManagerInit()
        {
            Transform UV = GameObject.Find("UserInterface/QuickMenu/UserInteractMenu/User Volume").transform;
            UV.FindChild("VolumeText").gameObject.SetActive(false);
            Transform VD = UV.FindChild("VolumeDisplay");
            Transform VS = UV.FindChild("VolumeSlider");
            Transform RaV = UV.FindChild("Raise");
            Transform LV = UV.FindChild("Lower");
            Transform ReV = UV.FindChild("Reset");

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
        }
    }
}

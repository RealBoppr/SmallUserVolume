using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace SmallUserVolume
{
    public class Class : MelonMod
    {
        public override void VRChat_OnUiManagerInit()
        {
            Transform UV = GameObject.Find("UserInterface/QuickMenu/UserInteractMenu/User Volume").transform;
            UV.FindChild("VolumeText").gameObject.SetActive(false);
            RectTransform VD = UV.FindChild("VolumeDisplay").GetComponent<RectTransform>();
            RectTransform VS = UV.FindChild("VolumeSlider").GetComponent<RectTransform>();
            RectTransform RaV = UV.FindChild("Raise").GetComponent<RectTransform>();
            RectTransform LV = UV.FindChild("Lower").GetComponent<RectTransform>();
            RectTransform ReV = UV.FindChild("Reset").GetComponent<RectTransform>();

            VD.sizeDelta = new Vector2(840f, 37.71f);
            VD.transform.localPosition = new Vector3(-210f, VD.transform.localPosition.y);
            VS.sizeDelta = new Vector2(840f, 160f);
            VS.transform.localPosition = new Vector3(-210f, VS.transform.localPosition.y);
            RaV.sizeDelta = new Vector2(210f, 210f);
            RaV.GetComponentInChildren<Text>().text = "+";
            RaV.transform.localPosition = new Vector3(+105f, RaV.transform.localPosition.y);
            LV.sizeDelta = new Vector2(210f, 210f);
            LV.GetComponentInChildren<Text>().text = "-";
            LV.transform.localPosition = new Vector3(-525f, LV.transform.localPosition.y);
            ReV.sizeDelta = new Vector2(420f, 210f);
            ReV.transform.localPosition = new Vector3(-210f, ReV.transform.localPosition.y);
        }
    }
}

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
            GameObject VD = UV.FindChild("VolumeDisplay").gameObject;
            GameObject VS = UV.FindChild("VolumeSlider").gameObject;
            GameObject RaV = UV.FindChild("Raise").gameObject;
            GameObject LV = UV.FindChild("Lower").gameObject;
            GameObject ReV = UV.FindChild("Reset").gameObject;

            VD.GetComponent<RectTransform>().sizeDelta = new Vector2(840f, 37.71f);
            VD.transform.localPosition = new Vector3(-210f, VD.transform.localPosition.y);
            VS.GetComponent<RectTransform>().sizeDelta = new Vector2(840f, 160f);
            VS.transform.localPosition = new Vector3(-210f, VS.transform.localPosition.y);
            RaV.GetComponent<RectTransform>().sizeDelta = new Vector2(210f, 210f);
            RaV.GetComponentInChildren<Text>().text = "+";
            RaV.transform.localPosition = new Vector3(+105f, RaV.transform.localPosition.y);
            LV.GetComponent<RectTransform>().sizeDelta = new Vector2(210f, 210f);
            LV.GetComponentInChildren<Text>().text = "-";
            LV.transform.localPosition = new Vector3(-525f, LV.transform.localPosition.y);
            ReV.GetComponent<RectTransform>().sizeDelta = new Vector2(420f, 210f);
            ReV.transform.localPosition = new Vector3(-210f, ReV.transform.localPosition.y);
        }
    }
}

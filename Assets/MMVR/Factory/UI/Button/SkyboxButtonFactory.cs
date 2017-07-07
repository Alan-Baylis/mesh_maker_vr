﻿using UnityEngine;
using CreateThis.Unity;
using CreateThis.Factory.VR.UI.Button;
using MMVR.UI.Button;

namespace MMVR.Factory.UI.Button {
    public class SkyboxButtonFactory : ToggleButtonFactory {
        public string skybox;
        public SkyboxManager skyboxManager;

        public void PopulateButton(SkyboxButton button, AudioSource audioSourceDown, AudioSource audioSourceUp) {
            base.PopulateButton(button, audioSourceDown, audioSourceUp);
            button.clickOnTriggerExit = true;
            button.skybox = skybox;
            button.skyboxManager = skyboxManager;
        }

        protected override void AddButton(GameObject target, AudioSource audioSourceDown, AudioSource audioSourceUp) {
            SkyboxButton button = Undoable.AddComponent<SkyboxButton>(target);
            PopulateButton(button, audioSourceDown, audioSourceUp);
        }
    }
}

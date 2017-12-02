using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vsyncController : MonoBehaviour {

    private void Awake() {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 120;
    }
}

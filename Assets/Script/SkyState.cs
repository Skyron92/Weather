using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyState : MonoBehaviour
{
    public static bool isSunny, isRainy, isSnowy, isWindy;

    public void Sun() {
        isSunny = true;
        isRainy = isSnowy = isWindy = false;
    }

    public void Rain() {
        isRainy = true;
        isSnowy = isSunny = isWindy = false;
    }

    public void Snow() {
        isSnowy = true;
        isRainy = isSunny = isWindy = false;
    }

    public void Wind() {
        isWindy = true;
        isRainy = isSnowy = isSunny = false;
    }
}

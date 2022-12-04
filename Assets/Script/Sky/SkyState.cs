using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyState : MonoBehaviour
{
    public static bool isSunny, isRainy, isSnowy, isWindy;

    public static void Sun() {
        isSunny = true;
        isRainy = isSnowy = isWindy = false;
    }

    public static void Rain() {
        isRainy = true;
        isSnowy = isSunny = isWindy = false;
    }

    public static void Snow() {
        isSnowy = true;
        isRainy = isSunny = isWindy = false;
    }

    public static void Wind() {
        isWindy = true;
        isRainy = isSnowy = isSunny = false;
    }
}

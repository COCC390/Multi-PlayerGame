using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFX
{
    public VFXName name;
    public ParticleSystem particleSystem;
}

public class VFXController : MonoBehaviour
{
    [SerializeField] private List<VFX> _vFXes = new List<VFX>();
    [SerializeField] private List<VFXName> _currentVFXes = new List<VFXName>();

    private void ChangeVFXs(VFXName vfxName, bool isStopCurrentVFX = false)
    {
        if (isStopCurrentVFX)
        {

        }
    }

    private void PlayVFX(VFXName vfxName) =>
        _vFXes.Find(vfx => vfx.name == vfxName).particleSystem.Play();
    

    private void StopVFX(VFXName vfxName) =>
        _vFXes.Find(vfx => vfx.name == vfxName).particleSystem.Stop();

    private void StopAllVFX()
    {
        foreach(VFX vfx in _vFXes)
        {

        }
    }
}

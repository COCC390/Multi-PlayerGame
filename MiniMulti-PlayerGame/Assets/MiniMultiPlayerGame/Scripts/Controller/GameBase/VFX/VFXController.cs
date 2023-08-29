using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VFX
{
    public VFXName name;
    public ParticleSystem particleSystem;
}

public class VFXController : MonoBehaviour
{
    [SerializeField] private List<VFX> _vFXes = new List<VFX>();
    [SerializeField] private List<VFXName> _currentVFXes = new List<VFXName>();

    public void ChangeVFXs(VFXName vfxName, bool isStopCurrentVFX = false)
    {
        if (isStopCurrentVFX)
        {

        }
    }

    public virtual void PlayVFX(VFXName vfxName) => Debug.Log(vfxName.ToString());
        //_vFXes.Find(vfx => vfx.name == vfxName).particleSystem.Play();
    

    public virtual void StopVFX(VFXName vfxName) =>
        _vFXes.Find(vfx => vfx.name == vfxName).particleSystem.Stop();

    public void StopAllVFX()
    {
        foreach(VFX vfx in _vFXes)
        {

        }
    }
}

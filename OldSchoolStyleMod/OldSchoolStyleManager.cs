using System.Collections.Generic;
using UnityEngine;
using VoxelTycoon;
using VoxelTycoon.Tracks;

namespace OldSchoolStyleMod
{
    public class OldSchoolStyleManager : Manager<OldSchoolStyleManager>
    {
        private readonly List<Transform> _transforms = new List<Transform>();

        public bool Enabled { get; set; } = true;

        protected override void OnLateUpdate()
        {
            base.OnLateUpdate();

            if (!Enabled)
                return;

            var companies = CompanyManager.Current.GetAll();
            for (var i = 0; i < companies.Count; i++)
            {
                var company = companies[i];
                var trackUnits = TrackUnitManager.Current.GetAll(company);
                for (var j = 0; j < trackUnits.Count; j++)
                {
                    var trackUnit = trackUnits[j];
                    trackUnit.GetComponentsInChildren(_transforms);
                    foreach (var transform in _transforms)
                    {
                        var rotation = transform.localEulerAngles;
                        rotation.x = Helper.RoundTo(rotation.x, 90f / 4);
                        rotation.y = Helper.RoundTo(rotation.y, 90f / 2);
                        rotation.z = Helper.RoundTo(rotation.z, 90f / 4);
                        transform.localEulerAngles = rotation;
                    }
                    _transforms.Clear();
                }
            }
        }
    }
}

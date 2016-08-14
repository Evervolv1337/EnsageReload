﻿namespace EvAwareness.UI
{
    using System.Collections.Generic;

    using Ensage;
    using Ensage.Common.Menu;

    using Elements;

    using Utility;

    using SharpDX.Direct3D9;

    class HudVariables
    {
        public static List<ElementHandler> ElementsList = new List<ElementHandler>
                                                              {
                                                                  new StatusPanel(),
                                                                  new Minimap(),
                                                                  new LocalHero(),
                                                                  new Mouse()
                                                              }; 

        public static Font HudFont => new Font(Drawing.Direct3DDevice9, new FontDescription {
             FaceName = "Segoe UI",
             Height = 15,
             OutputPrecision = FontPrecision.Default,
             Quality = FontQuality.Default
         });

        public static bool ShouldBeVisible => MenuExtensions.GetItemValue<bool>("evervolv.aware.hud.show");

        public static Menu HudMenu { get; set; }
    }
}
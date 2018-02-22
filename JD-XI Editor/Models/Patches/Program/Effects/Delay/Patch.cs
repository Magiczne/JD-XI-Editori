﻿using System.Collections.Generic;
using JD_XI_Editor.Models.Patches.Program.Abstract;

namespace JD_XI_Editor.Models.Patches.Program.Effects.Delay
{
    internal class Patch : EffectPatch
    {
        /// <inheritdoc />
        /// <summary>
        ///     Creates new instance of Delay Patch
        /// </summary>
        public Patch()
        {
            Basic = new BasicData();
            Parameters = new Parameters();

            Basic.PropertyChanged += (sender, args) => NotifyOfPropertyChange(nameof(Basic));
            Parameters.PropertyChanged += (paramSender, paramArgs) => NotifyOfPropertyChange(nameof(Parameters));
        }

        /// <inheritdoc />
        public override byte[] GetBytes()
        {
            var bytes = new List<byte>();

            bytes.AddRange(Basic.GetBytes());
            bytes.AddRange(Parameters.GetBytes());

            return bytes.ToArray();
        }
    }
}
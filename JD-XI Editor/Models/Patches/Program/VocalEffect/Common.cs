﻿using System;
using Caliburn.Micro;
using JD_XI_Editor.Models.Enums.Program.VocalEffect;

// ReSharper disable InvertIf

namespace JD_XI_Editor.Models.Patches.Program.VocalEffect
{
    internal class Common : PropertyChangedBase, IPatchPart
    {
        /// <inheritdoc />
        /// <summary>
        ///     Creates new instance of Common
        /// </summary>
        public Common()
        {
            Reset();
        }

        /// <inheritdoc />
        public void Reset()
        {
            Level = 127;
            Panorama = 0;
            DelaySendLevel = 0;
            ReverbSendLevel = 0;
            OutputAssign = OutputAssign.Delay;
        }

        /// <inheritdoc />
        public byte[] GetBytes()
        {
            return new[]
            {
                (byte) Level,
                (byte) (Panorama + 64),
                (byte) DelaySendLevel,
                (byte) ReverbSendLevel,
                (byte) OutputAssign
            };
        }

        #region MyRegion

        /// <summary>
        ///     Level
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        ///     Panorama
        /// </summary>
        public int Panorama { get; set; }

        /// <summary>
        ///     Delay Send Level
        /// </summary>
        public int DelaySendLevel { get; set; }

        /// <summary>
        ///     Reverb Send Level
        /// </summary>
        public int ReverbSendLevel { get; set; }

        /// <summary>
        ///     Output Assign
        /// </summary>
        public OutputAssign OutputAssign { get; set; }

        #endregion
    }
}
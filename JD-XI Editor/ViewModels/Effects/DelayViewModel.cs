﻿using Caliburn.Micro;
using JD_XI_Editor.Models.Enums.Program.Effects.Delay;
using JD_XI_Editor.Models.Patches.Program.Effects.Delay;

namespace JD_XI_Editor.ViewModels.Effects
{
    internal class DelayViewModel : Screen
    {
        /// <inheritdoc />
        /// <summary>
        ///     Create new instance of Delay View Model
        /// </summary>
        public DelayViewModel(Patch patch)
        {
            Patch = patch;

            Patch.Parameters.PropertyChanged += (sender, args) =>
            {
                if (args.PropertyName == nameof(Parameters.Mode))
                {
                    NotifyOfPropertyChange(nameof(TimeModeSelected));
                    NotifyOfPropertyChange(nameof(NoteModeSelected));
                }
            };
        }

        /// <summary>
        ///     Delay patch
        /// </summary>
        public Patch Patch { get; }

        /// <summary>
        ///     Is time mode currently selected
        /// </summary>
        public bool TimeModeSelected => ((Parameters) Patch.Parameters).Mode == Mode.Time;

        /// <summary>
        ///     Is note mode currently selected
        /// </summary>
        public bool NoteModeSelected => ((Parameters) Patch.Parameters).Mode == Mode.Note;
    }
}
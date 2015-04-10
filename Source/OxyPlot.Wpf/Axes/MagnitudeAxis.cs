// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MagnitudeAxis.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// <summary>
//   This is a WPF wrapper of OxyPlot.MagnitudeAxis.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot.Wpf
{
    using System.Windows;

    using OxyPlot.Axes;

    /// <summary>
    /// This is a WPF wrapper of OxyPlot.MagnitudeAxis.
    /// </summary>
    public class MagnitudeAxis : LinearAxis
    {

        /// <summary>
        /// Identifies the <see cref="StartAngle"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty AxisAngleProperty =
            DependencyProperty.Register("AxisAngle", typeof(double), typeof(MagnitudeAxis), new PropertyMetadata(0d, AppearanceChanged));

        /// <summary>
        /// Initializes static members of the <see cref = "MagnitudeAxis" /> class.
        /// </summary>
        static MagnitudeAxis()
        {
            MajorGridlineStyleProperty.OverrideMetadata(typeof(MagnitudeAxis), new PropertyMetadata(LineStyle.Solid));
            MinorGridlineStyleProperty.OverrideMetadata(typeof(MagnitudeAxis), new PropertyMetadata(LineStyle.Solid));
            PositionProperty.OverrideMetadata(typeof(MagnitudeAxis), new PropertyMetadata(AxisPosition.None, AppearanceChanged));
            IsPanEnabledProperty.OverrideMetadata(typeof(MagnitudeAxis), new PropertyMetadata(false));
            IsZoomEnabledProperty.OverrideMetadata(typeof(MagnitudeAxis), new PropertyMetadata(false));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "MagnitudeAxis" /> class.
        /// </summary>
        public MagnitudeAxis()
        {
            this.InternalAxis = new Axes.MagnitudeAxis();
        }


        /// <summary>
        /// Gets or sets the axis angle (degrees).
        /// </summary>
        public double AxisAngle
        {
            get { return (double)this.GetValue(AxisAngleProperty); }
            set { this.SetValue(AxisAngleProperty, value); }
        }

             /// <summary>
        /// Synchronizes the properties.
        /// </summary>
        protected override void SynchronizeProperties()
        {
 	         base.SynchronizeProperties();
             var a = (Axes.MagnitudeAxis)this.InternalAxis;
             a.AxisAngle = this.AxisAngle;
        }
    }
}
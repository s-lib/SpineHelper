using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SpineHelper.Device;
using System.Drawing;

namespace SpineHelper.View
{
    //#if DEBUG
    public class TimeUpdatedUC : UserControl
    //#else
    ////[TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<TimeUpdatedUC, UserControl>))]
    //public abstract class TimeUpdatedUC : UserControl
    //#endif
    {
        protected Queue<DeviceState> updateQueue = new Queue<DeviceState>();

        public TimeUpdatedUC()
        {
            ControlsUpdateTimer.instance.TimerTick += OnTimedUpdate;
            Spinetester.instance.DataRecieved += OnDeviceDataRecieved;
        }

        protected virtual void OnTimedUpdate()
        {
        }

//#if DEBUG
        protected virtual void OnUpdateControls(DeviceState state) { }
//#else
//        protected abstract void OnUpdateControls(DeviceState state);
//#endif



        private void OnDeviceDataRecieved(DeviceState state, double[] values)
        {
            OnUpdateControls(state);
        }


        protected void SetText(Control control, string text)
        {
            if (SafeControlStateChange(SetText, control, text))
                control.Text = text;

            //if (label.InvokeRequired)
            //{
            //    var d = new Action<Label, string>(SetLabelText);
            //    Invoke(d, new object[] { label, text });
            //}
            //else
            //{
            //    label.Text = text;
            //}
        }


        protected void SetPanelVisibility(Panel panel, bool visible)
        {
            if (SafeControlStateChange(SetPanelVisibility, panel, visible))
            {
                panel.Visible = visible;
                panel.Enabled = visible;
            }
        }

        protected void SetVisibility(Control control, bool visible)
        {
            if (SafeControlStateChange(SetVisibility, control, visible))
            {
                control.Visible = visible;
            }
        }



        protected void SetEnabled(Control control, bool enabled)
        {
            if (SafeControlStateChange(SetEnabled, control, enabled))
            {
                control.Enabled = enabled;
            }
        }

        protected void SetChecked(RadioButton button, bool value)
        {
            if (SafeControlStateChange(SetChecked, button, value))
            {
                button.Checked = value;
            }
        }

        protected void SetButtonImage(Button box, Bitmap bitmap)
        {
            if (SafeControlStateChange(SetButtonImage, box, bitmap))
            {
                box.Image = bitmap;
            }
        }

        /// <summary>
        /// Returns true if it's safe to change state, invokes a delegate when necessary
        /// </summary>
        protected bool SafeControlStateChange<T1, T2>(Action<T1, T2> action, T1 target, T2 value) where T1 : Control
        {
            if (target.InvokeRequired == false)
                return true;
            else
            {
                Invoke(action, new object[] { target, value });
                return false;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TimeUpdatedUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "TimeUpdatedUC";
            this.ResumeLayout(false);
        }
    }
}

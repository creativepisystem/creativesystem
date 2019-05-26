using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Truckleer.Creative.Screens.ProgressBar
{
    class CustomProgressBar: CircularProgressBar.CircularProgressBar
    {
        public CustomProgressBar(System.Drawing.Color color)
        {
            AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            AnimationSpeed = 500;
            BackColor = System.Drawing.Color.Transparent;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            InnerMargin = 2;
            InnerWidth = -1;
            Location = new System.Drawing.Point(325, 134);
            MarqueeAnimationSpeed = 2000;
            OuterColor = System.Drawing.Color.Gray;
            OuterMargin = -25;
            OuterWidth = 26;
            ProgressColor = color;
            ProgressWidth = 25;
            SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            Size = new System.Drawing.Size(320, 320);
            StartAngle = 270;
            Step = 1;
            SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            SubscriptText = "";
            SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            SuperscriptText = "";
            TabIndex = 78;
            Text = "Loading";
            TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            Value = 0;
            Visible = false;
        }
    }
}

using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MainApplication
{
    public class DesignLabel: UserControl
    {
        //design options
        public enum TextDesigns { Metallic, Aqua, Neon }
        private TextDesigns _TextDesign;
        public TextDesigns TextDesign
        {
            get { return _TextDesign; }
            set
            {
                _TextDesign = value;
                Invalidate();
            }
        }

        //border options
        public enum TextBorderStyles { Normal, Embossed, Shadow }
        private TextBorderStyles _TextBorderStyle;
        public TextBorderStyles TextBorderStyle
        {
            get { return _TextBorderStyle; }
            set
            {
                _TextBorderStyle = value;
                Invalidate();
            }
        }

        private string _Text;
        [Browsable(true)] //show the "Text" property on the Properties Window
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] //fix value of "Text" is not saving
        public override string Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                Invalidate();
            }
        }

        //constructor
        public DesignLabel()
        {
            //remove flickerring
            DoubleBuffered = true;

            Font = new Font("Arial Black", 40);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //remove pixelation
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            float textPoint = 0;

            //border style
            if (TextBorderStyle != TextBorderStyles.Normal)
            {
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    //paint a black text behind the actual text to make it look like embossed or has a shadow
                    e.Graphics.DrawString(Text, Font, brush, 0, 0);
                }

                //reposition the actual text, so that it will not cover the embossed or shadow effect
                textPoint = (TextBorderStyle == TextBorderStyles.Embossed) ? 1 : 2.5f;
            }

            LinearGradientBrush textBrush = null;

            if (TextDesign == TextDesigns.Metallic)
                textBrush = new LinearGradientBrush(ClientRectangle, Color.DarkGray, Color.FromArgb(200, 200, 200), LinearGradientMode.Vertical);
            else if (TextDesign == TextDesigns.Aqua)
                textBrush = new LinearGradientBrush(ClientRectangle, Color.LightBlue, Color.Blue, LinearGradientMode.Vertical);
            else if (TextDesign == TextDesigns.Neon)
                textBrush = new LinearGradientBrush(ClientRectangle, Color.Lime, Color.FromArgb(0, 255, 0), LinearGradientMode.Vertical);

            //paint the text
            using (textBrush)
            {
                e.Graphics.DrawString(Text, Font, textBrush, textPoint, textPoint);
            }
        }
        //It works
    }
}

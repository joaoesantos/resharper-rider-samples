using System.Collections.Generic;
using System.Drawing;

// THIS CLASS IS A SHIM TO ALLOW
// THE SAMPLE TO COMPILE CROSS-PLATFORM
// IT DOES NOT CONTAIN ANY FUNCTIONALITY
namespace System.Windows.Forms
{
    public abstract class Form 
    {
        protected void SuspendLayout()
        {
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        protected SizeF AutoScaleDimensions { get; set; }
        protected object AutoScaleMode { get; set; }
        protected Size ClientSize { get; set; }
        protected string Name { get; set; }
        protected string Text { get; set; }

        protected void ResumeLayout(bool b)
        {
        }

        protected void PerformLayout()
        {
        }

        protected List<object> Controls { get; set; } = new List<object>();
    }
    public class AutoScaleMode
    {
        public static Font Font { get; set; }
    }

    public class Label
    {
        public bool AutoSize { get; set; }
        public Font Font { get; set; }
        public Point Location { get; set; }
        public string Name { get; set; }
        public Size Size { get; set; }
        public int TabIndex { get; set; }
        public string Text { get; set; }
    }
}

namespace System.Drawing
{
    public class Font
    {
        public Font(string font, float size)
        {
        }
    }
}
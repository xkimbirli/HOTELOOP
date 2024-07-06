using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private int _cornerRadius = 15;

    public int CornerRadius
    {
        get { return _cornerRadius; }
        set
        {
            _cornerRadius = value;
            Invalidate(); // Redraw the button when the corner radius changes
        }
    }

    public RoundedButton()
    {
        this.BackColor = Color.LightGray; // Set the background color to light gray
        this.ForeColor = Color.Black; // Set the text color to white
        this.Height = 40; // Set the desired height
        this.FlatStyle = FlatStyle.Flat; // Remove default button styling
        this.FlatAppearance.BorderSize = 0; // Remove default border
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        // Enable anti-aliasing for smoother graphics
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
        pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
        pevent.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

        // Create the rounded rectangle path
        GraphicsPath path = new GraphicsPath();
        float radius = _cornerRadius * 2F;

        path.AddArc(0, 0, radius, radius, 180, 90);
        path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
        path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
        path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);

        path.CloseFigure();

        // Set the button region to the rounded path
        this.Region = new Region(path);

        // Fill the background with light gray
        using (SolidBrush brush = new SolidBrush(this.BackColor))
        {
            pevent.Graphics.FillPath(brush, path);
        }

        // Draw the text in white
        TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}

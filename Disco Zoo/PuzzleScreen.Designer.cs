
namespace Disco_Zoo
{
    partial class PuzzleScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updateTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // updateTick
            // 
            this.updateTick.Interval = 1;
            this.updateTick.Tick += new System.EventHandler(this.updateTick_Tick);
            // 
            // PuzzleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.Name = "PuzzleScreen";
            this.Size = new System.Drawing.Size(350, 700);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PuzzleScreen_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PuzzleScreen_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer updateTick;
    }
}

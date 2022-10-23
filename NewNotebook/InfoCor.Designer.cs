namespace NewNotebook
{
  partial class InfoCor
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.PdaText = new System.Windows.Forms.TextBox();
      this.PdaInput = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // PdaText
      // 
      this.PdaText.Location = new System.Drawing.Point(12, 12);
      this.PdaText.Multiline = true;
      this.PdaText.Name = "PdaText";
      this.PdaText.Size = new System.Drawing.Size(776, 367);
      this.PdaText.TabIndex = 0;
      // 
      // PdaInput
      // 
      this.PdaInput.Location = new System.Drawing.Point(677, 385);
      this.PdaInput.Name = "PdaInput";
      this.PdaInput.Size = new System.Drawing.Size(111, 53);
      this.PdaInput.TabIndex = 1;
      this.PdaInput.Text = "저장";
      this.PdaInput.UseVisualStyleBackColor = true;
      this.PdaInput.Click += new System.EventHandler(this.PdaInput_Click);
      // 
      // InfoCor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.PdaInput);
      this.Controls.Add(this.PdaText);
      this.Name = "InfoCor";
      this.Text = "Form2";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox PdaText;
        private System.Windows.Forms.Button PdaInput;
    }
}
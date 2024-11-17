nnamespace bar
{
    partial class Form1
{
    /// <summary>
    ///  Holds components required by the designer.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Releases the resources being used.
    /// </summary>
    /// <param name="disposing">If true, managed resources will be disposed of.</param>
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
    ///  Method required for Windows Form Designer. Avoid making manual changes here.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        label1 = new Label();
        label2 = new Label();
        txtlabels = new TextBox();
        txtValues = new TextBox();
        bar1 = new bar();
        label3 = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = Color.Cornsilk;
        button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(660, 438);
        button1.Margin = new Padding(2, 3, 2, 3);
        button1.Name = "button1";
        button1.Size = new Size(153, 53);
        button1.TabIndex = 0;
        button1.Text = "Make Chart";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(27, 438);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(221, 20);
        label1.TabIndex = 1;
        label1.Text = "Labels (Separate with commas)";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(35, 475);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(213, 20);
        label2.TabIndex = 2;
        label2.Text = "Values (Separate with commas)";
        // 
        // txtlabels
        // 
        txtlabels.BackColor = Color.LightCyan;
        txtlabels.Location = new Point(326, 438);
        txtlabels.Margin = new Padding(2, 3, 2, 3);
        txtlabels.Name = "txtlabels";
        txtlabels.Size = new Size(284, 27);
        txtlabels.TabIndex = 3;
        // 
        // txtValues
        // 
        txtValues.BackColor = Color.LightCyan;
        txtValues.Location = new Point(326, 475);
        txtValues.Margin = new Padding(2, 3, 2, 3);
        txtValues.Name = "txtValues";
        txtValues.Size = new Size(284, 27);
        txtValues.TabIndex = 4;
        // 
        // bar1
        // 
        bar1.Location = new Point(11, 10);
        bar1.Margin = new Padding(1);
        bar1.Name = "bar1";
        bar1.Size = new Size(825, 401);
        bar1.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(27, 13);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(0, 20);
        label3.TabIndex = 6;
        label3.Click += label3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(846, 525);
        Controls.Add(label3);
        Controls.Add(bar1);
        Controls.Add(txtValues);
        Controls.Add(txtlabels);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button1);
        Margin = new Padding(2, 3, 2, 3);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private Label label2;
    private TextBox txtlabels;
    private TextBox txtValues;
    private bar bar1;
    private Label label3;
}
}

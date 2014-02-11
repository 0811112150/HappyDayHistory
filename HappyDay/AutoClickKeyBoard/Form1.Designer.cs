namespace HappyDay.AutoClickKeyBoard
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMouseY = new System.Windows.Forms.TextBox();
			this.txtMouseX = new System.Windows.Forms.TextBox();
			this.btnGetMousePt = new System.Windows.Forms.Button();
			this.btnSetMousePt = new System.Windows.Forms.Button();
			this.btnStartInput = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "X:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "Y:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtMouseY);
			this.groupBox1.Controls.Add(this.txtMouseX);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(22, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "鼠标位置";
			// 
			// txtMouseY
			// 
			this.txtMouseY.Location = new System.Drawing.Point(50, 55);
			this.txtMouseY.Name = "txtMouseY";
			this.txtMouseY.Size = new System.Drawing.Size(100, 21);
			this.txtMouseY.TabIndex = 1;
			// 
			// txtMouseX
			// 
			this.txtMouseX.Location = new System.Drawing.Point(50, 20);
			this.txtMouseX.Name = "txtMouseX";
			this.txtMouseX.Size = new System.Drawing.Size(100, 21);
			this.txtMouseX.TabIndex = 1;
			// 
			// btnGetMousePt
			// 
			this.btnGetMousePt.Location = new System.Drawing.Point(22, 203);
			this.btnGetMousePt.Name = "btnGetMousePt";
			this.btnGetMousePt.Size = new System.Drawing.Size(99, 23);
			this.btnGetMousePt.TabIndex = 2;
			this.btnGetMousePt.Text = "获取鼠标位置";
			this.btnGetMousePt.UseVisualStyleBackColor = true;
			this.btnGetMousePt.Click += new System.EventHandler(this.btnGetMousePt_Click);
			// 
			// btnSetMousePt
			// 
			this.btnSetMousePt.Location = new System.Drawing.Point(22, 232);
			this.btnSetMousePt.Name = "btnSetMousePt";
			this.btnSetMousePt.Size = new System.Drawing.Size(99, 23);
			this.btnSetMousePt.TabIndex = 2;
			this.btnSetMousePt.Text = "设置鼠标位置";
			this.btnSetMousePt.UseVisualStyleBackColor = true;
			this.btnSetMousePt.Click += new System.EventHandler(this.btnSetMousePt_Click);
			// 
			// btnStartInput
			// 
			this.btnStartInput.Location = new System.Drawing.Point(143, 203);
			this.btnStartInput.Name = "btnStartInput";
			this.btnStartInput.Size = new System.Drawing.Size(99, 23);
			this.btnStartInput.TabIndex = 2;
			this.btnStartInput.Text = "开始输入";
			this.btnStartInput.UseVisualStyleBackColor = true;
			this.btnStartInput.Click += new System.EventHandler(this.btnStartInput_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(267, 267);
			this.Controls.Add(this.btnSetMousePt);
			this.Controls.Add(this.btnStartInput);
			this.Controls.Add(this.btnGetMousePt);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Leave += new System.EventHandler(this.Form1_Leave);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtMouseY;
		private System.Windows.Forms.TextBox txtMouseX;
		private System.Windows.Forms.Button btnGetMousePt;
		private System.Windows.Forms.Button btnSetMousePt;
		private System.Windows.Forms.Button btnStartInput;
	}
}


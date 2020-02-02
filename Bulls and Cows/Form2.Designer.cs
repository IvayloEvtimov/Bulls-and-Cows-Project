namespace Bulls_and_Cows
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.InputField = new System.Windows.Forms.TextBox();
            this.EnterField = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Steps = new System.Windows.Forms.Label();
            this.HelpButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HintRes = new System.Windows.Forms.Label();
            this.StepsCounter = new System.Windows.Forms.Label();
            this.HighScores = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StepColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.hardTimer = new System.Windows.Forms.Timer(this.components);
            this.HighScoreLbl = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.ResultList = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bulls = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cows = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(7, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(147, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Bulls and Cows";
            // 
            // InputField
            // 
            this.InputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputField.Location = new System.Drawing.Point(12, 37);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(156, 26);
            this.InputField.TabIndex = 1;
            this.InputField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputField_KeyDown);
            // 
            // EnterField
            // 
            this.EnterField.Location = new System.Drawing.Point(12, 69);
            this.EnterField.Name = "EnterField";
            this.EnterField.Size = new System.Drawing.Size(75, 23);
            this.EnterField.TabIndex = 2;
            this.EnterField.Text = "Check";
            this.EnterField.UseVisualStyleBackColor = true;
            this.EnterField.Click += new System.EventHandler(this.EnterField_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(199, 14);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(59, 20);
            this.Result.TabIndex = 3;
            this.Result.Text = "Result:";
            // 
            // Steps
            // 
            this.Steps.AutoSize = true;
            this.Steps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Steps.Location = new System.Drawing.Point(8, 134);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(55, 20);
            this.Steps.TabIndex = 5;
            this.Steps.Text = "Steps:";
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(93, 69);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 23);
            this.HelpButton.TabIndex = 6;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hint:";
            // 
            // HintRes
            // 
            this.HintRes.AutoSize = true;
            this.HintRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HintRes.Location = new System.Drawing.Point(56, 104);
            this.HintRes.Name = "HintRes";
            this.HintRes.Size = new System.Drawing.Size(0, 20);
            this.HintRes.TabIndex = 9;
            // 
            // StepsCounter
            // 
            this.StepsCounter.AutoSize = true;
            this.StepsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepsCounter.Location = new System.Drawing.Point(69, 134);
            this.StepsCounter.Name = "StepsCounter";
            this.StepsCounter.Size = new System.Drawing.Size(18, 20);
            this.StepsCounter.TabIndex = 10;
            this.StepsCounter.Text = "0";
            // 
            // HighScores
            // 
            this.HighScores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.StepColumn});
            this.HighScores.FullRowSelect = true;
            this.HighScores.GridLines = true;
            this.HighScores.HideSelection = false;
            this.HighScores.Location = new System.Drawing.Point(388, 37);
            this.HighScores.Name = "HighScores";
            this.HighScores.Size = new System.Drawing.Size(178, 155);
            this.HighScores.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.HighScores.TabIndex = 11;
            this.HighScores.UseCompatibleStateImageBehavior = false;
            this.HighScores.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Tag = "string";
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 90;
            // 
            // StepColumn
            // 
            this.StepColumn.Tag = "int";
            this.StepColumn.Text = "Steps";
            this.StepColumn.Width = 111;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(12, 169);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 12;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // hardTimer
            // 
            this.hardTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // HighScoreLbl
            // 
            this.HighScoreLbl.AutoSize = true;
            this.HighScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreLbl.Location = new System.Drawing.Point(384, 14);
            this.HighScoreLbl.Name = "HighScoreLbl";
            this.HighScoreLbl.Size = new System.Drawing.Size(100, 20);
            this.HighScoreLbl.TabIndex = 13;
            this.HighScoreLbl.Text = "High Scores:";
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(93, 169);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(75, 23);
            this.MainMenu.TabIndex = 14;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // ResultList
            // 
            this.ResultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Bulls,
            this.Cows});
            this.ResultList.FullRowSelect = true;
            this.ResultList.GridLines = true;
            this.ResultList.HideSelection = false;
            this.ResultList.Location = new System.Drawing.Point(203, 37);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(179, 155);
            this.ResultList.TabIndex = 15;
            this.ResultList.UseCompatibleStateImageBehavior = false;
            this.ResultList.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Tag = "string";
            this.Number.Text = "Number";
            // 
            // Bulls
            // 
            this.Bulls.Tag = "string";
            this.Bulls.Text = "Bulls";
            this.Bulls.Width = 54;
            // 
            // Cows
            // 
            this.Cows.Tag = "string";
            this.Cows.Text = "Cows";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 206);
            this.Controls.Add(this.ResultList);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.HighScoreLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.HighScores);
            this.Controls.Add(this.StepsCounter);
            this.Controls.Add(this.HintRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.Steps);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.EnterField);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.Title);
            this.Name = "Form2";
            this.Text = "Bulls and Cows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Button EnterField;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Steps;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HintRes;
        private System.Windows.Forms.Label StepsCounter;
        private System.Windows.Forms.ListView HighScores;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader StepColumn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Timer hardTimer;
        private System.Windows.Forms.Label HighScoreLbl;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.ListView ResultList;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Bulls;
        private System.Windows.Forms.ColumnHeader Cows;
    }
}
namespace TextParser
{
    partial class TextParsingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextParsingForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabParser = new System.Windows.Forms.TabPage();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.afterSeperatorText = new System.Windows.Forms.TextBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.excludeText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.includeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sentenceSeperatorText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textToParse = new System.Windows.Forms.RichTextBox();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.fullSentence = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.probabilityResultsTab = new System.Windows.Forms.TabPage();
            this.maxCommonWordUsageResult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nextWordCountResult = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nextWordResult = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.previousWordCountResult = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.previousWordResult = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.commonWordCountResult = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.commonWordResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.parseWebPageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabParser.SuspendLayout();
            this.tabResults.SuspendLayout();
            this.probabilityResultsTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabParser);
            this.tabControl.Controls.Add(this.tabResults);
            this.tabControl.Controls.Add(this.probabilityResultsTab);
            this.tabControl.Location = new System.Drawing.Point(12, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(694, 537);
            this.tabControl.TabIndex = 0;
            // 
            // tabParser
            // 
            this.tabParser.Controls.Add(this.calculateButton);
            this.tabParser.Controls.Add(this.label7);
            this.tabParser.Controls.Add(this.afterSeperatorText);
            this.tabParser.Controls.Add(this.parseButton);
            this.tabParser.Controls.Add(this.label6);
            this.tabParser.Controls.Add(this.excludeText);
            this.tabParser.Controls.Add(this.label5);
            this.tabParser.Controls.Add(this.includeText);
            this.tabParser.Controls.Add(this.label2);
            this.tabParser.Controls.Add(this.sentenceSeperatorText);
            this.tabParser.Controls.Add(this.label1);
            this.tabParser.Controls.Add(this.textToParse);
            this.tabParser.Location = new System.Drawing.Point(4, 22);
            this.tabParser.Name = "tabParser";
            this.tabParser.Padding = new System.Windows.Forms.Padding(3);
            this.tabParser.Size = new System.Drawing.Size(686, 511);
            this.tabParser.TabIndex = 0;
            this.tabParser.Text = "Parser";
            this.tabParser.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(437, 482);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(162, 23);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Parse and Calculate Probability";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Include After Seperator:";
            // 
            // afterSeperatorText
            // 
            this.afterSeperatorText.Location = new System.Drawing.Point(164, 169);
            this.afterSeperatorText.Name = "afterSeperatorText";
            this.afterSeperatorText.Size = new System.Drawing.Size(100, 20);
            this.afterSeperatorText.TabIndex = 9;
            this.afterSeperatorText.Text = "\"";
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(605, 482);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(75, 23);
            this.parseButton.TabIndex = 8;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Exclude Sentences Containing:";
            // 
            // excludeText
            // 
            this.excludeText.Location = new System.Drawing.Point(164, 221);
            this.excludeText.Name = "excludeText";
            this.excludeText.Size = new System.Drawing.Size(100, 20);
            this.excludeText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Include Sentences Containing:";
            // 
            // includeText
            // 
            this.includeText.Location = new System.Drawing.Point(164, 195);
            this.includeText.Name = "includeText";
            this.includeText.Size = new System.Drawing.Size(100, 20);
            this.includeText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sentence Seperator:";
            // 
            // sentenceSeperatorText
            // 
            this.sentenceSeperatorText.Location = new System.Drawing.Point(164, 143);
            this.sentenceSeperatorText.Name = "sentenceSeperatorText";
            this.sentenceSeperatorText.Size = new System.Drawing.Size(100, 20);
            this.sentenceSeperatorText.TabIndex = 2;
            this.sentenceSeperatorText.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text To Parse:";
            // 
            // textToParse
            // 
            this.textToParse.Location = new System.Drawing.Point(6, 23);
            this.textToParse.Name = "textToParse";
            this.textToParse.Size = new System.Drawing.Size(673, 114);
            this.textToParse.TabIndex = 0;
            this.textToParse.Text = "";
            // 
            // tabResults
            // 
            this.tabResults.Controls.Add(this.label4);
            this.tabResults.Controls.Add(this.fullSentence);
            this.tabResults.Controls.Add(this.label3);
            this.tabResults.Controls.Add(this.resultsListBox);
            this.tabResults.Location = new System.Drawing.Point(4, 22);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(686, 511);
            this.tabResults.TabIndex = 1;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Full Sentence:";
            // 
            // fullSentence
            // 
            this.fullSentence.Location = new System.Drawing.Point(6, 141);
            this.fullSentence.Name = "fullSentence";
            this.fullSentence.Size = new System.Drawing.Size(674, 364);
            this.fullSentence.TabIndex = 2;
            this.fullSentence.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sentences:";
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(6, 23);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(674, 95);
            this.resultsListBox.TabIndex = 0;
            this.resultsListBox.SelectedIndexChanged += new System.EventHandler(this.resultsListBox_SelectedIndexChanged);
            // 
            // probabilityResultsTab
            // 
            this.probabilityResultsTab.Controls.Add(this.maxCommonWordUsageResult);
            this.probabilityResultsTab.Controls.Add(this.label9);
            this.probabilityResultsTab.Controls.Add(this.nextWordCountResult);
            this.probabilityResultsTab.Controls.Add(this.label17);
            this.probabilityResultsTab.Controls.Add(this.nextWordResult);
            this.probabilityResultsTab.Controls.Add(this.label19);
            this.probabilityResultsTab.Controls.Add(this.previousWordCountResult);
            this.probabilityResultsTab.Controls.Add(this.label14);
            this.probabilityResultsTab.Controls.Add(this.previousWordResult);
            this.probabilityResultsTab.Controls.Add(this.label12);
            this.probabilityResultsTab.Controls.Add(this.commonWordCountResult);
            this.probabilityResultsTab.Controls.Add(this.label10);
            this.probabilityResultsTab.Controls.Add(this.commonWordResult);
            this.probabilityResultsTab.Controls.Add(this.label8);
            this.probabilityResultsTab.Location = new System.Drawing.Point(4, 22);
            this.probabilityResultsTab.Name = "probabilityResultsTab";
            this.probabilityResultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.probabilityResultsTab.Size = new System.Drawing.Size(686, 511);
            this.probabilityResultsTab.TabIndex = 2;
            this.probabilityResultsTab.Text = "Probability Results";
            this.probabilityResultsTab.UseVisualStyleBackColor = true;
            // 
            // maxCommonWordUsageResult
            // 
            this.maxCommonWordUsageResult.AutoSize = true;
            this.maxCommonWordUsageResult.Location = new System.Drawing.Point(215, 33);
            this.maxCommonWordUsageResult.Name = "maxCommonWordUsageResult";
            this.maxCommonWordUsageResult.Size = new System.Drawing.Size(10, 13);
            this.maxCommonWordUsageResult.TabIndex = 13;
            this.maxCommonWordUsageResult.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Common Word Count:";
            // 
            // nextWordCountResult
            // 
            this.nextWordCountResult.AutoSize = true;
            this.nextWordCountResult.Location = new System.Drawing.Point(102, 85);
            this.nextWordCountResult.Name = "nextWordCountResult";
            this.nextWordCountResult.Size = new System.Drawing.Size(10, 13);
            this.nextWordCountResult.TabIndex = 11;
            this.nextWordCountResult.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Next Word Count:";
            // 
            // nextWordResult
            // 
            this.nextWordResult.AutoSize = true;
            this.nextWordResult.Location = new System.Drawing.Point(139, 72);
            this.nextWordResult.Name = "nextWordResult";
            this.nextWordResult.Size = new System.Drawing.Size(10, 13);
            this.nextWordResult.TabIndex = 9;
            this.nextWordResult.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(131, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Most Common Next Word:";
            // 
            // previousWordCountResult
            // 
            this.previousWordCountResult.AutoSize = true;
            this.previousWordCountResult.Location = new System.Drawing.Point(123, 59);
            this.previousWordCountResult.Name = "previousWordCountResult";
            this.previousWordCountResult.Size = new System.Drawing.Size(10, 13);
            this.previousWordCountResult.TabIndex = 7;
            this.previousWordCountResult.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Previous Word Count:";
            // 
            // previousWordResult
            // 
            this.previousWordResult.AutoSize = true;
            this.previousWordResult.Location = new System.Drawing.Point(163, 46);
            this.previousWordResult.Name = "previousWordResult";
            this.previousWordResult.Size = new System.Drawing.Size(10, 13);
            this.previousWordResult.TabIndex = 5;
            this.previousWordResult.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Most Common Previous Word:";
            // 
            // commonWordCountResult
            // 
            this.commonWordCountResult.AutoSize = true;
            this.commonWordCountResult.Location = new System.Drawing.Point(118, 20);
            this.commonWordCountResult.Name = "commonWordCountResult";
            this.commonWordCountResult.Size = new System.Drawing.Size(10, 13);
            this.commonWordCountResult.TabIndex = 3;
            this.commonWordCountResult.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Maximum times used in a given sentence:";
            // 
            // commonWordResult
            // 
            this.commonWordResult.AutoSize = true;
            this.commonWordResult.Location = new System.Drawing.Point(120, 7);
            this.commonWordResult.Name = "commonWordResult";
            this.commonWordResult.Size = new System.Drawing.Size(10, 13);
            this.commonWordResult.TabIndex = 1;
            this.commonWordResult.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Most Common Word:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(718, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parseWebPageToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.closeToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // parseWebPageToolStripMenuItem1
            // 
            this.parseWebPageToolStripMenuItem1.Name = "parseWebPageToolStripMenuItem1";
            this.parseWebPageToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.parseWebPageToolStripMenuItem1.Text = "x Parse File";
            this.parseWebPageToolStripMenuItem1.Click += new System.EventHandler(this.parseWebPageToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem1.Text = "x Save";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.technicalSupportToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(36, 22);
            this.toolStripDropDownButton2.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewHelpToolStripMenuItem.Text = "x View Help";
            // 
            // technicalSupportToolStripMenuItem
            // 
            this.technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            this.technicalSupportToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.technicalSupportToolStripMenuItem.Text = "x Technical Support";
            // 
            // TextParsingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 577);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "TextParsingForm";
            this.Text = "Text Parser";
            this.tabControl.ResumeLayout(false);
            this.tabParser.ResumeLayout(false);
            this.tabParser.PerformLayout();
            this.tabResults.ResumeLayout(false);
            this.tabResults.PerformLayout();
            this.probabilityResultsTab.ResumeLayout(false);
            this.probabilityResultsTab.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabParser;
        private System.Windows.Forms.RichTextBox textToParse;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sentenceSeperatorText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox excludeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox includeText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox fullSentence;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem parseWebPageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalSupportToolStripMenuItem;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox afterSeperatorText;
        private System.Windows.Forms.TabPage probabilityResultsTab;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label commonWordCountResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label commonWordResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nextWordCountResult;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label nextWordResult;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label previousWordCountResult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label previousWordResult;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label maxCommonWordUsageResult;
        private System.Windows.Forms.Label label9;
    }
}


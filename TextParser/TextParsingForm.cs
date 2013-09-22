//--------------------------------------------------------------------------------------------------|
// Filename: TextParsingForm.cs                                                                     |
// Date Created: 19/09/2013                                                                         |
// Date Modified: 22/09/2013                                                                        |
//--------------------------------------------------------------------------------------------------|
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextParser
{
    public partial class TextParsingForm : Form
    {
        public TextParsingForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parse();
        }

        private void resultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fullSentence.Text = resultsListBox.SelectedItem.ToString();
        }

        private void parseWebPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Open the Open File Dialog
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.ShowDialog();

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Parse the data into seperate sentences
            parse();

            // Parse the data again into words
            List<WordInformation> processedWordInformation = TextParser.ParseIntoWords(textToParse.Text);
            int max = 0;
            string word = "";
            WordInformation commonWordInfo = null;

            // Find the most common word used in the data
            foreach (WordInformation info in processedWordInformation)
            {
                if (info.Count > max)
                {
                    max = info.Count;
                    word = info.Word;
                    commonWordInfo = info;
                }
            }
            
            // Set the results to display on the probability results page
            commonWordResult.Text = word;
            commonWordCountResult.Text = max.ToString();

            commonWordInfo.GetWordStats(ref max, ref word);
            previousWordResult.Text = word;
            previousWordCountResult.Text = max.ToString();

            commonWordInfo.GetWordStats(ref max, ref word, WordInformation.WORDTYPE.NEXT);
            nextWordResult.Text = word;
            nextWordCountResult.Text = max.ToString();
        }

        // Parse the given data into seperate sentences based on the various variables in the form
        private void parse()
        {
            // Display a warning and return if the user has not entered any data to be parsed
            if (textToParse.Text == "")
            {
                MessageBox.Show("Please enter some text to parse before pressing the parse button.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse the data using the TextParser's static methods
            List<String> sentences = TextParser.Parse(textToParse.Text, sentenceSeperatorText.Text, afterSeperatorText.Text, includeText.Text, excludeText.Text);
            // Display the results in a listbox
            resultsListBox.Items.AddRange(sentences.ToArray());
            // Change the currently selected tab to the results tab
            tabControl.SelectTab(tabResults);
        }
    }
}

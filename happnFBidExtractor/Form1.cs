using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace happnFBidExtractor
{
    public partial class happnFBidExtractor : Form
    {
        public happnFBidExtractor()
        {
            InitializeComponent();
        }

        private void btnExtractor_Click(object sender, EventArgs e)
        {
            String inputText = rtbInputText.Text;
            String outputText = "";
            String myString = "";
            String myFbId = "";
            int j = 0;

            for (int i = 0; i < inputText.Count()-16; ++i)
            {
                j = 0;
                myFbId = "";
                myString = ""+inputText[i] + inputText[i + 1] + inputText[i + 2] + inputText[i + 3] + inputText[i + 4] + inputText[i + 5] + inputText[i + 6];
                //MessageBox.Show(myString);
                //MessageBox.Show("\"fbid\"");
                if (myString == "\"fbId\":")
                {
                    j = i + 7;
                    while (inputText[j] != ',')
                    {
                        myFbId += inputText[j];
                        j++;
                    }

                    rtbOutputText.Text += "https://facebook.com/profile.php?id=" + myFbId + "  ||  ";
                }
            }
            MessageBox.Show("Extraction complete !");
        }
    }
}

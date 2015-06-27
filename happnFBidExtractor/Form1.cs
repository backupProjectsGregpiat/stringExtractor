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
            String myFbNames;
            int p = 0;
            int j = 0;

            for (int i = 0; i < inputText.Count()-16; ++i)
            {
                j = 0;
                myFbId = "";
                myString = ""+inputText[i] + inputText[i + 1] + inputText[i + 2] + inputText[i + 3] + inputText[i + 4] + inputText[i + 5] + inputText[i + 6];
                if (myString == "\"fbId\":")
                {
                    j = i + 7;
                    while (inputText[j] != ',')
                    {
                        myFbId += inputText[j];
                        j++;
                    }

                    rtbOutputText.Text += "https://facebook.com/profile.php?id=" + myFbId + "  ||  ";
                    //Form.ActiveForm.Refresh();
                    this.Refresh();
                }
            }

            for (int k = 0; k < inputText.Count() - 20; ++k)
            {
                p = 0;
                myFbNames = "";
                myString = "" + inputText[k] + inputText[k + 1] + inputText[k + 2] + inputText[k + 3] + inputText[k + 4] + inputText[k + 5] + inputText[k + 6] + inputText[k + 7] + inputText[k + 8] + inputText[k + 9] + inputText[k + 10] + inputText[k + 11] + inputText[k + 12];
                //MessageBox.Show(myString);
                if (myString == "\"first_name\":")
                {
                    p = k + 14;
                    while (inputText[p] != '"')
                    {
                        myFbNames += inputText[p];
                        p++;
                    }

                    rtbOutputTextNames.Text += myFbNames + "  ||  ";
                    this.Refresh();
                    //Form.ActiveForm.Refresh();
                }
            }

            /*
            String first = "";
            String firstTemp = "";
            String second = "";
            String secondTemp = "";
            int nbFirst = 0;
            int nbSecond = 0;

            first = rtbOutputText.Text;
            for (int a = 0; a < first.Count()-1; ++a)
            {
                firstTemp = "" + first[a] + first[a + 1];
                if (firstTemp == "||")
                {
                    nbFirst++;
                }
            }
            
            for (int b = 0; b < first.Count()-1; ++b)
            {
                secondTemp = "" + first[b] + first[b + 1];
                if (secondTemp == "||")
                {
                    nbSecond++;
                }
            }

            if (nbFirst == nbSecond)
            {
                MessageBox.Show("Yen a autant maggle !");
            }

            int d = 0;
            int f = 0;

            while (first[d] != '|' && d < first.Count() - 1)
            {
                rtbFinalOutput.Text += first[d];
                d++;
            }

            while (second[f] != '|' && f < second.Count() - 1)
            {
                rtbFinalOutput.Text += second[f];
                f++;
            }
            



            */

            MessageBox.Show("Extraction completeted succesfully !");
        }
    }
}

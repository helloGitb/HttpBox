using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        byte[] hexToBytes(string hex)
        {
            if (hex != null && hex.Length % 2 == 0)
            {
                int i = 0;
                byte[] bytes = new byte[hex.Length / 2];

                while (i < hex.Length/2)
                {
                    string s = hex.Substring(i*2, 2);
                    bytes[i] = Convert.ToByte(s, 16);

                    i++;
                }

                return bytes;
            }


            return null;
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            string url = this.textBoxUrl.Text;
            if (url != null && url.Length > 0)
            {
                string resp = null;

                bool bPost = this.checkBoxPost.Checked;

                if (bPost)
                {
                    /*Post the data*/
                    string input = this.textBoxInput.Text;

                    if (input.Length > 0)
                    {
                        

                        bool isHex = this.checkBoxHex.Checked;
                        if (isHex)
                        {
                            string inputTrimSpace = input.Replace(" ", "");
                            if (inputTrimSpace.Length % 2 != 0)
                            {
                                MessageBox.Show("The post data is not correct.", "Tips", MessageBoxButtons.OK);
                                return;
                            }

                            byte[] bytes = hexToBytes(inputTrimSpace);

                            resp = Http.Post(url, bytes);
                        }
                        else
                        {
                            resp = Http.Post(url, System.Text.Encoding.UTF8.GetBytes(input));
                        }


                        
                    }
                    else
                    {
                        MessageBox.Show("Please input the data to POST.", "Tips", MessageBoxButtons.OK);
                    }

                   
                }
                else
                {
                    /*Get the data*/
                    resp = Http.Get(url);
                }


                if (resp != null)
                {
                    this.textBoxResp.Text = resp;
                }
            }
            
        }
    }
}

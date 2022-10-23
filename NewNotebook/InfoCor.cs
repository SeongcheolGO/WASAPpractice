﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace NewNotebook
{
  public partial class InfoCor : Form
  {
    const string DataFileName = "WASAP.txt";


    public InfoCor()
    {
      InitializeComponent();

      if (CheckExistDataFile())
      {
        string text = ReadDataFile();
        PdaText.Text = text;
      }
      else
      {
        TouchDataFile();
      }

    }




    private bool CheckExistDataFile()
    {
      bool exist = File.Exists(DataFileName);
      return exist;
    }

    private string ReadDataFile()
    {
      string text = System.IO.File.ReadAllText(DataFileName);
      return text;
    }

    private void TouchDataFile()
    {
      File.WriteAllText(DataFileName, "");
    }

    private void WriteDataFile()
    {
      File.WriteAllText(DataFileName, PdaText.Text);
    }

    private void PdaInput_Click(object sender, EventArgs e)
    {
      WriteDataFile();
      Close();
    }
  }
}

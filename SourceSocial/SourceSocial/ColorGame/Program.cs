﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            frmMain frm = new frmMain();
            System.Windows.Forms.Application.Run(frm);
        }
    }
}

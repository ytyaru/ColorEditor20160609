/**
 * ColorEditor20160609
 *
 * These codes are licensed under CC0.
 * http://creativecommons.org/publicdomain/zero/1.0/deed.ja
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ColorEditor20160609
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Application.Run(new Form2());
            Application.Run(new Form3());
            Application.Run(new Form4());
            Application.Run(new Form5());
            Application.Run(new Form6());
            Application.Run(new Form7());
        }
    }
}

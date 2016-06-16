/**
 * ColorEditor20160609
 *
 * These codes are licensed under CC0.
 * http://creativecommons.org/publicdomain/zero/1.0/deed.ja
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorEditor20160609
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // ColorDialog の新しいインスタンスを生成する (デザイナから追加している場合は必要ない)
            ColorDialog colorDialog1 = new ColorDialog();

            // 初期選択する色を設定する
            colorDialog1.Color = textBox1.BackColor;

            // カスタム カラーを定義可能にする (初期値 true)
            //colorDialog1.AllowFullOpen = true;

            // カスタム カラーを表示した状態にする (初期値 false)
            colorDialog1.FullOpen = true;

            // 使用可能なすべての色を基本セットに表示する (初期値 false)
            colorDialog1.AnyColor = true;

            // 純色のみ表示する (初期値 false)
            colorDialog1.SolidColorOnly = true;

            // カスタム カラーを任意の色で設定する
            //colorDialog1.CustomColors = new int[] { 0x8040FF, 0xFF8040, 0x80FF40, 0x4080FF };

            // [ヘルプ] ボタンを表示する
            colorDialog1.ShowHelp = true;

            // ダイアログを表示し、戻り値が [OK] の場合は選択した色を textBox1 に適用する
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }

            // 不要になった時点で破棄する (正しくは オブジェクトの破棄を保証する を参照)
            colorDialog1.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace redrock7
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void denglubutton_Click(object sender, RoutedEventArgs e)
        {
            if (zhanghaokuang.Text == "weilanxiao")
            {
                if (mimakuang.Password == "19971228")
                {
                    dengluye.Text = "登录成功";
                }
                else
                {
                    dengluye.Text = "密码错误";
                }
            }else
            {
                dengluye.Text = "请输入正确的账号";
            }
        }

        private void zhuce_Click(object sender, RoutedEventArgs e)
        {
            dengluye.Text = "按动了<注册>按钮";
        }

        private void wangjimima_Click(object sender, RoutedEventArgs e)
        {
            dengluye.Text = "按动了<忘记密码>按钮";
        }
    }
}

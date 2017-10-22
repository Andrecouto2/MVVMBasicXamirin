using System;

using Xamarin.Forms;

namespace XF.MVVMBasic.View
{
    public class AlunoView : ContentPage
    {
        public AlunoView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


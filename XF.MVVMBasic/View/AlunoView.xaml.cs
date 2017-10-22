using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XF.MVVMBasic.ViewModel
{
    public partial class AlunoView : ContentPage
    {
        AlunoViewModel vmAluno;

        public AlunoView()
        {
            var aluno = AlunoViewModel.GetAluno();
            vmAluno = new AlunoViewModel(aluno);
        
            BindingContext = vmAluno;
            InitializeComponent();
        }
    }
}

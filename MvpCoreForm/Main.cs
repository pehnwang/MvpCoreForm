using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MvpCoreForm.Uc.CuTree.Presenter;

namespace MvpCoreForm
{
    public partial class Main : Form
    {
        private TaskTreePresenter _presenter;

        public Main()
        {
            InitializeComponent();
            _presenter = new TaskTreePresenter(taskTree1);
        }
    }
}
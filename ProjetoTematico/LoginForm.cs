using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoTematico.Application;
using Teste;

namespace ProjetoTematico
{
    public partial class LoginForm : Form
    {
        // Definição de controles comuns a todos os formulários
        protected Panel headerPanel;
        protected Label headerLabel;
        protected Panel footerPanel;
        protected Label footerLabel;

        public LoginForm()
        {
            InitializeComponent();

            // Configuração do layout compartilhado
            SetupLayout();
        }

        private void SetupLayout()
        {
            //// Configuração do painel do cabeçalho
            //headerPanel = new Panel();
            //headerPanel.Dock = DockStyle.Top;
            //headerPanel.Height = 50;
            //headerPanel.BackColor = System.Drawing.Color.DarkBlue;

            //// Label do cabeçalho
            //headerLabel = new Label();
            //headerLabel.Text = "Cabeçalho";
            //headerLabel.ForeColor = System.Drawing.Color.White;
            //headerLabel.Dock = DockStyle.Fill;
            //headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //// Adiciona o label ao painel do cabeçalho
            //headerPanel.Controls.Add(headerLabel);

            //// Configuração do painel do rodapé
            //footerPanel = new Panel();
            //footerPanel.Dock = DockStyle.Bottom;
            //footerPanel.Height = 30;
            //footerPanel.BackColor = System.Drawing.Color.DarkBlue;

            //// Label do rodapé
            //footerLabel = new Label();
            //footerLabel.Text = "Rodapé";
            //footerLabel.ForeColor = System.Drawing.Color.White;
            //footerLabel.Dock = DockStyle.Fill;
            //footerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            //// Adiciona o label ao painel do rodapé
            //footerPanel.Controls.Add(footerLabel);

            //// Adiciona os painéis ao formulário base
            //this.Controls.Add(headerPanel);
            //this.Controls.Add(footerPanel);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!(this.txtLogin.Text != "" && this.txtSenha.Text != ""))
            {
                MessageBox.Show("Informe o usuário e a senha!");
                return;
            }
            if(UserService.Login(this.txtLogin.Text, this.txtSenha.Text))
            {
                //MessageBox.Show("Logado com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainLayout main = new MainLayout();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Falha no Login, verifique as credenciais!","Não Autorizado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}

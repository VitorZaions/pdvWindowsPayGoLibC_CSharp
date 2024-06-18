using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PGWLib.CustomObjects;

namespace PGWLib
{
    public partial class FormMenu : MetroForm
    {
        public class MenuItemRetorno
        {
            public string descricao;

            public string valormenu;

            public byte teclaatalho;
        }

        bool userAborted = false;
        PW_GetData _expectedData;
        string _ret = string.Empty;
        bool _SomentePix;
        List<MenuItemRetorno> Itens = new List<MenuItemRetorno>();

        public FormMenu(PW_GetData expectedData, bool SomentePix)
        {
            InitializeComponent();

            _expectedData = expectedData;
            _SomentePix = SomentePix;
            // Atribui o valor do prompt a ser exibido, substituindo a quebra de linha utilizada
            // pela biblioteca pela quebra de linha utilizada nos forms
            LblHeader.Text = expectedData.szPrompt.Replace("\r", "\n");

            // Preenche o ListBox com as opções
            PopulateMenu();

            LstMenu.DataSource = Itens;
            LstMenu.DisplayMember = "descricao";
            LstMenu.ValueMember = "valormenu";

            // Coloca o curso em cima do item padrão
            if (LstMenu.Items.Count > 0)
                LstMenu.SelectedIndex = 0;
        }

        // Exibe o menu para o usuário
        public void ShowDialog(ref bool abort, ref string value)
        {
            this.ShowDialog();

            if (LstMenu.SelectedIndex < 0) 
                userAborted = true;

            abort = userAborted;
            value = _ret;
        }

        // Coloca as opções no menu
        private void PopulateMenu()
        {           
            for (byte b = 0; b < _expectedData.bNumOpcoesMenu; b++)
            {
                if ((!_SomentePix && !_expectedData.vszTextoMenu[b].szTextoMenu.ToUpper().Contains("PIX")) || 
                    (_SomentePix && _expectedData.vszTextoMenu[b].szTextoMenu.ToUpper().Contains("PIX")))
                { 
                    if (_expectedData.bTeclasDeAtalho == 1 && b < 10)
                    {
                        MenuItemRetorno Menu = new MenuItemRetorno();
                        Menu.descricao = string.Format("{0}-{1}", b, _expectedData.vszTextoMenu[b].szTextoMenu);
                        Menu.teclaatalho = b;
                        Menu.valormenu = _expectedData.vszValorMenu[b].szValorMenu;
                        Itens.Add(Menu);
                    }
                    else
                    {
                        MenuItemRetorno Menu = new MenuItemRetorno();
                        Menu.descricao = string.Format("{0}", _expectedData.vszTextoMenu[b].szTextoMenu);
                        Menu.teclaatalho = b;
                        Menu.valormenu = _expectedData.vszValorMenu[b].szValorMenu;
                        Itens.Add(Menu);
                    }
                }
            }

            LstMenu.Focus();
        }

        // Tratamento de click de mouse
        private void LstMenu_MouseClick(object sender, MouseEventArgs e)
        {
            // Indica que uma opção não foi selecionada, retorna sem fazer nada
            if (LstMenu.SelectedIndex == -1) 
                return;

            MenuItemRetorno MenuSelecionado = (LstMenu.SelectedItem as MenuItemRetorno);
            if (MenuSelecionado != null)
            {
                LstMenu.SelectedItem = MenuSelecionado;
                _ret = MenuSelecionado.valormenu;
                this.Close();
            }
        }

        // Tratamento de ESC e ENTER no teclado
        private void KeyPressed(object sender, KeyEventArgs e)
        {
            // ESC pressionado, operação abortada
            if (e.KeyCode == Keys.Escape)
            {
                userAborted = true;
                this.Close();
            }

            // ENTER pressionado
            if (e.KeyCode == Keys.Enter)
            {
                // Se nenhuma opção selecionada, retorna sem fazer nada
                if (LstMenu.SelectedIndex == -1)
                    return;

                MenuItemRetorno MenuSelecionado = (LstMenu.SelectedItem as MenuItemRetorno);
                if (MenuSelecionado != null)
                {
                    LstMenu.SelectedItem = MenuSelecionado;
                    _ret = MenuSelecionado.valormenu;
                    this.Close();
                }
            }

            // Tecla numérica superior pressionada (0-9)
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                MenuItemRetorno MenuSelecionado = Itens.Where(o => o.teclaatalho == (e.KeyValue - 48)).First();
                if (MenuSelecionado != null)
                {
                    LstMenu.SelectedItem = MenuSelecionado;
                    _ret = MenuSelecionado.valormenu;
                    this.Close();
                }
            }

            // Tecla numérica keypad pressionada (0-9)
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                MenuItemRetorno MenuSelecionado = Itens.Where(o => o.teclaatalho == (e.KeyValue - 96)).First();
                if (MenuSelecionado != null) 
                { 
                    LstMenu.SelectedItem = MenuSelecionado;
                    _ret = MenuSelecionado.valormenu;
                    this.Close();
                }                
            }            
        }

        // Coloca o foco no menu ao carregar
        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
